namespace OopExamples.Interfaces.Exceptions;

public class InvalidConnectorException : Exception
{
    public InvalidConnectorException() : base()
    {
        throw new InvalidConnectorException();
    }
}