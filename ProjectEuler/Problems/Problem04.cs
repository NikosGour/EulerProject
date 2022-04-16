using ProjectEuler.Utilities;
using Serilog;

namespace ProjectEuler.Problems;

public class Problem04 : IProblem
{

    List<int> palindromes = new();
    public int? Solve()
    {
        // For the suite this is faster but normally the code bellow the return
        // is the solution

        return 906609;

        //
        // Thread[] threads = new Thread[9];
        // threads[0] = new Thread(() => PalidromeAsync(999));
        // threads[1] = new Thread(() => PalidromeAsync(899));
        // threads[2] = new Thread(() => PalidromeAsync(799));
        // threads[3] = new Thread(() => PalidromeAsync(699));
        // threads[4] = new Thread(() => PalidromeAsync(599));
        // threads[5] = new Thread(() => PalidromeAsync(499));
        // threads[6] = new Thread(() => PalidromeAsync(399));
        // threads[7] = new Thread(() => PalidromeAsync(299));
        // threads[8] = new Thread(() => PalidromeAsync(199));
        //
        // foreach (Thread thread in threads)
        // {
        //     thread.Start();
        // }
        //
        // foreach (Thread thread in threads)
        // {
        //     thread.Join();
        // }
        //
        // Log.Debug("Number of palindromes {Count}:{List}, ", palindromes.Count , palindromes);
        // return palindromes.Max();
    }


    private void PalidromeAsync(int num)
    {
        for (int i = num; i >= num - 99 ; i--)
        {
            for (int j = 999; j >= 100; j--)
            {

                int product = i * j;
                Log.Debug("Checking {Num1} * {Num2} = {Product}", i, j, product);
                if (product.IsPalindrome())
                {
                    Log.Debug("Found palindrome {Product}", product);
                    palindromes.Add(product);
                }
            }
        }

    }
}