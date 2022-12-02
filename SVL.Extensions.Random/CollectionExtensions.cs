namespace SVL.Extensions.Random;

public static class CollectionExtensions
{
    public static T Random<T>(this T[] lst, System.Random? rng=null)
    {
        if (rng == null)
            rng = new System.Random();
        return lst[rng.Next(0, lst.Length)];
    }

    public static T Random<T>(this IEnumerable<T> lst, System.Random? rng = null)
    {
        if (rng == null)
            rng = new System.Random();

        return lst.ToArray().Random(rng);
    }
}