namespace Mediator.Example.Interfaces
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);
        void AddUser(User user);
    }
}
