namespace OopExamples.Interfaces.Exceptions;

public class ComponentNotConnectedException : Exception
{
    public ComponentNotConnectedException() : base()
    {
        throw new ComponentNotConnectedException();
    }
}