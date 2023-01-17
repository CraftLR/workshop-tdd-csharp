using System;
using System.Collections.Generic;

using FluentAssertions;

using Xunit;

using static CraftLR.Exercice4.Movement;

namespace CraftLR.Exercice4;

public class RobotTest
{

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestRobotIsCreatedWithCorrectInitialPosition()
    {
        GridPosition initialGridPosition = new(0, 0);
        Robot robot = new(initialGridPosition, Orientation.NORTH);
        Assert.Equal(initialGridPosition, robot.Position);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestRobotIsCreatedWithCorrectInitialOrientation()
    {
        Orientation initialOrientation = Orientation.NORTH;
        Robot robot = new(new GridPosition(0, 0), initialOrientation);
        Assert.Equal(initialOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningRightDoesNotChangePosition()
    {
        GridPosition initialGridPosition = new(0, 0);
        Robot robot = new(initialGridPosition, Orientation.NORTH);
        robot.TurnRight();
        GridPosition expectedPosition = new(0, 0);
        Assert.Equal(expectedPosition, robot.Position);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningRightCorrectlyChangesOrientationFromNorthToEast()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.NORTH);
        robot.TurnRight();
        Orientation expectedOrientation = Orientation.EAST;
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningRightCorrectlyChangesOrientationFromEastToSouth()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.EAST);
        robot.TurnRight();
        Orientation expectedOrientation = Orientation.SOUTH;
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningRightCorrectlyChangesOrientationFromSouthToWest()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.SOUTH);
        robot.TurnRight();
        Orientation expectedOrientation = Orientation.WEST;
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningRightCorrectlyChangesOrientationFromWestToNorth()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.WEST);
        robot.TurnRight();
        Orientation expectedOrientation = Orientation.NORTH;
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningLeftDoesNotChangePosition()
    {
        GridPosition initialGridPosition = new(0, 0);
        Robot robot = new(initialGridPosition, Orientation.NORTH);
        robot.TurnLeft();
        GridPosition expectedPosition = new(0, 0);
        Assert.Equal(expectedPosition, robot.Position);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningLeftCorrectlyChangesOrientationFromNorthToWest()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.NORTH);
        robot.TurnLeft();
        Orientation expectedOrientation = Orientation.WEST;
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningLeftCorrectlyChangesOrientationFromWestToSouth()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.WEST);
        robot.TurnLeft();
        Orientation expectedOrientation = Orientation.SOUTH;
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningLeftCorrectlyChangesOrientationFromSouthToEast()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.SOUTH);
        robot.TurnLeft();
        Orientation expectedOrientation = Orientation.EAST;
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestTurningLeftCorrectlyChangesOrientationFromEastToNorth()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.EAST);
        robot.TurnLeft();
        Orientation expectedOrientation = Orientation.NORTH;
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestAdvancingDoesNotChangeOrientation()
    {
        Orientation initialOrientation = Orientation.NORTH;
        Robot robot = new(new GridPosition(0, 0), initialOrientation);
        robot.Advance();
        Assert.Equal(initialOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestAdvancingWhenFacingNorthIncreasesYCoordinateByOne()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.NORTH);
        robot.Advance();
        GridPosition expectedGridPosition = new(0, 1);
        Assert.Equal(expectedGridPosition, robot.Position);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestAdvancingWhenFacingSouthDecreasesYCoordinateByOne()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.SOUTH);
        robot.Advance();
        GridPosition expectedGridPosition = new(0, -1);
        Assert.Equal(expectedGridPosition, robot.Position);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestAdvancingWhenFacingEastIncreasesXCoordinateByOne()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.EAST);
        robot.Advance();
        GridPosition expectedGridPosition = new(1, 0);
        Assert.Equal(expectedGridPosition, robot.Position);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestAdvancingWhenFacingWestDecreasesXCoordinateByOne()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.WEST);
        robot.Advance();
        GridPosition expectedGridPosition = new(-1, 0);
        Assert.Equal(expectedGridPosition, robot.Position);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestInstructionsToMoveWestAndNorth()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.NORTH);
        RobotSimulator simulator = new(robot, "LAAARALA");
        simulator.Simulate();
        GridPosition expectedGridPosition = new(-4, 1);
        Orientation expectedOrientation = Orientation.WEST;
        Assert.Equal(expectedGridPosition, robot.Position);
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestInstructionsToMoveWestAndSouth()
    {
        Robot robot = new(new GridPosition(2, -7), Orientation.EAST);
        RobotSimulator simulator = new(robot, "RRAAAAALA");
        simulator.Simulate();
        GridPosition expectedGridPosition = new(-3, -8);
        Orientation expectedOrientation = Orientation.SOUTH;
        Assert.Equal(expectedGridPosition, robot.Position);
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestInstructionsToMoveEastAndNorth()
    {
        Robot robot = new(new GridPosition(8, 4), Orientation.SOUTH);
        RobotSimulator simulator = new(robot, "LAAARRRALLLL");
        simulator.Simulate();
        GridPosition expectedGridPosition = new(11, 5);
        Orientation expectedOrientation = Orientation.NORTH;
        Assert.Equal(expectedGridPosition, robot.Position);
        Assert.Equal(expectedOrientation, robot.Orientation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestListInstructionsToMoveWestAndNorth()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.NORTH);
        RobotSimulator simulator = new(robot, "LAARALA");
        List<Movement> movements = simulator.GetMovements();
        movements.Should().ContainInConsecutiveOrder(LEFT, ADVANCE, ADVANCE, RIGHT, ADVANCE, LEFT, ADVANCE);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestListInstructionsToMoveWestAndNorthBis()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.NORTH);
        RobotSimulator simulator = new(robot, "L A A R A L A");
        List<Movement> movements = simulator.GetMovements();
        movements.Should().ContainInConsecutiveOrder(LEFT, ADVANCE, ADVANCE, RIGHT, ADVANCE, LEFT, ADVANCE);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]

    public void TestListInstructionsToMoveWestAndNorthTer()
    {
        Robot robot = new(new GridPosition(0, 0), Orientation.NORTH);
        RobotSimulator simulator = new(robot, "LAA  RA   LA");

        IEnumerable<Movement> movements = simulator.GetMovements();

        movements.Should().ContainInConsecutiveOrder(LEFT, ADVANCE, ADVANCE, RIGHT, ADVANCE, LEFT, ADVANCE);
    }
}
