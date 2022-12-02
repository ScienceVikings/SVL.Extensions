namespace SVL.Extensions.Random;

public static class IntExtensions
{
    public static int d(this int die, int sides, System.Random? rng = null)
    {
        if (rng == null)
            rng = new System.Random();

        var sum = 0;

        for (var i = 0; i < die; i++)
            sum += rng.Next(1, sides + 1);

        return sum;
    }

    public static int d4(this int die, System.Random? rng = null) => die.d(4, rng);
    public static int d6(this int die, System.Random? rng = null) => die.d(6, rng);
    public static int d8(this int die, System.Random? rng = null) => die.d(8, rng);
    public static int d10(this int die, System.Random? rng = null) => die.d(10, rng);
    public static int d12(this int die, System.Random? rng = null) => die.d(12, rng);
    public static int d20(this int die, System.Random? rng = null) => die.d(20, rng);
    public static int d100(this int die, System.Random? rng = null) => die.d(100, rng);
} 