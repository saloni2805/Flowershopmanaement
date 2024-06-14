namespace Flowershopmanaement
{
    partial class VendorTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorTypes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.tbVendorTypeNm = new System.Windows.Forms.TextBox();
            this.tbVendorTypeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVendorTypes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 388);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lblSearch);
            this.splitContainer1.Panel1.Controls.Add(this.buttonExit);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.tbVendorTypeNm);
            this.splitContainer1.Panel1.Controls.Add(this.tbVendorTypeID);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvVendorTypes);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(544, 454);
            this.splitContainer1.SplitterDistance = 264;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbSearch.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.tbSearch.Location = new System.Drawing.Point(297, 214);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(195, 33);
            this.tbSearch.TabIndex = 13;
            this.tbSearch.Visible = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged_1);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(49, 214);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(342, 31);
            this.lblSearch.TabIndex = 12;
            this.lblSearch.Text = "Search Vendor Type Name :";
            this.lblSearch.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(460, 168);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(69, 31);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(385, 168);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(69, 31);
            this.buttonSearch.TabIndex = 10;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(10, 168);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(69, 31);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(85, 168);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(69, 31);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(310, 168);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(69, 31);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(235, 168);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(69, 31);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.Location = new System.Drawing.Point(160, 168);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(69, 31);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // tbVendorTypeNm
            // 
            this.tbVendorTypeNm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbVendorTypeNm.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.tbVendorTypeNm.Location = new System.Drawing.Point(230, 107);
            this.tbVendorTypeNm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbVendorTypeNm.Name = "tbVendorTypeNm";
            this.tbVendorTypeNm.Size = new System.Drawing.Size(212, 33);
            this.tbVendorTypeNm.TabIndex = 4;
            // 
            // tbVendorTypeID
            // 
            this.tbVendorTypeID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbVendorTypeID.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.tbVendorTypeID.Location = new System.Drawing.Point(230, 56);
            this.tbVendorTypeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbVendorTypeID.Name = "tbVendorTypeID";
            this.tbVendorTypeID.ReadOnly = true;
            this.tbVendorTypeID.Size = new System.Drawing.Size(212, 33);
            this.tbVendorTypeID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(49, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendor Type Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(49, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendor Type ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(142, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "* VENDOR TYPES *";
            // 
            // dgvVendorTypes
            // 
            this.dgvVendorTypes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVendorTypes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVendorTypes.Location = new System.Drawing.Point(0, 0);
            this.dgvVendorTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVendorTypes.Name = "dgvVendorTypes";
            this.dgvVendorTypes.RowHeadersWidth = 43;
            this.dgvVendorTypes.RowTemplate.Height = 28;
            this.dgvVendorTypes.Size = new System.Drawing.Size(544, 114);
            this.dgvVendorTypes.TabIndex = 0;
            this.dgvVendorTypes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendorTypes_CellDoubleClick);
            // 
            // VendorTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 388);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VendorTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendorTypes";
            this.Load += new System.EventHandler(this.VendorTypes_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorTypes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvVendorTypes;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox tbVendorTypeNm;
        private System.Windows.Forms.TextBox tbVendorTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
    }
}