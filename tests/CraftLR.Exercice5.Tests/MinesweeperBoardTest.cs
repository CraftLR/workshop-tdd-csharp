using System;
using System.Collections.Generic;
using System.Linq;

using FluentAssertions;

using Xunit;

namespace CraftLR.Exercice5;

public class MinesweeperBoardTest
{

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_No_Rows_And_No_Columns()
    {
        var inputBoard = Enumerable.Empty<string>().ToList(); ;
        var expectedAnnotatedRepresentation = Enumerable.Empty<string>().ToList(); ;
        var actualAnnotatedRepresentation = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;

        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_One_Row_And_No_Columns()
    {
        var inputBoard = Enumerable.Repeat("", 1); ;
        var expectedAnnotatedRepresentation = Enumerable.Repeat("", 1); ;
        var actualAnnotatedRepresentation = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_No_Mines()
    {
        var inputBoard = new List<string>() {
                "   ",
                "   ",
                "   "
        };
        var expectedAnnotatedRepresentation = new List<string>() {
                "   ",
                "   ",
                "   "
        };
        var actualAnnotatedRepresentation
                = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Only_Mines()
    {
        var inputBoard = new List<string>() {
                "***",
                "***",
                "***"
        };

        var expectedAnnotatedRepresentation = new List<string>() {
                "***",
                "***",
                "***"
        };
        var actualAnnotatedRepresentation = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Single_Mine_At_Center()
    {
        var inputBoard = new List<string>() {
                "   ",
                " * ",
                "   "
        };
        var expectedAnnotatedRepresentation = new List<string>() {
                "111",
                "1*1",
                "111"
        };
        var actualAnnotatedRepresentation = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Mines_Around_Perimeter()
    {
        var inputBoard = new List<string>() {
                "***",
                "* *",
                "***"
        };
        var expectedAnnotatedRepresentation = new List<string>() {
                "***",
                "*8*",
                "***"
        };
        var actualAnnotatedRepresentation
                = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Single_Row_And_Two_Mines()
    {
        var inputBoard = Enumerable.Repeat(" * * ", 1);
        var expectedAnnotatedRepresentation = Enumerable.Repeat("1*2*1", 1);
        var actualAnnotatedRepresentation = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Single_Row_And_Two_Mines_At_Edges()
    {
        var inputBoard = Enumerable.Repeat("*   *", 1);
        var expectedAnnotatedRepresentation = Enumerable.Repeat("*1 1*", 1);
        var actualAnnotatedRepresentation = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Single_Column_And_Two_Mines()
    {
        var inputBoard = new List<string>() {
                " ",
                "*",
                " ",
                "*",
                " "
        };
        var expectedAnnotatedRepresentation = new List<string>() {
                "1",
                "*",
                "2",
                "*",
                "1"
        };
        var actualAnnotatedRepresentation
                = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Single_Column_And_Two_Mines_At_Edges()
    {
        var inputBoard = new List<string>() {
                "*",
                " ",
                " ",
                " ",
                "*"
        };
        var expectedAnnotatedRepresentation = new List<string>() {
                "*",
                "1",
                " ",
                "1",
                "*"
        };
        var actualAnnotatedRepresentation
                = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Mines_In_Cross()
    {
        var inputBoard = new List<string>() {
                "  *  ",
                "  *  ",
                "*****",
                "  *  ",
                "  *  "
        };
        var expectedAnnotatedRepresentation = new List<string>() {
                " 2*2 ",
                "25*52",
                "*****",
                "25*52",
                " 2*2 "
        };
        var actualAnnotatedRepresentation
                = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Large_Input_Board()
    {
        var inputBoard = new List<string>() {
                " *  * ",
                "  *   ",
                "    * ",
                "   * *",
                " *  * ",
                "      "
        };
        var expectedAnnotatedRepresentation = new List<string>() {
                "1*22*1",
                "12*322",
                " 123*2",
                "112*4*",
                "1*22*2",
                "111111"
        };
        var actualAnnotatedRepresentation
                = new MinesweeperBoard(inputBoard).AnnotatedRepresentation;
        Assert.Equal(expectedAnnotatedRepresentation, actualAnnotatedRepresentation);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Null_Input_Board_Is_Rejected()
    {
        Exception exception = Assert.Throws<ArgumentException>(
                () => new MinesweeperBoard(null));
        Assert.Equal("Input board may not be null.", exception.Message);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Invalid_Symbols_Is_Rejected()
    {
        Exception exception = Assert.Throws<ArgumentException>(
                    () => new MinesweeperBoard(Enumerable.Repeat(" * & ", 1)));
        Assert.Equal("Input board can only contain the characters ' ' and '*'.", exception.Message);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_Input_Board_With_Inconsistent_Row_Lengths_Is_Rejected()
    {
        Exception exception = Assert.Throws<ArgumentException>(
                    () => new MinesweeperBoard(new List<string>() {
                            "*",
                            "**",
                            "* *",
                            "*  *",
                            "*   *"
                    }));
        Assert.Equal("Input board rows must all have the same number of columns.", exception.Message);
    }
}
