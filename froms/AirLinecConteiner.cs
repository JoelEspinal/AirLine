using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirLine.froms;

namespace AirLine.froms
{
    public partial class airLineConteiner : Form
    {
        private int childFormNumber = 0;

        public airLineConteiner()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void airPortToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void airLineConteiner_Load(object sender, EventArgs e)
        {

        }
        AirPortForm airlineForm = null;
        private void AirportMenuItem_Click(object sender, EventArgs e)
        {

            airlineForm = new AirPortForm();

            if (airlineForm != null)
            {
                airlineForm.MdiParent = this;
                airlineForm.Show();

            }
        }

        private void AircrafMenuItem_Click(object sender, EventArgs e)
        {
            AircraftForm aricracftForm = new AircraftForm();
            
            aricracftForm.MdiParent = this;
            aricracftForm.Show();
        }

        private void RoutetripMenuItem_Click(object sender, EventArgs e)
        {
            RouteForm routeForm = new RouteForm();
            routeForm.MdiParent = this;
            routeForm.Show();
        }

        private void FligthMenuItem_Click(object sender, EventArgs e)
        {
            FligthForm fligthForm = new FligthForm();
            fligthForm.MdiParent = this;
            fligthForm.Show();
        }

        private void pricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceForm priceForm = new PriceForm();
            priceForm.MdiParent = this;
            priceForm.Show();
        }
       
    }
}
