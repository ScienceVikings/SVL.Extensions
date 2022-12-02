using Shouldly;
using SVL.Extensions.Random;
using Xunit.Abstractions;

namespace Extensions.Tests.Random;

public class RandomCollectionExtensionsTests
{
    private readonly ITestOutputHelper _output;

    public RandomCollectionExtensionsTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void ShouldGetRandomElements()
    {
        var arrLst = new string[] { "test arrays" };
        var arrVal = arrLst.Random();

        var enumLst = new List<string>() { "test enumerables" };
        var enumVal = enumLst.Random();
        
        arrVal.ShouldBe("test arrays");
        enumVal.ShouldBe("test enumerables");

        var ints = new int[100];
        for (var i = 0; i < 100; i++)
        {
            ints[i] = i;
        }

        var rng = ints.Random();
        rng.ShouldBeGreaterThanOrEqualTo(0);
        rng.ShouldBeLessThanOrEqualTo(100);
    }
}