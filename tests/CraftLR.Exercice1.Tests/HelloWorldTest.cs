using FluentAssertions;

using Xunit;

namespace CraftLR.Exercice1;


public class HelloWorldTest
{

    [Fact]
    public void Test_hello_with_empty_string_is_compared_by_value()
    {
        HelloWorld.Hello("").Should().Be("Hello, World!");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_hello_with_no_name_should_return_helloworld()
    {
        HelloWorld.Hello(null).Should().Be("Hello, World!");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_hello_should_return_hello_alice_when_alice()
    {
        HelloWorld.Hello("Alice").Should().Be("Hello, Alice!");
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Test_hello_should_return_hello_bob_when_bob()
    {
        HelloWorld.Hello("Bob").Should().Be("Hello, Bob!");
    }
}
