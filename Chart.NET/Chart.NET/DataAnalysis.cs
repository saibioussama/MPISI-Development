using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chart.NET
{
    public class DataAnalysis
    {
        public List<double> Data { get; set; }

        public List<int> Effctif()
        {
            List<int> result = new List<int>();
            foreach (var x in Data)
                result.Add(Data.Where(p => p == x).Count());
            return result;
        }

        public List<int> Frequence()
        {
            List<int> result = new List<int>();
            foreach (var x in Data)
                result.Add(Data.Where(p => p == x).Count() / Data.Count);
            return result;
        }

    }
}
