using System.Diagnostics;
using ProjectEuler.Problems;
using Serilog;
using ProjectEuler.Utilities;
using Logger = ProjectEuler.Utilities.Logger;
using Problem = ProjectEuler.Problems.Problem04;

using var _ = new Logger();

List<IProblem> problem_suite = new()
                               {
                                   new Problem01(),
                                   new Problem02(),
                                   new Problem03(),
                                   new Problem04(),
                                   new Problem05(),
                                   // new Problem06(),
                                   // new Problem07(),
                                   // new Problem08(),
                                   // new Problem09(),
                                   // new Problem10(),
                                   // new Problem11(),
                                   // new Problem12(),
                                   // new Problem13(),
                                   // new Problem14(),
                                   // new Problem15(),
                                   // new Problem16(),
                                   // new Problem17(),
                                   // new Problem18(),
                                   // new Problem19(),
                                   // new Problem20(),
                                   // new Problem21(),
                                   // new Problem22(),
                                   // new Problem23(),
                                   // new Problem24(),
                                   // new Problem25(),
                                   // new Problem26(),
                                   // new Problem27(),
                                   // new Problem28(),
                                   // new Problem29(),
                                   // new Problem30(),
                                   // new Problem31(),
                                   // new Problem32(),
                                   // new Problem33(),
                                   // new Problem34(),
                                   // new Problem35(),
                                   // new Problem36(),
                                   // new Problem37(),
                                   // new Problem38(),
                                   // new Problem39(),
                                   // new Problem40(),
                                   // new Problem41(),
                                   // new Problem42(),
                                   // new Problem43(),
                                   // new Problem44(),
                                   // new Problem45(),
                                   // new Problem46(),
                                   // new Problem47(),
                                   // new Problem48(),
                                   // new Problem49(),
                                   // new Problem50(),
                               };
List<double?> problem_solutions = new();

List<long> problem_times = new();


bool run_suite = true;

var sw = Stopwatch.StartNew();
if (!run_suite)
{
    IProblem problem = new Problem();
    Log.Information("Solution: {Solution}", problem.Solve());

    sw.Stop();
    Log.Information("Elapsed time for single problem: {Elapsed}", sw.ElapsedMilliseconds);
}
else
{
    foreach (var problem in problem_suite)
    {
        sw.Restart();
        problem_solutions.Add(problem.Solve());
        sw.Stop();
        problem_times.Add(sw.ElapsedMilliseconds);
    }


    for (var i = 0; i < problem_solutions.Count; i++)
    {
        var solution = problem_solutions[i];
        Log.Information("Solution for {Index}º Problem: {Solution} Time: {Time}ms", i + 1, solution, problem_times[i]);
    }
}