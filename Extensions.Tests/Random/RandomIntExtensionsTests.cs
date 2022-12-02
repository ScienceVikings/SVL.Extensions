using Shouldly;
using SVL.Extensions.Random;
using Xunit.Abstractions;

namespace Extensions.Tests.Random;

public class RandomIntExtensionsTests
{
    private readonly ITestOutputHelper _output;

    public RandomIntExtensionsTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void ShouldRollCorrectly()
    {
        1.d(6, new System.Random(14)).ShouldBe(1);
        1.d(6, new System.Random(1)).ShouldBe(2);
        1.d(6, new System.Random(9)).ShouldBe(3);
        1.d(6, new System.Random(13)).ShouldBe(4);
        1.d(6, new System.Random(0)).ShouldBe(5);
        1.d(6, new System.Random(6)).ShouldBe(6);
    }

    [Fact]
    public void ShouldRollMultipleCorrectly()
    {
        3.d(1).ShouldBe(3);
        1.d(3).ShouldBeGreaterThanOrEqualTo(1);
        1.d(3).ShouldBeLessThanOrEqualTo(3);
    }

    [Fact]
    public void ShouldRollMaxOnDie()
    {
        1.d4(new System.Random(2)).ShouldBe(4);
        1.d6(new System.Random(6)).ShouldBe(6);
        1.d8(new System.Random(8)).ShouldBe(8);
        1.d10(new System.Random(8)).ShouldBe(10);
        1.d12(new System.Random(10)).ShouldBe(12);
        1.d20(new System.Random(10)).ShouldBe(20);
        1.d100(new System.Random(12)).ShouldBe(100);
    }
}