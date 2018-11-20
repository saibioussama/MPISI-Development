using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAnalysis
{
  public static class ExtensionMethods
  {

    /// <summary>
    /// calculer l’effectif de chaque modalité d’une série d’observations d’une variable quantitative discrète
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    public static int ObservationsByModality<T>(this T[] data, T item)
    {
      try
      {
        var result = 0;
        for (int i = 0; i < data.Length; i++)
        {
          if ((dynamic)data[i] == item)
            result++;
        }
        return result;
      }
      catch
      {
        throw;
      }
    }

    /// <summary>
    ///  calculer la fréquence de chaque modalité d’une série d’observations.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    public static double FrequencyByModality<T>(this T[] data, T item)
    {
      try
      {
        return (double)data.ObservationsByModality(item) / data.Length;
      }
      catch
      {
        throw;
      }
    }

    /// <summary>
    /// calculer la distribution de la fréquence cumulée d’une série statistique.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <param name="item"></param>
    /// <returns></returns>
    public static double CumulativeFrequencyByModality<T>(this T[] data, T item)
    {
      try
      {
        double result = 0;
        bool exist = false;
        var dict = new Dictionary<T, double>();
        for (int i = 0; i < data.Length; i++)
        {
          try
          {
            dict.Add(data[i], (double)ObservationsByModality(data, data[i]) / data.Length);
          }
          catch { }
        }
        dict.OrderBy(p => p.Key);
        foreach (var x in dict)
        {
          result += x.Value;
          if ((dynamic)x.Key == item)
          {
            exist = true;
            break;
          }
        }
        if (exist)
          return result;
        throw new Exception($"{item} does not belong to the array.");
      }
      catch
      {
        throw;
      }
    }

    /// <summary>
    /// calcule et retourne la moyenne des éléments d’une série statistique.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static double Mean<T>(this T[] data)
    {
      try
      {
        double result = 0;
        for (int i = 0; i < data.Length; i++)
          result += (dynamic)data[i];
        return result / data.Length;
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    /// <summary>
    /// calcule et retourne la médiane des éléments d’une série statistique en passant par le tri.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static T Median1<T>(this T[] data)
    {
      try
      {
        var _data = (T[])data.Clone();
        _data.Sort();
        return _data[_data.Length / 2];
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    /// <summary>
    ///  calcule et retourne la médiane des éléments d’une série statistique en passant par le calcul de la distribution des effectifs cumulés.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static T Median2<T>(this T[] data)
    {
      try
      {
        var dict = new Dictionary<T, double>();
        for (int i = 0; i < data.Length; i++)
        {
          try
          {
            dict.Add(data[i], CumulativeFrequencyByModality(data, (dynamic)data[i]));
          }
          catch (Exception ex) { }
        }
        int index = 0;
        for (int i = 0; i < dict.Count; i++)
        {
          if ((dynamic)dict.ElementAt(i).Value > 0.5)
          {
            index = i;
            break;
          }
        }
        if (Math.Sqrt((dynamic)dict.ElementAt(index).Value - 0.5) > Math.Sqrt((dynamic)dict.ElementAt(index - 1).Value - 0.5))
          return dict.ElementAt(index - 1).Key;
        return dict.ElementAt(index).Key;
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    /// <summary>
    /// calcule et retourne la variance d’une série statistique.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static double Var<T>(this T[] data)
    {
      try
      {
        double result = 0;
        var mean = data.Mean();
        int length = data.Length;
        for (int i = 0; i < length; i++)
          result += Math.Pow((dynamic)data[i] - mean, 2) / (length-1);
        return result;
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    /// <summary>
    ///  calcule et retourne l’écart type d’une série statistique.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static double StdDev<T>(this T[] data)
    {
      try
      {
        return Math.Sqrt(data.Var());
      }
      catch (Exception ex)
      {
        throw;
      }
    }


    #region Custom methods 

    public static void Sort<T>(this T[] data)
    {
      for (int i = 0; i < data.Length - 1; i++)
      {
        for (int j = i + 1; j > 0; j--)
        {
          if ((dynamic)data[j - 1] > data[j])
          {
            T temp = data[j - 1];
            data[j - 1] = data[j];
            data[j] = temp;
          }
        }
      }
    }

    #endregion

  }
}
