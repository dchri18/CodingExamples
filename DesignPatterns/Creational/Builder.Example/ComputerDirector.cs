using Builder.Example.Interfaces;
using Builder.Example.Products;

namespace Builder.Example
{
    public class ComputerDirector
    {
        private IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public Computer BuildGamingComputer()
        {
            return _builder
                .SetProcessor("Intel Core i9-9900K")
                .SetMotherBoard("ASUS ROG Maximus XI Hero")
                .SetRAM("32GB DDR4 3200MHz")
                .SetGraphicsCard("NVIDIA GeForce RTX 2080 Ti")
                .SetPowerSupply("Corsair RM850x 850W")
                .Build();
        }

        public Computer BuildOfficeComputer()
        {
            return _builder
                .SetProcessor("Intel Core i5-9400F")
                .SetMotherBoard("ASUS Prime H310M-K R2.0")
                .SetRAM("8GB DDR4 2666MHz")
                .SetPowerSupply("EVGA 500W")
                .Build();
        }
    }
}
