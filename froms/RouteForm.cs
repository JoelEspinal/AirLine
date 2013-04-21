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
    public partial class RouteForm : Form
    {
        public RouteForm()
        {
            InitializeComponent();
        }

        private void RouteForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'airportDataSet.airports' Puede moverla o quitarla según sea necesario.
            this.airportsTableAdapter.Fill(this.airportDataSet.airports);
            // TODO: esta línea de código carga datos en la tabla 'routeDataContext.routes' Puede moverla o quitarla según sea necesario.
            this.routesTableAdapter.Fill(this.routeDataContext.routes);

        }

        private void AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                this.airportsTableAdapter.Fill(this.airportDataSet.airports);
            }
            catch (Exception)
            { }
        }

        private void SaveRoute_Click(object sender, EventArgs e)
        {

            this.routesTableAdapter.Update(this.routeDataContext.routes);
        }

        private void CancelEdit_Click(object sender, EventArgs e)
        {
            this.routesBindingSource.CancelEdit();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
