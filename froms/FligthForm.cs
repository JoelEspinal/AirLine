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
    public partial class FligthForm : Form
    {
        public FligthForm()
        {
            InitializeComponent();
        }

        private void FligthForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aircraftDataContext.aircrafts' Puede moverla o quitarla según sea necesario.
            this.aircraftsTableAdapter.Fill(this.aircraftDataContext.aircrafts);
            // TODO: esta línea de código carga datos en la tabla 'routeDataContext.routes' Puede moverla o quitarla según sea necesario.
            this.routesTableAdapter.Fill(this.routeDataContext.routes);
            // TODO: esta línea de código carga datos en la tabla 'fligthDataContext.flights' Puede moverla o quitarla según sea necesario.
            this.flightsTableAdapter.Fill(this.fligthDataContext.flights);

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aircraftDataContext.aircrafts' Puede moverla o quitarla según sea necesario.
            this.aircraftsTableAdapter.Fill(this.aircraftDataContext.aircrafts);
            // TODO: esta línea de código carga datos en la tabla 'routeDataContext.routes' Puede moverla o quitarla según sea necesario.
            this.routesTableAdapter.Fill(this.routeDataContext.routes);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.flightsBindingSource.CancelEdit();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.flightsTableAdapter.Update(fligthDataContext.flights);
        }
    }
}
