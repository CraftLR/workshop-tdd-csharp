using FluentAssertions;

using Xunit;

namespace CraftLR.Exercice2;

public class FizzBuzzTest
{
    private readonly FizzBuzzer _fizzBuzz = new();

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computestring_Should_Return_1_when_1()
    {
        string result = _fizzBuzz.Computestring(1);
        result.Should().Be("1");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computestring_Should_Return_2_when_2()
    {
        string result = _fizzBuzz.Computestring(2);
        result.Should().Be("2");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computestring_Should_Return_Fizz_when_3()
    {
        string result = _fizzBuzz.Computestring(3);
        result.Should().Be("Fizz");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computestring_Should_Return_4_when_4()
    {
        string result = _fizzBuzz.Computestring(4);
        result.Should().Be("4");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computestring_Should_Return_Buzz_when_5()
    {
        string result = _fizzBuzz.Computestring(5);
        result.Should().Be("Buzz");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computestring_Should_Return_Fizz_when_6()
    {
        string result = _fizzBuzz.Computestring(6);
        result.Should().Be("Fizz");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computestring_Should_Return_Fizz_when_9()
    {
        string result = _fizzBuzz.Computestring(9);
        result.Should().Be("Fizz");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computestring_Should_Return_Buzz_when_10()
    {
        string result = _fizzBuzz.Computestring(10);
        result.Should().Be("Buzz");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computestring_Should_Return_FizzBuzz_when_15()
    {
        string result = _fizzBuzz.Computestring(15);
        result.Should().Be("FizzBuzz");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computeList_Should_Return_a_sequence_of_5_elements_when_5()
    {
        string[] result = _fizzBuzz.ComputeList(5);
        result.Length.Should().Be(5);
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computeList_Should_Return_a_sequence_of_5_FizzBuzz_elements_when_5()
    {
        string[] result = _fizzBuzz.ComputeList(5);
        result.Should().ContainInConsecutiveOrder("1", "2", "Fizz", "4", "Buzz");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_computeList_Should_Return_a_sequence_of_15_FizzBuzz_elements_when_15()
    {
        string[] result = _fizzBuzz.ComputeList(15);
        for (int i = 0; i < result.Length; ++i)
        {
            Assert.Equal(_fizzBuzz.Computestring(i + 1), result[i]);
        }
    }
}
