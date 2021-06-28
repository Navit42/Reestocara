using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reestocara
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }

    static class Constants
    {
        public static readonly int alturaMaxima = Screen.PrimaryScreen.Bounds.Height;
        public static readonly int larguraMaxima = Screen.PrimaryScreen.Bounds.Width;
    }
}
