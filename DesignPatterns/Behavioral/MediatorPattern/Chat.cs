using System.Collections.Generic;

namespace MediatorPattern
{
    public class Chat : IChatMediator
    {
        private readonly Dictionary<string, ChatUser> users = new Dictionary<string, ChatUser>();

        public void AddUser(ChatUser user)
        {
            if (!users.ContainsKey(user.Name))
            {
                users.Add(user.Name, user);
                user.ChatMediator = this;
            }
        }

        public void SendMessage(string from, string text)
        {
            foreach (var user in users.Values)
            {
                user.ReceiveMessage(from, text);
            }
        }
    }
}
