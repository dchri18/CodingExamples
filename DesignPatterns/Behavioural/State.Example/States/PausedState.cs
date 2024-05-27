using State.Example.Interfaces;

namespace State.Example.States
{
    public class PausedState : IState
    {
        public void Play(MediaPlayer player)
        {
            Console.WriteLine("Resuming play.");
            player.SetState(new PlayingState());
        }

        public void Pause(MediaPlayer player)
        {
            Console.WriteLine("Already paused.");
        }

        public void Stop(MediaPlayer player)
        {
            Console.WriteLine("Stopping the player from pause.");
            player.SetState(new StoppedState());
        }
    }
}
