namespace Facade.Example.Components
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Amplifier is on.");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"Amplifier volume set to {level}.");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier is off.");
        }
    }
}
