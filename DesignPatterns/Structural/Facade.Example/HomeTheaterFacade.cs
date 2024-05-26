using Facade.Example.Components;

namespace Facade.Example
{
    public class HomeTheaterFacade
    {
        private readonly DVDPlayer _dvdPlayer;
        private readonly Amplifier _amplifier;
        private readonly Projector _projector;

        public HomeTheaterFacade(DVDPlayer dvdPlayer, Amplifier amplifier, Projector projector)
        {
            _dvdPlayer = dvdPlayer;
            _amplifier = amplifier;
            _projector = projector;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch a movie...");
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _dvdPlayer.Stop();
            _dvdPlayer.Off();
            _amplifier.Off();
            _projector.Off();
        }
    }
}
