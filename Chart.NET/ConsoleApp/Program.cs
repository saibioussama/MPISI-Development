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
      var enum_list = new List<custom_type>() {  custom_type.second, custom_type.third , custom_type.first, custom_type.second, custom_type.second , custom_type.third };
      var number_list = new List<double>() { 0.1, 0.1, 0.1, 0.1, 0.1, 5, 6, 7, 8, 9 };
      
      var number_median = number_list.Median();
      var number_average = number_list.Average();
      var number_frequence = number_list.Frequence();
      var number_Effectif = number_list.Effectif();

      var enum_median = enum_list.Median();
      //var enum_average = enum_list.Average();
      var enum_frequence = enum_list.Frequence();
      var enum_Effectif = enum_list.Effectif();

      Console.ReadKey();
    }
  }
}
