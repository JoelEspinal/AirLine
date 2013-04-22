using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLine.froms
{
    public partial class AirPortForm : Form
    {
        /*   private static AirPortForm instance= null;
        
           public static AirPortForm Instance
           {            
               get 
               {
                   if (instance == null)
                   {
                       instance = new AirPortForm();
                   }
                   return instance;
               }
           }
    
           protected override CreateParams CreateParams
           {

               get
               {

                   CreateParams param = base.CreateParams;

                   param.ClassStyle = param.ClassStyle | 0x200;

                   return param;

               }

           }
       */
        public AirPortForm()
        {
            InitializeComponent();
                       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AirPortForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'airportDataSet.airports' Puede moverla o quitarla según sea necesario.
            this.airportsTableAdapter.Fill(this.airportDataSet.airports);
            // TODO: esta línea de código carga datos en la tabla 'airportDataSet.airports' Puede moverla o quitarla según sea necesario.
            this.airportsTableAdapter.Fill(this.airportDataSet.airports);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                this.airportsTableAdapter.Update(this.airportDataSet.airports);
            }
            catch (Exception)
            {
                 MessageBox.Show("The Airport could not be saved because the Name and Alias already exists.");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.airportsBindingSource.CancelEdit();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {

        }
    }
}
