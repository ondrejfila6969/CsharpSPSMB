using OopExamples.Interfaces;
using OopExamples.Interfaces.Exceptions;

namespace OopExamples.Classes;

public class Computer: IComputer
{
    public IComputerConfiguration Configuration { get; set; }
    
    public IComputerBuilder ComputerBuilder { get; set; }
    public IEntity Owner { get; init; }
    public IMotherBoard MotherBoard { get; set; }
    public ICPU Cpu { get; init; }
    public IGPU Gpu { get; init; }
    public IRAM Ram { get; init; }
    public IPowerSupply PowerSupply { get; init; }
    public ICase Case { get; init; }
    public IMonitor[] Monitors { get; init; }
    public bool IsOn { get; set; }
    public bool IsPersonalPC { get; }
    public bool IsCompanyPC { get; }

    public Computer(IComputerConfiguration configuration)
    {
        Configuration = configuration;
    }

    public Computer(IComputerBuilder builder)
    {
        ComputerBuilder = builder;
    }
    
    public Computer(IEntity owner, IComputerConfiguration configuration, IMonitor[] monitors)
    {
        Owner = owner;
        Configuration = configuration;
        Monitors = monitors;
    }
    
    public Computer(IEntity owner, IMotherBoard motherBoard, ICPU cpu, IGPU gpu, IRAM ram, IPowerSupply powerSupply, ICase @case, IMonitor[] monitors)
    {
        Owner = owner;
        MotherBoard = motherBoard;
        Cpu = cpu;
        Gpu = gpu;
        Ram = ram;
        PowerSupply = powerSupply;
        Case = @case;
        Monitors = monitors;
    }
    
    public void PowerUp()
    {
        if (!IsOn)
        {
            IsOn = true;
        }
    }

    public void ShutDown()
    {
        if (IsOn)
        {
            IsOn = false;
        }
    }

    public void PressPowerButton()
    {
        
    }

    public void Print(string text)
    {
        Console.WriteLine(text);
    }

    public float Compute(string equation)
    {
        throw new NotImplementedException();
    }

    public IComputer BuildNewComputer(IComputerConfiguration configuration)
    {
        Computer computer = new Computer(configuration);
        return computer;
    }
}