using Serilog;
using ProjectEuler.Problems;
using ProjectEuler.Utilities;
using Logger = ProjectEuler.Utilities.Logger;
using Problem = ProjectEuler.Problems.Problem02;
using var _ = new Logger();

bool run_suite = false;

if (!run_suite)
{
    IProblem problem = new Problem();



    Log.Information("Solution: {Solution}",problem.Solve());
}


