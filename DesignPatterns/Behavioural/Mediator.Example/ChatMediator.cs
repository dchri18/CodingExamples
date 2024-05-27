using Mediator.Example.Interfaces;

namespace Mediator.Example
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                // Message should not be received by the user sending it
                if (user != sender)
                {
                    user.Receive(message);
                }
            }
        }
    }

}
