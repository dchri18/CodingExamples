using Builder.Example.Products;

namespace Builder.Example.Interfaces
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetProcessor(string processor);
        IComputerBuilder SetMotherBoard(string motherBoard);
        IComputerBuilder SetRAM(string ram);
        IComputerBuilder SetGraphicsCard(string graphicsCard);
        IComputerBuilder SetPowerSupply(string powerSupply);
        Computer Build();
    }
}
