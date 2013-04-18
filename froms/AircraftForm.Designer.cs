namespace AirLine.froms
{
    partial class AircraftForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AircraftForm));
            this.Navigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.MoveFirst = new System.Windows.Forms.ToolStripButton();
            this.MovePrevious = new System.Windows.Forms.ToolStripButton();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorPosition = new System.Windows.Forms.ToolStripTextBox();
            this.NavigatorCount = new System.Windows.Forms.ToolStripLabel();
            this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveNext = new System.Windows.Forms.ToolStripButton();
            this.MoveLast = new System.Windows.Forms.ToolStripButton();
            this.Sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.AddNew = new System.Windows.Forms.ToolStripButton();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aircraftDataContext = new AirLine.AircraftDataContext();
            this.aircraftDataContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aircraftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aircraftsTableAdapter = new AirLine.AircraftDataContextTableAdapters.aircraftsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Cancel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).BeginInit();
            this.Navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Navigator
            // 
            this.Navigator.AddNewItem = this.AddNew;
            this.Navigator.BindingSource = this.aircraftsBindingSource;
            this.Navigator.CountItem = this.NavigatorCount;
            this.Navigator.DeleteItem = this.Delete;
            this.Navigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Navigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveFirst,
            this.MovePrevious,
            this.Sep1,
            this.NavigatorPosition,
            this.NavigatorCount,
            this.Sep2,
            this.MoveNext,
            this.MoveLast,
            this.Sep3,
            this.AddNew,
            this.Delete,
            this.Save,
            this.Cancel});
            this.Navigator.Location = new System.Drawing.Point(0, 431);
            this.Navigator.MoveFirstItem = this.MoveFirst;
            this.Navigator.MoveLastItem = this.MoveLast;
            this.Navigator.MoveNextItem = this.MoveNext;
            this.Navigator.MovePreviousItem = this.MovePrevious;
            this.Navigator.Name = "Navigator";
            this.Navigator.PositionItem = this.NavigatorPosition;
            this.Navigator.Size = new System.Drawing.Size(907, 25);
            this.Navigator.TabIndex = 0;
            this.Navigator.Text = "Navigator";
            // 
            // MoveFirst
            // 
            this.MoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("MoveFirst.Image")));
            this.MoveFirst.Name = "bindingNavigatorMoveFirstItem";
            this.MoveFirst.RightToLeftAutoMirrorImage = true;
            this.MoveFirst.Size = new System.Drawing.Size(23, 22);
            this.MoveFirst.Text = "Move First";
            // 
            // MovePrevious
            // 
            this.MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("MovePrevious.Image")));
            this.MovePrevious.Name = "bindingNavigatorMovePreviousItem";
            this.MovePrevious.RightToLeftAutoMirrorImage = true;
            this.MovePrevious.Size = new System.Drawing.Size(23, 22);
            this.MovePrevious.Text = "Move Previous";
            // 
            // Sep1
            // 
            this.Sep1.Name = "bindingNavigatorSeparator";
            this.Sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // NavigatorPosition
            // 
            this.NavigatorPosition.AccessibleName = "Position";
            this.NavigatorPosition.AutoSize = false;
            this.NavigatorPosition.Name = "bindingNavigatorPositionItem";
            this.NavigatorPosition.Size = new System.Drawing.Size(50, 23);
            this.NavigatorPosition.Text = "0";
            this.NavigatorPosition.ToolTipText = "Current Position";
            // 
            // NavigatorCount
            // 
            this.NavigatorCount.Name = "bindingNavigatorCountItem";
            this.NavigatorCount.Size = new System.Drawing.Size(35, 22);
            this.NavigatorCount.Text = "of {0}";
            this.NavigatorCount.ToolTipText = "Total number of items";
            // 
            // Sep2
            // 
            this.Sep2.Name = "bindingNavigatorSeparator";
            this.Sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // MoveNext
            // 
            this.MoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveNext.Image = ((System.Drawing.Image)(resources.GetObject("MoveNext.Image")));
            this.MoveNext.Name = "bindingNavigatorMoveNextItem";
            this.MoveNext.RightToLeftAutoMirrorImage = true;
            this.MoveNext.Size = new System.Drawing.Size(23, 22);
            this.MoveNext.Text = "Move Next";
            // 
            // MoveLast
            // 
            this.MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveLast.Image = ((System.Drawing.Image)(resources.GetObject("MoveLast.Image")));
            this.MoveLast.Name = "bindingNavigatorMoveLastItem";
            this.MoveLast.RightToLeftAutoMirrorImage = true;
            this.MoveLast.Size = new System.Drawing.Size(23, 22);
            this.MoveLast.Text = "Move Last";
            // 
            // Sep3
            // 
            this.Sep3.Name = "bindingNavigatorSeparator";
            this.Sep3.Size = new System.Drawing.Size(6, 25);
            // 
            // AddNew
            // 
            this.AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNew.Image = ((System.Drawing.Image)(resources.GetObject("AddNew.Image")));
            this.AddNew.Name = "bindingNavigatorAddNewItem";
            this.AddNew.RightToLeftAutoMirrorImage = true;
            this.AddNew.Size = new System.Drawing.Size(23, 22);
            this.AddNew.Text = "Add New";
            // 
            // Delete
            // 
            this.Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "bindingNavigatorDeleteItem";
            this.Delete.RightToLeftAutoMirrorImage = true;
            this.Delete.Size = new System.Drawing.Size(23, 22);
            this.Delete.Text = "Delete";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.seatnumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aircraftsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 400);
            this.dataGridView1.TabIndex = 1;
            // 
            // aircraftDataContext
            // 
            this.aircraftDataContext.DataSetName = "AircraftDataContext";
            this.aircraftDataContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aircraftDataContextBindingSource
            // 
            this.aircraftDataContextBindingSource.DataSource = this.aircraftDataContext;
            this.aircraftDataContextBindingSource.Position = 0;
            // 
            // aircraftsBindingSource
            // 
            this.aircraftsBindingSource.DataMember = "aircrafts";
            this.aircraftsBindingSource.DataSource = this.aircraftDataContextBindingSource;
            // 
            // aircraftsTableAdapter
            // 
            this.aircraftsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // seatnumberDataGridViewTextBoxColumn
            // 
            this.seatnumberDataGridViewTextBoxColumn.DataPropertyName = "seat_number";
            this.seatnumberDataGridViewTextBoxColumn.HeaderText = "Seat Number";
            this.seatnumberDataGridViewTextBoxColumn.Name = "seatnumberDataGridViewTextBoxColumn";
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
            // Aircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 456);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Navigator);
            this.Name = "Aircraft";
            this.Text = "Aircraft";
            this.Load += new System.EventHandler(this.Aircraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Navigator)).EndInit();
            this.Navigator.ResumeLayout(false);
            this.Navigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator Navigator;
        private System.Windows.Forms.ToolStripButton AddNew;
        private System.Windows.Forms.ToolStripLabel NavigatorCount;
        private System.Windows.Forms.ToolStripButton Delete;
        private System.Windows.Forms.ToolStripButton MoveFirst;
        private System.Windows.Forms.ToolStripButton MovePrevious;
        private System.Windows.Forms.ToolStripSeparator Sep1;
        private System.Windows.Forms.ToolStripTextBox NavigatorPosition;
        private System.Windows.Forms.ToolStripSeparator Sep2;
        private System.Windows.Forms.ToolStripButton MoveNext;
        private System.Windows.Forms.ToolStripButton MoveLast;
        private System.Windows.Forms.ToolStripSeparator Sep3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource aircraftDataContextBindingSource;
        private AircraftDataContext aircraftDataContext;
        private System.Windows.Forms.BindingSource aircraftsBindingSource;
        private AircraftDataContextTableAdapters.aircraftsTableAdapter aircraftsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Cancel;
    }
}