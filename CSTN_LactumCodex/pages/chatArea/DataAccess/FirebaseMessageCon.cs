using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using CSTN_LactumCodex.pages.chatArea.MVVM.Model;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace CSTN_LactumCodex.pages.chatArea.DataAccess
{
    class FirebaseMessageCon
    {

        private const string FirebaseDataUrl = "https://lactum-codex-default-rtdb.firebaseio.com/";
        private readonly FirebaseClient _FBclient;

        

        public FirebaseMessageCon()
        {
            _FBclient = new FirebaseClient(Config);
        }

        public async Task AddMessage(MessageModel messageM)
        {
            await _FBclient
                   .SetAsync($"Messages/{GetUser()}" ,messageM);
        }


        public ObservableCollection<MessageModel> CreateList()
        {
            string test = GetUser();
            FirebaseResponse Resp = _FBclient.Get($"Messages/"+test);

            string rsp = Resp.Body.ToString();

            var json = JsonConvert.DeserializeObject<Dictionary<string, object>>(rsp);

            ObservableCollection<MessageModel> Lstmessage = new ObservableCollection<MessageModel>();

            if (json == null) 
            {
             return Lstmessage;
            }

            foreach (var item in json) 
            {
/*                MessageModel RecMessage = new MessageModel();
                dynamic data = JObject.Parse((string)item.Value)["id"].ToString();

//               JsonObject.Parse(item.Value.ToString());
                 RecMessage.Message = data.Messages;
                Lstmessage.Add((MessageModel)item.Value);*/
            }
            return Lstmessage;
        }

        IFirebaseConfig Config = new FirebaseConfig()
        {
            AuthSecret = "tn1jfewmHZlOC8RmftWurhpAor02l6D3XYDZjE8B",
            BasePath = FirebaseDataUrl,

        };


        public string GetUser()
        {

            if (LoginPage._FBCL.User != null)
            {
                return LoginPage._FBCL.User.Info.DisplayName;
            }

            return "";
      
        }


    }
}