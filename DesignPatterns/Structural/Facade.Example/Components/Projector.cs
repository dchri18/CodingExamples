namespace Facade.Example.Components
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector is on.");
        }

        public void Off()
        {
            Console.WriteLine("Projector is off.");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Projector in widescreen mode (16x9 aspect ratio).");
        }
    }
}
