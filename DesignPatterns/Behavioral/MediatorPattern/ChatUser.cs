using DesignPatterns.Core;

namespace MediatorPattern
{
    public class ChatUser
    {
        public string Name { get; }
        public IChatMediator ChatMediator { get; set; }

        public ChatUser(string name)
        {
            Name = name;
        }

        public void SendMessage(string text)
        {
            LogHelper.Log($"{Name} sent message: {text}");
            ChatMediator.SendMessage(Name, text);
        }

        public void ReceiveMessage(string from, string text)
        {
            if (from != Name)
            {
                LogHelper.Log($"{Name} received message from: {from} - {text}");
            }
        }
    }
}
