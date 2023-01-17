using System;

namespace CraftLR.Exercice4;

public class Robot
{
    public Robot(GridPosition gridPosition, Orientation orientation)
    {
        this.Position = gridPosition;
        this.Orientation = orientation;
    }

    public GridPosition Position { get; }

    public int X
    {
        get
        {
            return Position.X;
        }
    }

    public int Y
    {
        get
        {
            return Position.Y;
        }
    }

    public Orientation Orientation { get; }

    public void TurnRight()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public void TurnLeft()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public void Advance()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}

