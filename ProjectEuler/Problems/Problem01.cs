using ProjectEuler.Utilities;
using Serilog;

namespace ProjectEuler.Problems;


public class Problem01 : IProblem
{
    public int? Solve()
    {
        int? rv = 0;

        for (int i = 0; i < 1000; i++)
        {
            Log.Debug("Current number is {Number}", i);
            if (i % 3 == 0 || i % 5 == 0)
            {
                Log.Debug("Adding {Number} to sum", i);
                rv += i;
            }
        }
        
        return rv;
    }
}

