using DataAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
  class Program
  {
    enum custom_type
    {
      first,
      second,
      third
    }

    static void Main(string[] args)
    {
      var enum_list = new List<custom_type>() { custom_type.second, custom_type.third, custom_type.first, custom_type.second, custom_type.second, custom_type.third };
      var number_list = new double[] { 1,2,3,4,5,4,5};
      var number_list2 = new List<double>() { 1, 1, 1, 1 };


      //ObservationsByModality(4);
      //FrequencyByModality(4);
      number_list.Sort();


      Console.ReadKey();
    }
  }
}
