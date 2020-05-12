using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ted = new ChatUser("Ted");
            var mark = new ChatUser("Mark");
            var julia = new ChatUser("Julia");

            var chat = new Chat();
            chat.AddUser(ted);
            chat.AddUser(mark);
            chat.AddUser(julia);

            ted.SendMessage("Hi All!");
            mark.SendMessage("What's up :)");
            julia.SendMessage("Hello");

            Console.ReadLine();
        }
    }
}
