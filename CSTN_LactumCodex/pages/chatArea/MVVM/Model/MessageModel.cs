using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTN_LactumCodex.pages.chatArea.MVVM.Model
{
    class MessageModel
    {
        public String Username { get; set; }
        public String UsernameColor { get; set; }
        //        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrg { get; set; }
        public bool? FirstMess { get; set; }


    }
}
