namespace AirLine.froms
{
    partial class PriceForm
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
            System.Windows.Forms.ToolStripButton MoveLast;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightid = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fligthDataContext = new AirLine.FligthDataContext();
            this.rtafpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtarpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtcfpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtcrpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owafpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owarpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owcfpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owcrpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pricesDataContext = new AirLine.PricesDataContext();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.AddNew = new System.Windows.Forms.ToolStripButton();
            this.CountItem = new System.Windows.Forms.ToolStripLabel();
            this.DeleteItem = new System.Windows.Forms.ToolStripButton();
            this.MoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.MovePrevious = new System.Windows.Forms.ToolStripButton();
            this.Sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.Position = new System.Windows.Forms.ToolStripTextBox();
            this.Sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.MoveNext = new System.Windows.Forms.ToolStripButton();
            this.Sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Cancel = new System.Windows.Forms.ToolStripButton();
            this.pricesTableAdapter = new AirLine.PricesDataContextTableAdapters.pricesTableAdapter();
            this.flightsTableAdapter = new AirLine.FligthDataContextTableAdapters.flightsTableAdapter();
            MoveLast = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fligthDataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoveLast
            // 
            MoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            MoveLast.Image = ((System.Drawing.Image)(resources.GetObject("MoveLast.Image")));
            MoveLast.Name = "MoveLast";
            MoveLast.RightToLeftAutoMirrorImage = true;
            MoveLast.Size = new System.Drawing.Size(23, 22);
            MoveLast.Text = "Move Last";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.flightid,
            this.rtafpriceDataGridViewTextBoxColumn,
            this.rtarpriceDataGridViewTextBoxColumn,
            this.rtcfpriceDataGridViewTextBoxColumn,
            this.rtcrpriceDataGridViewTextBoxColumn,
            this.owafpriceDataGridViewTextBoxColumn,
            this.owarpriceDataGridViewTextBoxColumn,
            this.owcfpriceDataGridViewTextBoxColumn,
            this.owcrpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pricesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 424);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightid
            // 
            this.flightid.DataPropertyName = "fligth_id";
            this.flightid.DataSource = this.flightsBindingSource;
            this.flightid.DisplayMember = "flight_name";
            this.flightid.HeaderText = "Flight";
            this.flightid.Name = "flightid";
            this.flightid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.flightid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.flightid.ValueMember = "id";
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
            // rtafpriceDataGridViewTextBoxColumn
            // 
            this.rtafpriceDataGridViewTextBoxColumn.DataPropertyName = "rt_a_f_price";
            this.rtafpriceDataGridViewTextBoxColumn.HeaderText = "RT-A-F";
            this.rtafpriceDataGridViewTextBoxColumn.Name = "rtafpriceDataGridViewTextBoxColumn";
            this.rtafpriceDataGridViewTextBoxColumn.ToolTipText = "Round Trip, Adult, First Class";
            // 
            // rtarpriceDataGridViewTextBoxColumn
            // 
            this.rtarpriceDataGridViewTextBoxColumn.DataPropertyName = "rt_a_r_price";
            this.rtarpriceDataGridViewTextBoxColumn.HeaderText = "TR-A-R";
            this.rtarpriceDataGridViewTextBoxColumn.Name = "rtarpriceDataGridViewTextBoxColumn";
            this.rtarpriceDataGridViewTextBoxColumn.ToolTipText = "Round Trip, Adult, Regular Class";
            // 
            // rtcfpriceDataGridViewTextBoxColumn
            // 
            this.rtcfpriceDataGridViewTextBoxColumn.DataPropertyName = "rt_c_f_price";
            this.rtcfpriceDataGridViewTextBoxColumn.HeaderText = "RT-C-F";
            this.rtcfpriceDataGridViewTextBoxColumn.Name = "rtcfpriceDataGridViewTextBoxColumn";
            this.rtcfpriceDataGridViewTextBoxColumn.ToolTipText = "Round Trip, CHILD, First Class";
            // 
            // rtcrpriceDataGridViewTextBoxColumn
            // 
            this.rtcrpriceDataGridViewTextBoxColumn.DataPropertyName = "rt_c_r_price";
            this.rtcrpriceDataGridViewTextBoxColumn.HeaderText = "RT-C-R";
            this.rtcrpriceDataGridViewTextBoxColumn.Name = "rtcrpriceDataGridViewTextBoxColumn";
            this.rtcrpriceDataGridViewTextBoxColumn.ToolTipText = "Round Trip, CHIELD, Regular Class";
            // 
            // owafpriceDataGridViewTextBoxColumn
            // 
            this.owafpriceDataGridViewTextBoxColumn.DataPropertyName = "ow_a_f_price";
            this.owafpriceDataGridViewTextBoxColumn.HeaderText = "OW-A-F";
            this.owafpriceDataGridViewTextBoxColumn.Name = "owafpriceDataGridViewTextBoxColumn";
            this.owafpriceDataGridViewTextBoxColumn.ToolTipText = "One Way, Adult, Frist Class";
            // 
            // owarpriceDataGridViewTextBoxColumn
            // 
            this.owarpriceDataGridViewTextBoxColumn.DataPropertyName = "ow_a_r_price";
            this.owarpriceDataGridViewTextBoxColumn.HeaderText = "OW-A-R";
            this.owarpriceDataGridViewTextBoxColumn.Name = "owarpriceDataGridViewTextBoxColumn";
            this.owarpriceDataGridViewTextBoxColumn.ToolTipText = "OneWay, Adult, Regular Class";
            // 
            // owcfpriceDataGridViewTextBoxColumn
            // 
            this.owcfpriceDataGridViewTextBoxColumn.DataPropertyName = "ow_c_f_price";
            this.owcfpriceDataGridViewTextBoxColumn.HeaderText = "OW-C-F";
            this.owcfpriceDataGridViewTextBoxColumn.Name = "owcfpriceDataGridViewTextBoxColumn";
            this.owcfpriceDataGridViewTextBoxColumn.ToolTipText = "One Way , Chield, Fist Class";
            // 
            // owcrpriceDataGridViewTextBoxColumn
            // 
            this.owcrpriceDataGridViewTextBoxColumn.DataPropertyName = "ow_c_r_price";
            this.owcrpriceDataGridViewTextBoxColumn.HeaderText = "OW-C-R";
            this.owcrpriceDataGridViewTextBoxColumn.Name = "owcrpriceDataGridViewTextBoxColumn";
            this.owcrpriceDataGridViewTextBoxColumn.ToolTipText = "One Way, Chield, Regular Class";
            // 
            // pricesBindingSource
            // 
            this.pricesBindingSource.DataMember = "prices";
            this.pricesBindingSource.DataSource = this.pricesDataContext;
            // 
            // pricesDataContext
            // 
            this.pricesDataContext.DataSetName = "PricesDataContext";
            this.pricesDataContext.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.AddNew;
            this.bindingNavigator.BindingSource = this.pricesBindingSource;
            this.bindingNavigator.CountItem = this.CountItem;
            this.bindingNavigator.DeleteItem = this.DeleteItem;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MoveFirstItem,
            this.MovePrevious,
            this.Sep1,
            this.Position,
            this.CountItem,
            this.Sep2,
            this.MoveNext,
            MoveLast,
            this.Sep3,
            this.AddNew,
            this.DeleteItem,
            this.Save,
            this.Cancel});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 439);
            this.bindingNavigator.MoveFirstItem = this.MoveFirstItem;
            this.bindingNavigator.MoveLastItem = MoveLast;
            this.bindingNavigator.MoveNextItem = this.MoveNext;
            this.bindingNavigator.MovePreviousItem = this.MovePrevious;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.Position;
            this.bindingNavigator.Size = new System.Drawing.Size(841, 25);
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
            this.AddNew.Text = "Add New";
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // CountItem
            // 
            this.CountItem.Name = "CountItem";
            this.CountItem.Size = new System.Drawing.Size(35, 22);
            this.CountItem.Text = "of {0}";
            this.CountItem.ToolTipText = "Total number of items";
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
            // MovePrevious
            // 
            this.MovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("MovePrevious.Image")));
            this.MovePrevious.Name = "MovePrevious";
            this.MovePrevious.RightToLeftAutoMirrorImage = true;
            this.MovePrevious.Size = new System.Drawing.Size(23, 22);
            this.MovePrevious.Text = "Move previous";
            // 
            // Sep1
            // 
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // Position
            // 
            this.Position.AccessibleName = "Position";
            this.Position.AutoSize = false;
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(50, 23);
            this.Position.Text = "0";
            this.Position.ToolTipText = "Current position";
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
            // pricesTableAdapter
            // 
            this.pricesTableAdapter.ClearBeforeFill = true;
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // PriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 464);
            this.Controls.Add(this.bindingNavigator);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PriceForm";
            this.Text = "PriceForm";
            this.Load += new System.EventHandler(this.PriceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fligthDataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricesDataContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton AddNew;
        private System.Windows.Forms.ToolStripLabel CountItem;
        private System.Windows.Forms.ToolStripButton DeleteItem;
        private System.Windows.Forms.ToolStripButton MoveFirstItem;
        private System.Windows.Forms.ToolStripButton MovePrevious;
        private System.Windows.Forms.ToolStripSeparator Sep1;
        private System.Windows.Forms.ToolStripTextBox Position;
        private System.Windows.Forms.ToolStripSeparator Sep2;
        private System.Windows.Forms.ToolStripButton MoveNext;
        private System.Windows.Forms.ToolStripSeparator Sep3;
        private PricesDataContext pricesDataContext;
        private System.Windows.Forms.BindingSource pricesBindingSource;
        private PricesDataContextTableAdapters.pricesTableAdapter pricesTableAdapter;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripButton Cancel;
        private FligthDataContext fligthDataContext;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private FligthDataContextTableAdapters.flightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn flightid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtafpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtarpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtcfpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtcrpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owafpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owarpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owcfpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owcrpriceDataGridViewTextBoxColumn;
    }
}