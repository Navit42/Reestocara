using System;
using System.Windows.Forms;

namespace Reestocara
{
    internal static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

    }
    internal static class Constants
    {
        public static readonly int alturaMaxima = Screen.PrimaryScreen.Bounds.Height;
        public static readonly int larguraMaxima = Screen.PrimaryScreen.Bounds.Width;
    }

}