using State.Example.Interfaces;
using State.Example.States;

namespace State.Example
{
    public class MediaPlayer
    {
        private IState _state;

        public MediaPlayer()
        {
            _state = new StoppedState(); // initial state
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void Play()
        {
            _state.Play(this);
        }

        public void Pause()
        {
            _state.Pause(this);
        }

        public void Stop()
        {
            _state.Stop(this);
        }
    }

}
