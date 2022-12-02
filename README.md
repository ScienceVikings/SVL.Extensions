# SVL.Extensions

Extensions to simplify my life and have a little fun.

You can get just what you need by installing them piece meal, or get the whole thing with just the `SVL.Extensions` package.

## Strings

Easily convert things to and from JSON.

```csharp
var jsonString = myObject.ToJson();
var thatObject = jsonString.FromJson<MyObjectType>();
```

Easily convert a string in and out of Base64

```csharp
var base64str = "This is a normal string".ToBase64();
var myNormalString = base64Str.FromBase64();
```

## Random

Get random elements from an array, or a list

```csharp
var myList = new List<string>(){"1","2","3","4"};
var randomItem = myList.Random();
```

Have some fun and roll some dice! Stock sets included!

`d4, d6, d8, d10, d12, d20, d100`

```csharp
var myMove = 2.d6();
var advantageRoll = 2.d20();
var whateverRoll = 13.d(27); //13d27
```

