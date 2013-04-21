namespace AirLine.froms
{
    partial class RouteForm
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
            System.Windows.Forms.ToolStripButton SaveRoute;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteForm));
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.airportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new AirLine.AirportDataSet();
            this.routesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeDataContext = new AirLine.RouteDataContext();
            this.routesTableAdapter = new AirLine.RouteDataContextTableAdapters.routesTableAdapter();
            this.airportsTableAdapter = new AirLine.AirportDataSetTableAdapters.airportsTableAdapter();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.AddNew = new System.Windows.Forms.ToolStripButton();
            this.NavigatorCount = new System.Windows.Forms.ToolStripLabel();
            this.DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.MovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.NavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.MoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.Sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.CancelEdit = new System.Windows.Forms.ToolStripButton();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewComboBoxColumn();
            SaveRoute = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveRoute
            // 
            SaveRoute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            SaveRoute.Image = ((System.Drawing.Image)(resources.GetObject("SaveRoute.Image")));
            SaveRoute.ImageTransparentColor = System.Drawing.Color.Magenta;
            SaveRoute.Name = "SaveRoute";
            SaveRoute.Size = new System.Drawing.Size(23, 22);
            SaveRoute.Text = "Save";
            SaveRoute.Click += new System.EventHandler(this.SaveRoute_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.FlightDuration,
            this.Departure,
            this.Destination});
            this.DataGrid.DataSource = this.routesBindingSource;
            this.DataGrid.Location = new System.Drawing.Point(1, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(761, 426);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellContentClick);
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
            // routesTableAdapter
            // 
            this.routesTableAdapter.ClearBeforeFill = true;
            // 
            // airportsTableAdapter
            // 
            this.airportsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.AddNew;
            this.bindingNavigator.BindingSource = this.routesBindingSource;
            this.bindingNavigator.CountItem = this.NavigatorCount;
            this.bindingNavigator.DeleteItem = this.DeleteItem;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveFirstItem,
            this.MovePreviousItem,
            this.Sep1,
            this.NavigatorPositionItem,
            this.NavigatorCount,
            this.Sep2,
            this.MoveNextItem,
            this.MoveLastItem,
            this.Sep3,
            this.AddNew,
            this.DeleteItem,
            SaveRoute,
            this.CancelEdit});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 451);
            this.bindingNavigator.MoveFirstItem = this.MoveFirstItem;
            this.bindingNavigator.MoveLastItem = this.MoveLastItem;
            this.bindingNavigator.MoveNextItem = this.MoveNextItem;
            this.bindingNavigator.MovePreviousItem = this.MovePreviousItem;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.NavigatorPositionItem;
            this.bindingNavigator.Size = new System.Drawing.Size(766, 25);
            this.bindingNavigator.TabIndex = 1;
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
            // NavigatorCount
            // 
            this.NavigatorCount.Name = "NavigatorCount";
            this.NavigatorCount.Size = new System.Drawing.Size(35, 22);
            this.NavigatorCount.Text = "of {0}";
            this.NavigatorCount.ToolTipText = "Total number of items";
            // 
            // DeleteItem
            // 
            this.DeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("DeleteItem.Image")));
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.RightToLeftAutoMirrorImage = true;
            this.DeleteItem.Size = new System.Drawing.Size(23, 22);
            this.DeleteItem.Text = "Delete";
            // 
            // MoveFirstItem
            // 
            this.MoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("MoveFirstItem.Image")));
            this.MoveFirstItem.Name = "MoveFirstItem";
            this.MoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.MoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.MoveFirstItem.Text = "Move First";
            // 
            // MovePreviousItem
            // 
            this.MovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("MovePreviousItem.Image")));
            this.MovePreviousItem.Name = "MovePreviousItem";
            this.MovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.MovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.MovePreviousItem.Text = "Move previous";
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // NavigatorPositionItem
            // 
            this.NavigatorPositionItem.AccessibleName = "Position";
            this.NavigatorPositionItem.AutoSize = false;
            this.NavigatorPositionItem.Name = "NavigatorPositionItem";
            this.NavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.NavigatorPositionItem.Text = "0";
            this.NavigatorPositionItem.ToolTipText = "Current position";
            // 
            // Sep2
            // 
            this.Sep2.Name = "Sep2";
            this.Sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // MoveNextItem
            // 
            this.MoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("MoveNextItem.Image")));
            this.MoveNextItem.Name = "MoveNextItem";
            this.MoveNextItem.RightToLeftAutoMirrorImage = true;
            this.MoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.MoveNextItem.Text = "Move next";
            // 
            // MoveLastItem
            // 
            this.MoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("MoveLastItem.Image")));
            this.MoveLastItem.Name = "MoveLastItem";
            this.MoveLastItem.RightToLeftAutoMirrorImage = true;
            this.MoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.MoveLastItem.Text = "Move last";
            // 
            // Sep3
            // 
            this.Sep3.Name = "Sep3";
            this.Sep3.Size = new System.Drawing.Size(6, 25);
            // 
            // CancelEdit
            // 
            this.CancelEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CancelEdit.Image = ((System.Drawing.Image)(resources.GetObject("CancelEdit.Image")));
            this.CancelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CancelEdit.Name = "CancelEdit";
            this.CancelEdit.Size = new System.Drawing.Size(23, 22);
            this.CancelEdit.Text = "Cancel Edit";
            this.CancelEdit.Click += new System.EventHandler(this.CancelEdit_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FlightDuration
            // 
            this.FlightDuration.DataPropertyName = "flight_duration";
            this.FlightDuration.HeaderText = "Flight Duration";
            this.FlightDuration.Name = "FlightDuration";
            // 
            // Departure
            // 
            this.Departure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departure.DataPropertyName = "departure_id";
            this.Departure.DataSource = this.airportsBindingSource;
            this.Departure.DisplayMember = "name";
            this.Departure.HeaderText = "Departure";
            this.Departure.Name = "Departure";
            this.Departure.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Departure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Departure.ValueMember = "id";
            // 
            // Destination
            // 
            this.Destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destination.DataPropertyName = "destination_id";
            this.Destination.DataSource = this.airportsBindingSource;
            this.Destination.DisplayMember = "name";
            this.Destination.HeaderText = "Departur";
            this.Destination.Name = "Destination";
            this.Destination.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Destination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Destination.ValueMember = "id";
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 476);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.DataGrid);
            this.Name = "RouteForm";
            this.Text = "RouteForm";
            this.Load += new System.EventHandler(this.RouteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeDataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid;
        private RouteDataContext routeDataContext;
        private System.Windows.Forms.BindingSource routesBindingSource;
        private RouteDataContextTableAdapters.routesTableAdapter routesTableAdapter;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource airportsBindingSource;
        private AirportDataSetTableAdapters.airportsTableAdapter airportsTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton AddNew;
        private System.Windows.Forms.ToolStripLabel NavigatorCount;
        private System.Windows.Forms.ToolStripButton DeleteItem;
        private System.Windows.Forms.ToolStripButton MoveFirstItem;
        private System.Windows.Forms.ToolStripButton MovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator Sep1;
        private System.Windows.Forms.ToolStripTextBox NavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator Sep2;
        private System.Windows.Forms.ToolStripButton MoveNextItem;
        private System.Windows.Forms.ToolStripButton MoveLastItem;
        private System.Windows.Forms.ToolStripSeparator Sep3;
        private System.Windows.Forms.ToolStripButton CancelEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightDuration;
        private System.Windows.Forms.DataGridViewComboBoxColumn Departure;
        private System.Windows.Forms.DataGridViewComboBoxColumn Destination;
    }
}