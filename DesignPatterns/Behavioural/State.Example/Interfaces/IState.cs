namespace State.Example.Interfaces
{
    public interface IState
    {
        void Play(MediaPlayer player);
        void Pause(MediaPlayer player);
        void Stop(MediaPlayer player);
    }
}
