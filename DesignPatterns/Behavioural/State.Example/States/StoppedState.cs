using State.Example.Interfaces;

namespace State.Example.States
{
    public class StoppedState : IState
    {
        public void Play(MediaPlayer player)
        {
            Console.WriteLine("Starting play.");
            player.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer player)
        {
            Console.WriteLine("Player is stopped. Can't pause.");
        }

        public void Stop(MediaPlayer player)
        {
            Console.WriteLine("Already stopped.");
        }
    }
}
