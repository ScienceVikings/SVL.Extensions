using Shouldly;
using SVL.Extensions.String;
using Xunit.Abstractions;

namespace Extensions.Tests.String;

public class StringExtensionsTests
{
    private class MyTestClass
    {
        public int MyInt { get; set; }
        public string? MyString { get; set; }
    }
    
    private readonly ITestOutputHelper _output;

    public StringExtensionsTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public void ShouldConvertJson()
    {
        var data = new MyTestClass()
        {
            MyInt = 123,
            MyString = "This is a test"
        };

        var jsonString = data.ToJson();
        var fromJson = jsonString.FromJson<MyTestClass>();
        
        fromJson?.MyInt.ShouldBe(data.MyInt);
        fromJson?.MyString.ShouldBe(data.MyString);
    }
}