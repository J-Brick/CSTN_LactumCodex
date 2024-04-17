using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTN_LactumCodex.pages.chatArea.MVVM.Model
{
    class ContributorModel
    {
        public string Username { get; set; }
//        public string ImageSource { get; set; }
          public ObservableCollection<MessageModel> Messages { get; set; }
        public string LastMess => Messages.Last().Message;



    }
}
