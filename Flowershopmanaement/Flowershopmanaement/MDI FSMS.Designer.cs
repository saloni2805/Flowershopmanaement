namespace Flowershopmanaement
{
    partial class MDI_FSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI_FSMS));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MasterForm = new System.Windows.Forms.ToolStripMenuItem();
            this.VendorTypesToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.VendorsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PayModesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 680);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(1123, 676);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MasterForm,
            this.transactionFormToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.utilityToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 21);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MasterForm
            // 
            this.MasterForm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MasterForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VendorTypesToolStrip,
            this.VendorsToolStrip,
            this.ProductTypesToolStripMenuItem,
            this.ProductsToolStripMenuItem,
            this.OrderStatusToolStripMenuItem,
            this.PayModesToolStripMenuItem});
            this.MasterForm.Font = new System.Drawing.Font("Cambria", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.MasterForm.Name = "MasterForm";
            this.MasterForm.Size = new System.Drawing.Size(176, 17);
            this.MasterForm.Text = "Master Form";
            // 
            // VendorTypesToolStrip
            // 
            this.VendorTypesToolStrip.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorTypesToolStrip.Name = "VendorTypesToolStrip";
            this.VendorTypesToolStrip.Size = new System.Drawing.Size(214, 28);
            this.VendorTypesToolStrip.Text = "Vendor Types";
            this.VendorTypesToolStrip.Click += new System.EventHandler(this.VendorTypesToolStrip_Click_1);
            // 
            // VendorsToolStrip
            // 
            this.VendorsToolStrip.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorsToolStrip.Name = "VendorsToolStrip";
            this.VendorsToolStrip.Size = new System.Drawing.Size(214, 28);
            this.VendorsToolStrip.Text = "Vendors";
            this.VendorsToolStrip.Click += new System.EventHandler(this.VendorsToolStrip_Click_1);
            // 
            // ProductTypesToolStripMenuItem
            // 
            this.ProductTypesToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductTypesToolStripMenuItem.Name = "ProductTypesToolStripMenuItem";
            this.ProductTypesToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.ProductTypesToolStripMenuItem.Text = "Product Types";
            this.ProductTypesToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // ProductsToolStripMenuItem
            // 
            this.ProductsToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem";
            this.ProductsToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.ProductsToolStripMenuItem.Text = "Products";
            this.ProductsToolStripMenuItem.Click += new System.EventHandler(this.flowersToolStripMenuItem_Click);
            // 
            // OrderStatusToolStripMenuItem
            // 
            this.OrderStatusToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderStatusToolStripMenuItem.Name = "OrderStatusToolStripMenuItem";
            this.OrderStatusToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.OrderStatusToolStripMenuItem.Text = "Order Status";
            this.OrderStatusToolStripMenuItem.Click += new System.EventHandler(this.OrderStatusToolStripMenuItem_Click);
            // 
            // PayModesToolStripMenuItem
            // 
            this.PayModesToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayModesToolStripMenuItem.Name = "PayModesToolStripMenuItem";
            this.PayModesToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
            this.PayModesToolStripMenuItem.Text = "PayModes";
            this.PayModesToolStripMenuItem.Click += new System.EventHandler(this.PayModesToolStripMenuItem_Click);
            // 
            // transactionFormToolStripMenuItem
            // 
            this.transactionFormToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.transactionFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem1});
            this.transactionFormToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.transactionFormToolStripMenuItem.Name = "transactionFormToolStripMenuItem";
            this.transactionFormToolStripMenuItem.Size = new System.Drawing.Size(236, 17);
            this.transactionFormToolStripMenuItem.Text = "Transaction Form";
            // 
            // ordersToolStripMenuItem1
            // 
            this.ordersToolStripMenuItem1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersToolStripMenuItem1.Name = "ordersToolStripMenuItem1";
            this.ordersToolStripMenuItem1.Size = new System.Drawing.Size(152, 28);
            this.ordersToolStripMenuItem1.Text = "Orders";
            this.ordersToolStripMenuItem1.Click += new System.EventHandler(this.ordersToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterReportToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(105, 17);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // masterReportToolStripMenuItem
            // 
            this.masterReportToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterReportToolStripMenuItem.Name = "masterReportToolStripMenuItem";
            this.masterReportToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.masterReportToolStripMenuItem.Text = "Master Report";
            this.masterReportToolStripMenuItem.Click += new System.EventHandler(this.masterReportToolStripMenuItem_Click);
            // 
            // utilityToolStripMenuItem
            // 
            this.utilityToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.utilityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.utilityToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            this.utilityToolStripMenuItem.Size = new System.Drawing.Size(98, 17);
            this.utilityToolStripMenuItem.Text = "Utility";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click_1);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(177, 28);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(71, 17);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 643);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MDI_FSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1127, 680);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI_FSMS";
            this.Text = "MDI_FSMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MasterForm;
        private System.Windows.Forms.ToolStripMenuItem VendorTypesToolStrip;
        private System.Windows.Forms.ToolStripMenuItem VendorsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem ProductTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrderStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PayModesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}