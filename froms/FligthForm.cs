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

        DateTimePicker datePicker;

        private void FligthForm_Load(object sender, EventArgs e)
        {
          this.aircraftsTableAdapter.Fill(this.aircraftDataContext.aircrafts);
            this.routesTableAdapter.Fill(this.routeDataContext.routes);
              this.flightsTableAdapter.Fill(this.fligthDataContext.flights);

            
        }
        public void datePicker_ValueChangedged(Object sender, EventArgs e)
        {
            dataGridView1.CurrentCell.Value = datePicker.Text;
        }
        private void AddNew_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aircraftDataContext.aircrafts' Puede moverla o quitarla según sea necesario.
            this.aircraftsTableAdapter.Fill(this.aircraftDataContext.aircrafts);
            // TODO: esta línea de código carga datos en la tabla 'routeDataContext.routes' Puede moverla o quitarla según sea necesario.
            this.routesTableAdapter.Fill(this.routeDataContext.routes);
        }

        private void InitializeDateTimePicker()
        {
            datePicker = new DateTimePicker();
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            datePicker.Visible = false;
            datePicker.ShowUpDown = true;
            datePicker.Width = 116;
            dataGridView1.Controls.Add(datePicker);
            datePicker.ValueChanged += this.datePicker_ValueChangedged;
            dataGridView1.CellBeginEdit += this.dataGridView1_CellBeginEdit;
            dataGridView1.CellEndEdit += this.dataGridView1_CellEndEdit;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.flightsBindingSource.CancelEdit();
            if (datePicker != null)
            {
                datePicker.Visible = false;
            }
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try 
            {
                //fligthDataContext.flights.departureColumn.DateTimeMode.CompareTo.(DateTimePicker

            if (datePicker != null) datePicker.Visible = false;
                this.flightsTableAdapter.Update(fligthDataContext.flights);
            }
           catch(Exception)
            {
                MessageBox.Show("The Fligth could not be saved because the combination of Fligth Number and Departure Time already exists.");
            }
            
        }
        

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if(datePicker==null) InitializeDateTimePicker();
            //try
            //{            
            if (dataGridView1.Focused && (dataGridView1.CurrentCell.ColumnIndex == 2 || dataGridView1.CurrentCell.ColumnIndex == 3))
                {             
                    datePicker.Location = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    datePicker.Visible = true;
                    if (dataGridView1.CurrentCell.Value != DBNull.Value)
                    {
                        datePicker.Value = (DateTime)dataGridView1.CurrentCell.Value;
                    }
                    else
                    {
                        datePicker.Value = DateTime.Today;
                    }
                }
                else
                {
                    datePicker.Visible = false;
                }
            //}
            //catch (Exception ex)
            //{
                //MessageBox.Show("Malformet date format: "+ex.Message);
            //}
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dataGridView1.Focused && (dataGridView1.CurrentCell.ColumnIndex == 2))
                {
                    dataGridView1.CurrentCell.Value = datePicker.Value.Date;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hay una excepcion");
            }
        }
     
    }
}
