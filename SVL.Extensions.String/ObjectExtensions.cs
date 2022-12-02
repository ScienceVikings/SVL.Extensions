using System.Text.Json;

namespace SVL.Extensions.String;

public static class ObjectExtensions
{
    public static string ToJson(this object obj) => JsonSerializer.Serialize(obj);
}