using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autosmania
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        public static List<string> codigo, marca, modelo, year, motor, combustible;

        [STAThread]
        static void Main()
        {
            codigo = new List<string>();
            marca = new List<string>();
            modelo = new List<string>();
            year = new List<string>();
            motor = new List<string>();
            combustible = new List<string>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
