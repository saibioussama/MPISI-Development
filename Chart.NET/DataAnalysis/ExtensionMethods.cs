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
          if (data[i].Equals(item))
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
        var _data = new T[data.Length];
        _data.Sort();
        var dict = new Dictionary<T, int>();
        
        return 0;
      }
      catch
      {
        throw;
      }
    }

    /// <summary>
    /// it will throw an exception if data is not a list of number type
    /// </summary>
    /// <typeparam name="T">should be int, double, double, long or ,....</typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static double Mean<T>(this List<T> data) where T : struct
    {
      try
      {
        double sum = 0;
        foreach (dynamic item in data)
        {
          sum += item;
        }
        return sum / data.Count;
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    /// <summary>
    /// retourne la médiane des éléments d’une série statistique en passant par le tri.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static T Median1<T>(this T[] data)
    {
      try
      {
        var length = data.Length;
        var _data = new T[data.Length];
        for (int i = 0; i < data.Length; i++)
          _data[i] = data[i];

        //sort _data
        return _data[length / 2];
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    /// <summary>
    /// retourne la médiane des éléments d’une série statistique en passant par le calcul de la distribution des effectifs cumulés.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static T Median2<T>(this T[] data)
    {
      try
      {
        var index = 0;

        for (int i = 0; i < data.Length; i++)
        {
          if (data.CumulativeFrequencyByModality(data[i]) > 0.5)
          {
            index = i;
            break;
          }
        }
        double abs1 = Math.Sqrt(data.CumulativeFrequencyByModality(data[index - 1]) - 0.5);
        double abs2 = Math.Sqrt(data.CumulativeFrequencyByModality(data[index]) - 0.5);

        return abs1 < abs2 ? data[index - 1] : data[index];
      }
      catch
      {
        throw;
      }
    }

    /// <summary>
    /// Standard deviation => Sqrt(Var)
    /// </summary>
    /// <typeparam name="T">struct not class</typeparam>
    /// <param name="data">List of struct</param>
    /// <returns></returns>
    public static double StdDev<T>(this List<T> data) where T : struct
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

    /// <summary>
    /// Variance
    /// </summary>
    /// <typeparam name="T">struct not class</typeparam>
    /// <param name="data">List of struct </param>
    /// <returns></returns>
    public static double Var<T>(this List<T> data) where T : struct
    {
      try
      {
        double result = 0;
        double mean = data.Mean();
        long length = data.Count;
        foreach (dynamic item in data)
        {
          result += Math.Pow(item - mean, 2) / length;
        }
        return result;
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    /// <summary>
    /// Covariance
    /// </summary>
    /// <typeparam name="T">struct not class </typeparam>
    /// <param name="xdata">List of struct</param>
    /// <param name="ydata">List of struct</param>
    /// <returns></returns>
    public static double Covariance<T>(this List<T> xdata, List<T> ydata) where T : struct
    {
      try
      {
        double result = 0;

        if (xdata.Count != ydata.Count)
          throw new Exception("Xdata & Ydata does not have the same size !");

        long length = xdata.Count;

        double MeanX = xdata.Mean();
        double MeanY = ydata.Mean();

        for (int i = 0; i < length; i++)
        {
          result += ((dynamic)xdata[i] - MeanX) * ((dynamic)ydata[i] - MeanY);
        }

        return result / length;
      }
      catch (Exception ex)
      {
        throw;
      }
    }


    #region Custom methods 

    public static void Sort<T>(this T[] data)
    {
      var v = false;
      while (!v)
      {
        v = true;
        for (int i = 0; i < data.Length-1; i++)
        {
          if ((dynamic)data[i] > data[i + 1])
          {
            var aux = data[i];
            data[i] = data[i + 1];
            data[i + 1] = aux;
            v = false;
          }
        }
      }
    }

    #endregion

  }
}
