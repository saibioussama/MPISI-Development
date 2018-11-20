using DataAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp
{
  class Program
  {

    static void Main(string[] args)
    {
      
      double[] data = new double[1000000];
      Random rand = new Random();
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      for (int i = 0; i < data.Length; i++)
        data[i] = rand.NextDouble() + rand.Next(10000);
      //Console.WriteLine(data.Mean());
      Console.WriteLine(data.Median1());
      stopwatch.Stop();

      Console.WriteLine((double)stopwatch.ElapsedMilliseconds/1000 + " seconds.");
      Console.ReadKey();
    }
  }
}
