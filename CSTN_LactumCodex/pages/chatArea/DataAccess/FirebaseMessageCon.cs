using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSTN_LactumCodex.pages.chatArea.MVVM.Model;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;


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
                   .SetAsync($"Messages/{messageM.Username}/{DateTime.Now}" ,messageM);
        }


        public ObservableCollection<MessageModel> CreateList()
        {

            FirebaseResponse Resp = _FBclient.Get($"Messages/");

            string rsp = Resp.Body.ToString();

            var json = JsonConvert.DeserializeObject<Dictionary<string, object>>(rsp);

            ObservableCollection<MessageModel> Lstmessage = new ObservableCollection<MessageModel>();

            if (json == null) 
            {
             return Lstmessage;
            }

            foreach (var item in json) 
            {

               // Lstmessage.Add(item.Value);

            }
            return Lstmessage;
        }

        IFirebaseConfig Config = new FirebaseConfig()
        {
            AuthSecret = "tn1jfewmHZlOC8RmftWurhpAor02l6D3XYDZjE8B",
            BasePath = FirebaseDataUrl,

        };

    }
}