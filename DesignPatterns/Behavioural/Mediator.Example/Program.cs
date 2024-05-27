using Mediator.Example.Interfaces;

namespace Mediator.Example
{
    public class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            User user1 = new ConcreteUser(chatMediator, "User1");
            User user2 = new ConcreteUser(chatMediator, "User2");
            User user3 = new ConcreteUser(chatMediator, "User3");
            User user4 = new ConcreteUser(chatMediator, "User4");

            chatMediator.AddUser(user1);
            chatMediator.AddUser(user2);
            chatMediator.AddUser(user3);
            chatMediator.AddUser(user4);

            user1.Send("Hello everyone!");
            user2.Send("Hi User1!");
        }
    }
}
