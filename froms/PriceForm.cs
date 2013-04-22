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
    public partial class PriceForm : Form
    {
        public PriceForm()
        {
            InitializeComponent();
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'fligthDataContext.flights' Puede moverla o quitarla según sea necesario.
            this.flightsTableAdapter.Fill(this.fligthDataContext.flights);
            // TODO: esta línea de código carga datos en la tabla 'pricesDataContext.prices' Puede moverla o quitarla según sea necesario.
            this.pricesTableAdapter.Fill(this.pricesDataContext.prices);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            pricesTableAdapter.Update(pricesDataContext.prices);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            pricesBindingSource.CancelEdit();
        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            this.flightsTableAdapter.Fill(this.fligthDataContext.flights);
        }
    }
}
