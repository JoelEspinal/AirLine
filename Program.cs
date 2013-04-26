using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirLine.froms;
using System.Data;

namespace AirLine
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new airLineConteiner());
                //this.airportsTableAdapter.Fill(this.airportDataSet.airports);
           // }   
            //catch (NoNullAllowedException)
            //{

              //  MessageBox.Show("have to save before adding another");
            //}   
        }
    }
}
