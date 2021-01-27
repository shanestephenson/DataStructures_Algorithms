using System;
using System.Diagnostics;

namespace DataStructures_Algorithms
{
  class Program
  {
    static void Main(string[] args)
    {
      RunPermutations();
    }

    private static void RunIsUnique()
    {
      string str = "canada";

      var timer = new Stopwatch();
      timer.Start();

      var result = Arrays_Strings.IsUnique.PerformIsUnique(str);

      timer.Stop();

      TimeSpan timeTaken = timer.Elapsed;
      Console.WriteLine(String.Format("{0}: Is unique? {1}. Time taken: {2}", str, result, timeTaken));
    }

    private static void RunPermutations()
    {
      string str1 = "canada";
      string str2 = "cadana";

      var timer = new Stopwatch();
      timer.Start();

      var result = Arrays_Strings.Permutations.PerformPermutations(str1, str2);

      timer.Stop();

      TimeSpan timeTaken = timer.Elapsed;
      Console.WriteLine(String.Format("Time taken: {0}", timeTaken));
      Console.WriteLine(String.Format("{0} and {1} are permutations of one another? {2}", str1, str2, result));
    }
  }
}
