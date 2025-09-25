using OopExamples.Interfaces;
using OopExamples.Interfaces.Exceptions;

namespace OopExamples.Classes;

public class GPU: IGPU
{
    private IComputer _computer;
    public string Name { get; set; }
    public GPUConnector[] Connectors { get; init; }
    public IComputer? Computer { get; }
    public GPUConnector[] AvailableConnectors { get; }
    public IMonitor[] ConnectedMonitors { get; }
    public bool IsUsed { get; set; }

    public GPU(string name, GPUConnector[] connectors, IComputer? computer, GPUConnector[] availableConnectors, IMonitor[] connectedMonitors)
    {
        Name = name;
        Connectors = connectors;
        Computer = computer;
        AvailableConnectors = availableConnectors;
        ConnectedMonitors = connectedMonitors;
        IsUsed = false;
    }
    
    public void Connect(IComputer computer)
    {
        if (!string.IsNullOrEmpty(computer.Gpu.Name))
        {
            throw new ComponentAlreadyConnectedException("GPU already connected");
        }
        computer = null;
    }

    public void Disconnect()
    {
        if (string.IsNullOrEmpty(_computer.Gpu.Name))
        {
            throw new ComponentNotConnectedException("GPU not connected");
        }
    }

    public void ConnectMonitor(IMonitor monitor)
    {
        if (!string.IsNullOrEmpty(monitor.Name))
        {
            throw new ComponentAlreadyConnectedException("Monitor already connected");
        }

        int index = 0;
        foreach (GPUConnector availableConnector in _computer.Gpu.AvailableConnectors)
        {
            if (_computer.Gpu.Connectors[index] != availableConnector)
            {
                throw new InvalidConnectorException("Monitor cannot be connected");
            }

            index++;
            _computer.Monitors.Append(monitor);
        }

    }

    public void DisconnectMonitor(IMonitor monitor)
    {
        _computer.Monitors[0] = null;
    }
}