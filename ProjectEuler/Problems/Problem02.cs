using ProjectEuler.Utilities;
using Serilog;

namespace ProjectEuler.Problems;

public class Problem02 : IProblem
{
    public int? Solve()
    {
        int? rv = 0;

        int x = 1;
        int y = 2;

        while (true)
        {
            Log.Debug("First num:{FNum} Second num:{SNum}", x, y);
            int sum = x + y;
            if (sum > 4000000)
            {
                Log.Debug("Sum of {Sum} is greater than 4.000.000", sum);
                break;
            }
            Log.Debug("Sum:{Sum}", sum);

            x = y;
            y = sum;

            Log.Debug("New {{first num:{FNum} Second num:{SNum}}}", x, y);

            if (sum % 2 == 0)
            {
                Log.Debug("Adding {Num} to sum", sum);
                rv += sum;

            }
        }


        return rv + 2;
    }
}