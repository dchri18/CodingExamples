namespace Builder.Example.Products
{
    public class Computer
    {
        public string Processor { get; set; }
        public string MotherBoard { get; set; }
        public string RAM { get; set; }
        public string GraphicsCard { get; set; }
        public string PowerSupply { get; set; }

        public override string ToString()
        {
            return $"Computer Configuration:\n" +
                   $"Processor: {Processor}\n" +
                   $"Motherboard: {MotherBoard}\n" +
                   $"RAM: {RAM}\n" +
                   $"Graphics Card: {GraphicsCard}\n" +
                   $"Power Supply: {PowerSupply}";
        }
    }
}
