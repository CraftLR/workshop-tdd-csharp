using FluentAssertions;

using Xunit;

namespace CraftLR.App.Tests;

public class AppTests
{
    [Fact]
    public void MakeAVerySeriousTest()
    {
        true.Should().BeTrue();
    }
}