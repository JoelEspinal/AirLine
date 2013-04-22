namespace AirLine.froms
{
    partial class airLineConteiner
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AirportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AircrafMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoutetripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FligthMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FleMenu,
            this.ManageMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1187, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // FleMenu
            // 
            this.FleMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.FleMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.FleMenu.Name = "FleMenu";
            this.FleMenu.Size = new System.Drawing.Size(37, 20);
            this.FleMenu.Text = "File";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // ManageMenu
            // 
            this.ManageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AirportMenuItem,
            this.AircrafMenuItem,
            this.RoutetripMenuItem,
            this.FligthMenuItem,
            this.pricesToolStripMenuItem});
            this.ManageMenu.Name = "ManageMenu";
            this.ManageMenu.Size = new System.Drawing.Size(62, 20);
            this.ManageMenu.Text = "Manage";
            // 
            // AirportMenuItem
            // 
            this.AirportMenuItem.Name = "AirportMenuItem";
            this.AirportMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AirportMenuItem.Text = "Airport";
            this.AirportMenuItem.Click += new System.EventHandler(this.AirportMenuItem_Click);
            // 
            // AircrafMenuItem
            // 
            this.AircrafMenuItem.Name = "AircrafMenuItem";
            this.AircrafMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AircrafMenuItem.Text = "Aircraft";
            this.AircrafMenuItem.Click += new System.EventHandler(this.AircrafMenuItem_Click);
            // 
            // RoutetripMenuItem
            // 
            this.RoutetripMenuItem.Name = "RoutetripMenuItem";
            this.RoutetripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RoutetripMenuItem.Text = "Route";
            this.RoutetripMenuItem.Click += new System.EventHandler(this.RoutetripMenuItem_Click);
            // 
            // FligthMenuItem
            // 
            this.FligthMenuItem.Name = "FligthMenuItem";
            this.FligthMenuItem.Size = new System.Drawing.Size(152, 22);
            this.FligthMenuItem.Text = "Fligth";
            this.FligthMenuItem.Click += new System.EventHandler(this.FligthMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 640);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1187, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pricesToolStripMenuItem
            // 
            this.pricesToolStripMenuItem.Name = "pricesToolStripMenuItem";
            this.pricesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pricesToolStripMenuItem.Text = "Prices";
            this.pricesToolStripMenuItem.Click += new System.EventHandler(this.pricesToolStripMenuItem_Click);
            // 
            // airLineConteiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 662);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(1303, 710);
            this.MinimumSize = new System.Drawing.Size(1003, 650);
            this.Name = "airLineConteiner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Line";
            this.Load += new System.EventHandler(this.airLineConteiner_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem FleMenu;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ManageMenu;
        private System.Windows.Forms.ToolStripMenuItem AirportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AircrafMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoutetripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FligthMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pricesToolStripMenuItem;
    }
}



