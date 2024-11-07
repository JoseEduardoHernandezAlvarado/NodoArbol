using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
// Segunda prueba
using System.Windows.Forms;
using System.Threading;

namespace NodoArbol
{
       internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

