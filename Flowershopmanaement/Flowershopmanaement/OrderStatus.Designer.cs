namespace Flowershopmanaement
{
    partial class OrderStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderStatus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tbOrderStatusNm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOrderStatusID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrderStatus = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 383);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lblmsg);
            this.splitContainer1.Panel1.Controls.Add(this.buttonExit);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.tbOrderStatusNm);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.tbOrderStatusID);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvOrderStatus);
            this.splitContainer1.Size = new System.Drawing.Size(519, 379);
            this.splitContainer1.SplitterDistance = 252;
            this.splitContainer1.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbSearch.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.tbSearch.Location = new System.Drawing.Point(263, 207);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(196, 33);
            this.tbSearch.TabIndex = 15;
            this.tbSearch.Visible = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.lblmsg.Location = new System.Drawing.Point(19, 206);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(340, 31);
            this.lblmsg.TabIndex = 14;
            this.lblmsg.Text = "Search Order Status Name :";
            this.lblmsg.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(441, 162);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(66, 31);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(8, 162);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(66, 31);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(369, 162);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(66, 31);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(297, 162);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(66, 31);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(225, 162);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(66, 31);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.Location = new System.Drawing.Point(153, 162);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(66, 31);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(81, 162);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(66, 31);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tbOrderStatusNm
            // 
            this.tbOrderStatusNm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbOrderStatusNm.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.tbOrderStatusNm.Location = new System.Drawing.Point(205, 110);
            this.tbOrderStatusNm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOrderStatusNm.Name = "tbOrderStatusNm";
            this.tbOrderStatusNm.Size = new System.Drawing.Size(212, 33);
            this.tbOrderStatusNm.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Order Status Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Status ID :";
            // 
            // tbOrderStatusID
            // 
            this.tbOrderStatusID.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbOrderStatusID.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold);
            this.tbOrderStatusID.Location = new System.Drawing.Point(205, 60);
            this.tbOrderStatusID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbOrderStatusID.Name = "tbOrderStatusID";
            this.tbOrderStatusID.ReadOnly = true;
            this.tbOrderStatusID.Size = new System.Drawing.Size(212, 33);
            this.tbOrderStatusID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(142, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "* ORDER STATUS *";
            // 
            // dgvOrderStatus
            // 
            this.dgvOrderStatus.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderStatus.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderStatus.Name = "dgvOrderStatus";
            this.dgvOrderStatus.RowHeadersWidth = 43;
            this.dgvOrderStatus.RowTemplate.Height = 28;
            this.dgvOrderStatus.Size = new System.Drawing.Size(515, 119);
            this.dgvOrderStatus.TabIndex = 0;
            this.dgvOrderStatus.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderStatus_CellDoubleClick);
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(523, 383);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "OrderStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderStatus";
            this.Load += new System.EventHandler(this.OrderStatus_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrderStatusID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOrderStatusNm;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.DataGridView dgvOrderStatus;
    }
}