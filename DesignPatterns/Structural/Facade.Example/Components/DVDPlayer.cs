﻿namespace Facade.Example.Components
{
    public class DVDPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD Player is on.");
        }

        public void Play(string movie)
        {
            Console.WriteLine($"Playing \"{movie}\".");
        }

        public void Stop()
        {
            Console.WriteLine("DVD Player stopped.");
        }

        public void Off()
        {
            Console.WriteLine("DVD Player is off.");
        }
    }
}
