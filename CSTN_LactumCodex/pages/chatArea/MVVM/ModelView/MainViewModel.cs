using CSTN_LactumCodex.pages.chatArea.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTN_LactumCodex.pages.chatArea.MVVM.ModelView
{
    class MainViewModel
    {

        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContributorModel> Contributors { get; set; }
        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contributors = new ObservableCollection<ContributorModel>();

            Messages.Add(new MessageModel
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
            });

            for (int i = 0; i < 5; i++)
            {
                Contributors.Add(new ContributorModel {
                
                    Username = $"Allison",
                    Messages = Messages,

                });
            }

        }

    }
}
