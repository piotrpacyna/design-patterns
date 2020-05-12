namespace MediatorPattern
{
    public interface IChatMediator
    {
        void AddUser(ChatUser user);
        void SendMessage(string from, string text);
    }
}
