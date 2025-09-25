using OopExamples.Interfaces;
using OopExamples.Interfaces.Exceptions;

namespace OopExamples.Classes;

public class ComputerBuilder: IComputerBuilder
{
    private IComputer _computer;
    private IComputerBuilder _builder;
    
    public IComputer BuildFromConfiguration(IComputerConfiguration configuration)
    {
        return new Computer(configuration);
    }

    public IComputerBuilder AddMotherBoard(IMotherBoard motherBoard)
    {
        if (!string.IsNullOrEmpty(motherBoard.Name))
        {
            throw new ComponentAlreadyConnectedException("Motherboard already connected");
        }
        _builder.AddMotherBoard(motherBoard);
        return this;   
    }

    public IComputerBuilder AddCPU(ICPU cpu)
    {
        if (!string.IsNullOrEmpty(cpu.Name))
        {
            throw new ComponentAlreadyConnectedException("CPU already connected");
        }
        _builder.AddCPU(cpu);
        return this;
    }

    public IComputerBuilder AddGPU(IGPU gpu)
    {
        if (!string.IsNullOrEmpty(gpu.Name))
        {
            throw new ComponentAlreadyConnectedException("GPU already connected");
        }
        _builder.AddGPU(gpu);
        return this;
    }

    public IComputerBuilder AddRam(IRAM ram)
    {
        if (!string.IsNullOrEmpty(ram.Name))
        {
            throw new ComponentAlreadyConnectedException("RAM already connected");
        }
        _builder.AddRam(ram);
        return this;
    }

    public IComputerBuilder AddPowerSupply(IPowerSupply powerSupply)
    {
        if (!string.IsNullOrEmpty(powerSupply.Name))
        {
            throw new ComponentAlreadyConnectedException("PowerSupply already connected");
        }
        _builder.AddPowerSupply(powerSupply);
        return this;
    }

    public IComputerBuilder AddCase(ICase pcCase)
    {
        if (!string.IsNullOrEmpty(pcCase.Name))
        {
            throw new ComponentAlreadyConnectedException("Case already connected");
        }
        _builder.AddCase(pcCase);
        return this;
    }

    public IComputer Build()
    {
        Computer computer = new Computer(_builder);
        return computer;
    }
}