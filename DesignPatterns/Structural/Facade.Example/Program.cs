using Facade.Example.Components;

namespace Facade.Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DVDPlayer dvdPlayer = new DVDPlayer();
            Amplifier amplifier = new Amplifier();
            Projector projector = new Projector();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(dvdPlayer, amplifier, projector);

            homeTheater.WatchMovie("Inception");
            Console.WriteLine();
            homeTheater.EndMovie();
        }
    }
}
