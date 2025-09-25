using OopExamples.Interfaces;

namespace OopExamples.Classes;

public class Component: IComponent
{
    public string Name { get; set; }

    public Component(string name)
    {
        Name = name;
    }
}