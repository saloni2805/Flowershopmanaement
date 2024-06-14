namespace Flowershopmanaement
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProductTypeId = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tbReorderLevel = new System.Windows.Forms.TextBox();
            this.tbUnitOnOrder = new System.Windows.Forms.TextBox();
            this.tbMargin = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbProductSeason = new System.Windows.Forms.TextBox();
            this.tbProductNm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
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
            this.panel1.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 598);
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
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.cmbProductTypeId);
            this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lblSearch);
            this.splitContainer1.Panel1.Controls.Add(this.buttonExit);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            this.splitContainer1.Panel1.Controls.Add(this.tbReorderLevel);
            this.splitContainer1.Panel1.Controls.Add(this.tbUnitOnOrder);
            this.splitContainer1.Panel1.Controls.Add(this.tbMargin);
            this.splitContainer1.Panel1.Controls.Add(this.tbStock);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.tbProductPrice);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tbProductSeason);
            this.splitContainer1.Panel1.Controls.Add(this.tbProductNm);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.tbProductId);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvProducts);
            this.splitContainer1.Size = new System.Drawing.Size(698, 594);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 26);
            this.label5.TabIndex = 35;
            this.label5.Text = "%";
            // 
            // cmbProductTypeId
            // 
            this.cmbProductTypeId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cmbProductTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductTypeId.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProductTypeId.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductTypeId.FormattingEnabled = true;
            this.cmbProductTypeId.Location = new System.Drawing.Point(505, 63);
            this.cmbProductTypeId.Name = "cmbProductTypeId";
            this.cmbProductTypeId.Size = new System.Drawing.Size(164, 34);
            this.cmbProductTypeId.TabIndex = 34;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbSearch.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(294, 363);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(224, 33);
            this.tbSearch.TabIndex = 32;
            this.tbSearch.Visible = false;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(92, 363);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(285, 31);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Search Product Name :";
            this.lblSearch.Visible = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExit.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(554, 317);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 29);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearch.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.Location = new System.Drawing.Point(468, 317);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(80, 29);
            this.buttonSearch.TabIndex = 29;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(382, 317);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 29);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(296, 317);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(80, 29);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUpdate.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.Location = new System.Drawing.Point(210, 317);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 29);
            this.buttonUpdate.TabIndex = 26;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSave.Location = new System.Drawing.Point(124, 317);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 29);
            this.buttonSave.TabIndex = 25;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("Constantia", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAdd.Location = new System.Drawing.Point(38, 317);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(80, 29);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tbReorderLevel
            // 
            this.tbReorderLevel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbReorderLevel.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReorderLevel.Location = new System.Drawing.Point(152, 259);
            this.tbReorderLevel.Name = "tbReorderLevel";
            this.tbReorderLevel.Size = new System.Drawing.Size(204, 33);
            this.tbReorderLevel.TabIndex = 22;
            // 
            // tbUnitOnOrder
            // 
            this.tbUnitOnOrder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbUnitOnOrder.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUnitOnOrder.Location = new System.Drawing.Point(152, 211);
            this.tbUnitOnOrder.Name = "tbUnitOnOrder";
            this.tbUnitOnOrder.Size = new System.Drawing.Size(204, 33);
            this.tbUnitOnOrder.TabIndex = 21;
            // 
            // tbMargin
            // 
            this.tbMargin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbMargin.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMargin.Location = new System.Drawing.Point(505, 162);
            this.tbMargin.Name = "tbMargin";
            this.tbMargin.Size = new System.Drawing.Size(137, 33);
            this.tbMargin.TabIndex = 20;
            // 
            // tbStock
            // 
            this.tbStock.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbStock.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.Location = new System.Drawing.Point(505, 210);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(164, 33);
            this.tbStock.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(369, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Stock :";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbProductPrice.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductPrice.Location = new System.Drawing.Point(505, 114);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(164, 33);
            this.tbProductPrice.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(369, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Price :";
            // 
            // tbProductSeason
            // 
            this.tbProductSeason.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbProductSeason.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductSeason.Location = new System.Drawing.Point(152, 162);
            this.tbProductSeason.Name = "tbProductSeason";
            this.tbProductSeason.Size = new System.Drawing.Size(204, 33);
            this.tbProductSeason.TabIndex = 16;
            // 
            // tbProductNm
            // 
            this.tbProductNm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbProductNm.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductNm.Location = new System.Drawing.Point(152, 112);
            this.tbProductNm.Name = "tbProductNm";
            this.tbProductNm.Size = new System.Drawing.Size(204, 33);
            this.tbProductNm.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Name :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(8, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 31);
            this.label13.TabIndex = 13;
            this.label13.Text = "Product Season :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(8, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 31);
            this.label11.TabIndex = 11;
            this.label11.Text = "Reorder Level :";
            // 
            // tbProductId
            // 
            this.tbProductId.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tbProductId.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductId.Location = new System.Drawing.Point(152, 62);
            this.tbProductId.Name = "tbProductId";
            this.tbProductId.ReadOnly = true;
            this.tbProductId.Size = new System.Drawing.Size(204, 33);
            this.tbProductId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(235, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "* PRODUCTS *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(369, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Type :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(8, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(196, 31);
            this.label12.TabIndex = 12;
            this.label12.Text = "Unit On Order :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(369, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 31);
            this.label9.TabIndex = 9;
            this.label9.Text = "Margin :";
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 43;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(694, 172);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellDoubleClick);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(702, 598);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProductId;
        private System.Windows.Forms.TextBox tbProductNm;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductSeason;
        private System.Windows.Forms.TextBox tbMargin;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbReorderLevel;
        private System.Windows.Forms.TextBox tbUnitOnOrder;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ComboBox cmbProductTypeId;
        private System.Windows.Forms.Label label5;
        // private System.Windows.Forms.DataGridViewTextBoxColumn productColourDataGridViewTextBoxColumn;
    }
}