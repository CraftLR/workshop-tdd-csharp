using System;
using System.Collections.Generic;


namespace CraftLR.Exercice4;


public class RobotSimulator
{
    public Robot Robot { get; }

    public string Instructions { get; }

    public RobotSimulator(Robot robot, string instructions)
    {
        this.Robot = robot;
        this.Instructions = instructions;
    }

    public void Simulate()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public List<Movement> GetMovements()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
