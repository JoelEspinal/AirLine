namespace AirLine.froms
{
    partial class AirPortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirPortForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new AirLine.AirportDataSet();
            this.airportsTableAdapter = new AirLine.AirportDataSetTableAdapters.airportsTableAdapter();
            this.Navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.AddNew = new System.Windows.Forms.ToolStripButton();
            this.Total = new System.Windows.Forms.ToolStripLabel();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.MoveFirst = new System.Windows.Forms.ToolStripButton();
            this.MovePrevious = new System.Windows.Forms.ToolStripButton();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.CurrentPosition = new System.Windows.Forms.ToolStripTextBox();
            this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveNext = new System.Windows.Forms.ToolStripButton();
            this.MoveLast = new System.Windows.Forms.ToolStripButton();
            this.Sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Cancel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.aliasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.airportsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(874, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            this.aliasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aliasDataGridViewTextBoxColumn.DataPropertyName = "alias";
            this.aliasDataGridViewTextBoxColumn.HeaderText = "alias";
            this.aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            // 
            // airportsBindingSource
            // 
            this.airportsBindingSource.DataMember = "airports";
            this.airportsBindingSource.DataSource = this.airportDataSet;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // Navigator
            // 
            this.Navigator.AddNewItem = this.AddNew;
            this.Navigator.BindingSource = this.airportsBindingSource;
            this.Navigator.CountItem = this.Total;
            this.Navigator.DeleteItem = this.Delete;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveFirst,
            this.MovePrevious,
            this.Sep1,
            this.CurrentPosition,
            this.Total,
            this.Sep2,
            this.MoveNext,
            this.MoveLast,
            this.Sep3,
            this.AddNew,
            this.Delete,
            this.Save,
            this.Cancel});
            this.Navigator.Location = new System.Drawing.Point(0, 447);
            this.Navigator.MoveFirstItem = this.MoveFirst;
            this.Navigator.MoveLastItem = this.MoveLast;
            this.Navigator.MoveNextItem = this.MoveNext;
            this.Navigator.MovePreviousItem = this.MovePrevious;
            this.Navigator.Name = "Navigator";
            this.Navigator.PositionItem = this.CurrentPosition;
            this.Navigator.Size = new System.Drawing.Size(874, 25);
            this.Navigator.TabIndex = 1;
            this.Navigator.Text = "Navigator";
            // 
            // AddNew
            // 
            this.AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNew.Image = ((System.Drawing.Image)(resources.GetObject("AddNew.Image")));
            this.AddNew.Name = "AddNew";
            this.AddNew.RightToLeftAutoMirrorImage = true;
            this.AddNew.Size = new System.Drawing.Size(23, 22);
            this.AddNew.Text = "Add New";
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // Total
            // 
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(35, 22);
            this.Total.Text = "of {0}";
            this.Total.ToolTipText = "Total Airports";
            // 
            // Delete
            // 
            this.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.RightToLeftAutoMirrorImage = true;
            this.Delete.Size = new System.Drawing.Size(23, 22);
            this.Delete.Text = "Delete";
            // 
            // MoveFirst
            // 
            this.MoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("MoveFirst.Image")));
            this.MoveFirst.Name = "MoveFirst";
            this.MoveFirst.RightToLeftAutoMirrorImage = true;
            this.MoveFirst.Size = new System.Drawing.Size(23, 22);
            this.MoveFirst.Text = "Move First";
            // 
            // MovePrevious
            // 
            this.MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("MovePrevious.Image")));
            this.MovePrevious.Name = "MovePrevious";
            this.MovePrevious.RightToLeftAutoMirrorImage = true;
            this.MovePrevious.Size = new System.Drawing.Size(23, 22);
            this.MovePrevious.Text = "Move Previous";
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // CurrentPosition
            // 
            this.CurrentPosition.AccessibleName = "Position";
            this.CurrentPosition.AutoSize = false;
            this.CurrentPosition.Name = "CurrentPosition";
            this.CurrentPosition.Size = new System.Drawing.Size(50, 23);
            this.CurrentPosition.Text = "0";
            this.CurrentPosition.ToolTipText = "Current Airport";
            // 
            // Sep2
            // 
            this.Sep2.Name = "Sep2";
            this.Sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // MoveNext
            // 
            this.MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveNext.Image = ((System.Drawing.Image)(resources.GetObject("MoveNext.Image")));
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.RightToLeftAutoMirrorImage = true;
            this.MoveNext.Size = new System.Drawing.Size(23, 22);
            this.MoveNext.Text = "Move Next";
            // 
            // MoveLast
            // 
            this.MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveLast.Image = ((System.Drawing.Image)(resources.GetObject("MoveLast.Image")));
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.RightToLeftAutoMirrorImage = true;
            this.MoveLast.Size = new System.Drawing.Size(23, 22);
            this.MoveLast.Text = "Move Last";
            this.MoveLast.ToolTipText = "Move Last";
            // 
            // Sep3
            // 
            this.Sep3.Name = "Sep3";
            this.Sep3.Size = new System.Drawing.Size(6, 25);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Cancel.Image")));
            this.Cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(23, 22);
            this.Cancel.Text = "Cancel";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AirPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 472);
            this.Controls.Add(this.Navigator);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(950, 580);
            this.MinimumSize = new System.Drawing.Size(890, 510);
            this.Name = "AirPortForm";
            this.Text = "Air Port";
            this.Load += new System.EventHandler(this.AirPortForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private AirportDataSetTableAdapters.airportsTableAdapter airportsTableAdapter;
        private System.Windows.Forms.BindingNavigator Navigator;
        private System.Windows.Forms.ToolStripButton AddNew;
        private System.Windows.Forms.ToolStripLabel Total;
        private System.Windows.Forms.ToolStripButton Delete;
        private System.Windows.Forms.ToolStripButton MoveFirst;
        private System.Windows.Forms.ToolStripButton MovePrevious;
        private System.Windows.Forms.ToolStripSeparator Sep1;
        private System.Windows.Forms.ToolStripTextBox CurrentPosition;
        private System.Windows.Forms.ToolStripSeparator Sep2;
        private System.Windows.Forms.ToolStripButton MoveNext;
        private System.Windows.Forms.ToolStripButton MoveLast;
        private System.Windows.Forms.ToolStripSeparator Sep3;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;

    }
}