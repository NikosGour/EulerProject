using Serilog;

namespace ProjectEuler.Utilities;

public static class Extensions
{
    public static bool IsPalindrome(this int n)
    {
        var s = n.ToString();

        Log.Debug("{Num} with {NumLength} digits", n, s.Length);


        string firstHalf, secondHalf;

        if (s.Length % 2 == 0)
        {
            firstHalf  = s[..(s.Length / 2)];
            secondHalf = s[(s.Length   / 2)..];
        }
        else
        {
            firstHalf  = s[..(s.Length / 2 + 1)];
            secondHalf = s[(s.Length / 2)..];
        }

        Log.Debug("First half: {FirstHalf} Second half: {SecondHalf}", firstHalf, secondHalf);

        secondHalf = string.Join("", secondHalf.Reverse().ToArray());

        Log.Debug("First half: {FirstHalf} Second half reversed: {SecondHalf}", firstHalf, secondHalf);

        return firstHalf == secondHalf;
    }
}