using System.Text;
using System.Text.Json;

namespace SVL.Extensions.String;

public static class StringExtensions
{
    public static T? FromJson<T>(this string json) => JsonSerializer.Deserialize<T>(json);
    public static string ToBase64(this string str) => Convert.ToBase64String(Encoding.Default.GetBytes(str));
    public static string FromBase64(this string str) => Encoding.Default.GetString(Convert.FromBase64String(str));
}