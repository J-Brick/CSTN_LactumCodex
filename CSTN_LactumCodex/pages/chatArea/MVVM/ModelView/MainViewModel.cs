using CSTN_LactumCodex.pages.chatArea.Core;
using CSTN_LactumCodex.pages.chatArea.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CSTN_LactumCodex.pages.chatArea.Core;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CSTN_LactumCodex.pages.chatArea.DataAccess;

namespace CSTN_LactumCodex.pages.chatArea.MVVM.ModelView
{ 

    class MainViewModel : ObservableObject
    {

        FirebaseMessageCon FMC = new FirebaseMessageCon();

        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContributorModel> Contributors { get; set; }

        /*commands*/

        public RelayCommand SendCommand { get; set; }
        private ContributorModel _selectedContributor;


        public ContributorModel SelectedContributor
         {
            get { return _selectedContributor; }
            set {  _selectedContributor = value; 
            OnPropertyChanged();
            }
         }

        private String _message;

        public String Message
        {
            get { return _message; } 
            set { 
                _message = value;
                OnPropertyChanged();
            }

        }


        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contributors = new ObservableCollection<ContributorModel>(); 
            Messages = FMC.CreateList();
            ContributorModel CM = new ContributorModel();
            
            SendCommand = new RelayCommand(o => 
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMess = false,
                    Username = FMC.GetUser()
                });
                addmessage();
                Messages = FMC.CreateList();



            });
            Messages = FMC.CreateList();





            /*            Messages.Add(new MessageModel
                        {
                            Username = "Allison",
                            UsernameColor = "#409aff",
                            Message = "test",
                            Time = DateTime.Now,
                            IsNativeOrg = true,
                            FirstMess = true
                        });

                        for (int i = 0; i < 3; i++)
                        {
                            Messages.Add(new MessageModel
                            {
                                Username = "Allison",
                                UsernameColor = "#409aff",
                                Message = "test",
                                Time = DateTime.Now,
                                IsNativeOrg = true,
                                FirstMess = true
                            });
                        }

                        for (int i = 0; i < 3; i++)
                        {
                            Messages.Add(new MessageModel
                            {
                                Username = "barry",
                                UsernameColor = "#409aff",
                                Message = "test",
                                Time = DateTime.Now,
                                IsNativeOrg = true
                            });
                        }

                        Messages.Add(new MessageModel
                        {
                            Username = "barry",
                            UsernameColor = "#409aff",
                            Message = "test",
                            Time = DateTime.Now,
                            IsNativeOrg = true
                        });*/

            Contributors.Add(new ContributorModel {
                
                    Username = $"Allison",
                    Messages = Messages,

                });


 

        }

        public void addmessage()
        {
            foreach(MessageModel message in Messages)
            {
               FMC.AddMessage(message);
            }
        }



    }
}
