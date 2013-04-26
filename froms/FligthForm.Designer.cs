namespace AirLine.froms
{
    partial class FligthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FligthForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.AddNew = new System.Windows.Forms.ToolStripButton();
            this.CountItem = new System.Windows.Forms.ToolStripLabel();
            this.Delete = new System.Windows.Forms.ToolStripButton();
            this.MoveFirst = new System.Windows.Forms.ToolStripButton();
            this.MovePrevious = new System.Windows.Forms.ToolStripButton();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorPosition = new System.Windows.Forms.ToolStripTextBox();
            this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveNext = new System.Windows.Forms.ToolStripButton();
            this.MoveLast = new System.Windows.Forms.ToolStripButton();
            this.Sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Cancel = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeDataContext = new AirLine.RouteDataContext();
            this.aircraftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aircraftDataContext = new AirLine.AircraftDataContext();
            this.routesTableAdapter = new AirLine.RouteDataContextTableAdapters.routesTableAdapter();
            this.aircraftsTableAdapter = new AirLine.AircraftDataContextTableAdapters.aircraftsTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.aircraftidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.regularseatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fristclassseatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalregularseatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalfristclassseatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fligthDataContext = new AirLine.FligthDataContext();
            this.flightsTableAdapter = new AirLine.FligthDataContextTableAdapters.flightsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fligthDataContext)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.AddNew;
            this.bindingNavigator.BindingSource = this.flightsBindingSource;
            this.bindingNavigator.CountItem = this.CountItem;
            this.bindingNavigator.DeleteItem = this.Delete;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveFirst,
            this.MovePrevious,
            this.Sep1,
            this.NavigatorPosition,
            this.CountItem,
            this.Sep2,
            this.MoveNext,
            this.MoveLast,
            this.Sep3,
            this.AddNew,
            this.Delete,
            this.Save,
            this.Cancel});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 395);
            this.bindingNavigator.MoveFirstItem = this.MoveFirst;
            this.bindingNavigator.MoveLastItem = this.MoveLast;
            this.bindingNavigator.MoveNextItem = this.MoveNext;
            this.bindingNavigator.MovePreviousItem = this.MovePrevious;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.NavigatorPosition;
            this.bindingNavigator.Size = new System.Drawing.Size(802, 25);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator";
            // 
            // AddNew
            // 
            this.AddNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddNew.Image = ((System.Drawing.Image)(resources.GetObject("AddNew.Image")));
            this.AddNew.Name = "AddNew";
            this.AddNew.RightToLeftAutoMirrorImage = true;
            this.AddNew.Size = new System.Drawing.Size(23, 22);
            this.AddNew.Text = "Add new";
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // CountItem
            // 
            this.CountItem.Name = "CountItem";
            this.CountItem.Size = new System.Drawing.Size(35, 22);
            this.CountItem.Text = "of {0}";
            this.CountItem.ToolTipText = "Total number of items";
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
            // NavigatorPosition
            // 
            this.NavigatorPosition.AccessibleName = "Position";
            this.NavigatorPosition.AutoSize = false;
            this.NavigatorPosition.Name = "NavigatorPosition";
            this.NavigatorPosition.Size = new System.Drawing.Size(50, 23);
            this.NavigatorPosition.Text = "0";
            this.NavigatorPosition.ToolTipText = "Current position";
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.flight_number,
            this.departureDataGridViewTextBoxColumn,
            this.arrivalDataGridViewTextBoxColumn,
            this.routeidDataGridViewTextBoxColumn,
            this.aircraftidDataGridViewTextBoxColumn,
            this.regularseatsDataGridViewTextBoxColumn,
            this.fristclassseatsDataGridViewTextBoxColumn,
            this.totalregularseatsDataGridViewTextBoxColumn,
            this.totalfristclassseatsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 391);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // routesBindingSource
            // 
            this.routesBindingSource.DataMember = "routes";
            this.routesBindingSource.DataSource = this.routeDataContext;
            // 
            // routeDataContext
            // 
            this.routeDataContext.DataSetName = "RouteDataContext";
            this.routeDataContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aircraftsBindingSource
            // 
            this.aircraftsBindingSource.DataMember = "aircrafts";
            this.aircraftsBindingSource.DataSource = this.aircraftDataContext;
            // 
            // aircraftDataContext
            // 
            this.aircraftDataContext.DataSetName = "AircraftDataContext";
            this.aircraftDataContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // aircraftsTableAdapter
            // 
            this.aircraftsTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // flight_number
            // 
            this.flight_number.DataPropertyName = "flight_number";
            this.flight_number.HeaderText = "Flight Number";
            this.flight_number.Name = "flight_number";
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "departure";
            dataGridViewCellStyle1.NullValue = null;
            this.departureDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.departureDataGridViewTextBoxColumn.HeaderText = "Departure Time";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            this.departureDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // arrivalDataGridViewTextBoxColumn
            // 
            this.arrivalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalDataGridViewTextBoxColumn.DataPropertyName = "arrival";
            this.arrivalDataGridViewTextBoxColumn.HeaderText = "Arrival Time";
            this.arrivalDataGridViewTextBoxColumn.Name = "arrivalDataGridViewTextBoxColumn";
            // 
            // routeidDataGridViewTextBoxColumn
            // 
            this.routeidDataGridViewTextBoxColumn.DataPropertyName = "route_id";
            this.routeidDataGridViewTextBoxColumn.DataSource = this.routesBindingSource;
            this.routeidDataGridViewTextBoxColumn.DisplayMember = "alias";
            this.routeidDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeidDataGridViewTextBoxColumn.Name = "routeidDataGridViewTextBoxColumn";
            this.routeidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.routeidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.routeidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // aircraftidDataGridViewTextBoxColumn
            // 
            this.aircraftidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aircraftidDataGridViewTextBoxColumn.DataPropertyName = "aircraft_id";
            this.aircraftidDataGridViewTextBoxColumn.DataSource = this.aircraftsBindingSource;
            this.aircraftidDataGridViewTextBoxColumn.DisplayMember = "code";
            this.aircraftidDataGridViewTextBoxColumn.HeaderText = "Aircraft";
            this.aircraftidDataGridViewTextBoxColumn.Name = "aircraftidDataGridViewTextBoxColumn";
            this.aircraftidDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aircraftidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aircraftidDataGridViewTextBoxColumn.ValueMember = "id";
            // 
            // regularseatsDataGridViewTextBoxColumn
            // 
            this.regularseatsDataGridViewTextBoxColumn.DataPropertyName = "total_regular_seats";
            this.regularseatsDataGridViewTextBoxColumn.HeaderText = "Regular Seats";
            this.regularseatsDataGridViewTextBoxColumn.Name = "regularseatsDataGridViewTextBoxColumn";
            this.regularseatsDataGridViewTextBoxColumn.Visible = false;
            this.regularseatsDataGridViewTextBoxColumn.Width = 90;
            // 
            // fristclassseatsDataGridViewTextBoxColumn
            // 
            this.fristclassseatsDataGridViewTextBoxColumn.DataPropertyName = "total_frist_class_seats";
            this.fristclassseatsDataGridViewTextBoxColumn.HeaderText = "Frist Class Seats";
            this.fristclassseatsDataGridViewTextBoxColumn.Name = "fristclassseatsDataGridViewTextBoxColumn";
            this.fristclassseatsDataGridViewTextBoxColumn.Visible = false;
            this.fristclassseatsDataGridViewTextBoxColumn.Width = 90;
            // 
            // totalregularseatsDataGridViewTextBoxColumn
            // 
            this.totalregularseatsDataGridViewTextBoxColumn.DataPropertyName = "total_regular_seats";
            this.totalregularseatsDataGridViewTextBoxColumn.HeaderText = "Regular Seats";
            this.totalregularseatsDataGridViewTextBoxColumn.Name = "totalregularseatsDataGridViewTextBoxColumn";
            this.totalregularseatsDataGridViewTextBoxColumn.Width = 90;
            // 
            // totalfristclassseatsDataGridViewTextBoxColumn
            // 
            this.totalfristclassseatsDataGridViewTextBoxColumn.DataPropertyName = "total_frist_class_seats";
            this.totalfristclassseatsDataGridViewTextBoxColumn.HeaderText = "Frist Class Seats";
            this.totalfristclassseatsDataGridViewTextBoxColumn.Name = "totalfristclassseatsDataGridViewTextBoxColumn";
            this.totalfristclassseatsDataGridViewTextBoxColumn.Width = 90;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "flights";
            this.flightsBindingSource.DataSource = this.fligthDataContext;
            // 
            // fligthDataContext
            // 
            this.fligthDataContext.DataSetName = "FligthDataContext";
            this.fligthDataContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // FligthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator);
            this.Name = "FligthForm";
            this.Text = "Fligth";
            this.Load += new System.EventHandler(this.FligthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aircraftDataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fligthDataContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton AddNew;
        private System.Windows.Forms.ToolStripLabel CountItem;
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
        private FligthDataContext fligthDataContext;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private FligthDataContextTableAdapters.flightsTableAdapter flightsTableAdapter;
        private RouteDataContext routeDataContext;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private RouteDataContextTableAdapters.routesTableAdapter routesTableAdapter;
        private AircraftDataContext aircraftDataContext;
        private System.Windows.Forms.BindingSource aircraftsBindingSource;
        private AircraftDataContextTableAdapters.aircraftsTableAdapter aircraftsTableAdapter;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn flight_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn routeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn aircraftidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regularseatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fristclassseatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalregularseatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalfristclassseatsDataGridViewTextBoxColumn;
    }
}