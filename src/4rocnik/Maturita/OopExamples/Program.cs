// See https://aka.ms/new-console-template for more information

using OopExamples.Classes;
using OopExamples.Interfaces;

Console.WriteLine("Hello, World!");

IComputerBuilder builder = new ComputerBuilder();

var computer = builder
    .AddCase(null)
    .AddCPU(null)
    .AddGPU(null)
    .AddCPU(null)
    .AddMotherBoard(null)
    .AddPowerSupply(null)
    .AddRam(null)
    .Build();