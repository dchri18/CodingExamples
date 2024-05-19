using Builder.Example.Interfaces;
using Builder.Example.Products;

namespace Builder.Example
{
    public class ComputerBuilder : IComputerBuilder
    {
        private Computer _computer;

        public ComputerBuilder()
        {
            _computer = new Computer();
        }

        public IComputerBuilder SetProcessor(string processor)
        {
            _computer.Processor = processor;
            return this;
        }

        public IComputerBuilder SetMotherBoard(string motherBoard)
        {
            _computer.MotherBoard = motherBoard;
            return this;
        }

        public IComputerBuilder SetRAM(string ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public IComputerBuilder SetGraphicsCard(string graphicsCard)
        {
            _computer.GraphicsCard = graphicsCard;
            return this;
        }

        public IComputerBuilder SetPowerSupply(string powerSupply)
        {
            _computer.PowerSupply = powerSupply;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}
