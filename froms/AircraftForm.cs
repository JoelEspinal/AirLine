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
    public partial class AircraftForm : Form
    {
        public AircraftForm()
        {
            InitializeComponent();
        }

        private void Aircraft_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aircraftDataContext.aircrafts' Puede moverla o quitarla según sea necesario.
            this.aircraftsTableAdapter.Fill(this.aircraftDataContext.aircrafts);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.aircraftsTableAdapter.Update(this.aircraftDataContext.aircrafts);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.aircraftsBindingSource.CancelEdit();
        }
    }
}
