using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart.NET
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Home());

            List<double> data = new List<double>()
            {
                1,2,3,5,9,1,2,3,6,9,8,5,2,0,1,2,3
            };
            DataAnalysis d = new DataAnalysis();
            d.Data = data;
            var  s = d.Effctif();
            var  ss = d.Frequence();

        }
    }
}
