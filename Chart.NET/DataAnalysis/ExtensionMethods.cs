using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnalysis
{
  public static class ExtensionMethods
  {

    /// <summary>
    /// T could be of any type , i'm not sure :)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static Dictionary<T, int> Effectif<T>(this List<T> data)
    {
      try
      {
        var result = new Dictionary<T, int>();
        foreach (T item in data.ToList())
        {
          try
          {
            result.Add(item, data.FindAll(x => x.Equals(item)).Count);
          }
          catch { }
        }
        return result;
      }
      catch (Exception ex)
      {
        throw new TypeAccessException();
      }
    }

    /// <summary>
    /// T could be of any type , i'm not sure :)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static Dictionary<T, float> Frequence<T>(this List<T> data)
    {
      try
      {
        var result = new Dictionary<T, float>();
        foreach (T item in data.ToList())
        {
          try
          {
            result.Add(item, (float)data.FindAll(x => x.Equals(item)).Count / data.Count);
          }
          catch { }
        }
        return result;
      }
      catch (Exception ex)
      {
        throw new TypeAccessException();
      }
    }

    /// <summary>
    /// T could be of any type , i'm not sure :)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static T Median<T>(this List<T> data)
    {
      try
      {
        var length = data.Count;
        data.Sort();
        return data[length / 2];
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    /// <summary>
    /// it will throw an exception if data is not of number type
    /// </summary>
    /// <typeparam name="T">should be int, float, double, long or ,....</typeparam>
    /// <param name="data"></param>
    /// <returns></returns>
    public static float Average<T>(this List<T> data)
    {
      try
      {
        float sum = 0;
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

  }
}
