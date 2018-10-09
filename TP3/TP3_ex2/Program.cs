using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3_ex2
{
    static class Program
    {
        public static List<Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new List<Form>()
            {
                new PersonalInfos(),
                new Options(),
                new Modules()
            };
            Application.Run(Forms[0]);
        }
    }
}
