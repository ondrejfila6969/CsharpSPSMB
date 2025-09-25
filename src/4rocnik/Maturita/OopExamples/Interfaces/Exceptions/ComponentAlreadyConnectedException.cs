namespace OopExamples.Interfaces.Exceptions;

public class ComponentAlreadyConnectedException : Exception
{
    public ComponentAlreadyConnectedException(): base()
    {
        throw new ComponentAlreadyConnectedException();
    }
}