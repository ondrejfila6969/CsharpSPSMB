using OopExamples.Interfaces;

namespace OopExamples.Classes;

public class Monitor: IMonitor
{
    public string Name { get; set; }

    public Monitor(string name)
    {
        Name = name;
    }
}