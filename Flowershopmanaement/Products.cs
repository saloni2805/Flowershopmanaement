using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flowershopmanaement
{
    public partial class Products : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
           
            fillGridView();
            //fillCombo();
            fillCombo2();
        }
                public void fillGridView()
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("select * from Products", cn);
                ds = new DataSet();
                da.Fill(ds,"Products");
                dgvProducts.DataSource = ds.Tables["Products"];
                dgvProducts.Refresh();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Clear()
        {
            tbProductId.Text = "";
            cmbProductTypeId.Text = "";
            tbProductNm.Text = "";            
            //tbProductColour.Text = "";
            tbProductSeason.Text = "";
            //tbProductSize.Text = "";
            tbProductPrice.Text = "";
            tbMargin.Text = "";
            tbStock.Text = "";
            tbUnitOnOrder.Text = "";
            tbReorderLevel.Text = "";
            //cmbVendorId.Text = "";
        }
        public void GetNextID()
        {
            try
            {
                int NewID = 0;
                cmd = new SqlCommand("SELECT Max(ProductId)from Products", cn);
                cn.Open();
                NewID = Convert.ToInt32(cmd.ExecuteScalar());
                NewID = NewID + 1;
                tbProductId.Text = NewID.ToString();
                cn.Close();
                tbProductNm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                GetNextID();
                tbProductNm.Focus();
                buttonSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       /* public void fillCombo()
        {
            da = new SqlDataAdapter("select * from Vendors", cn);
            dt = new DataTable();
            da.Fill(dt);
            cmbVendorId.DataSource = dt;
            cmbVendorId.DisplayMember = "VendorNm";
            cmbVendorId.ValueMember = "VendorID";
        }*/
        public void fillCombo2()
        {
            da = new SqlDataAdapter("select * from ProductTypes", cn);
            dt = new DataTable();
            da.Fill(dt);
            cmbProductTypeId.DataSource = dt;
            cmbProductTypeId.DisplayMember = "ProductTypeNm";
            cmbProductTypeId.ValueMember = "ProductTypeId";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into Products values (@ProductId,@ProductTypeId,@ProductNm,@ProductSeason,@ProductPrice,@Margin,@Stock,@UnitOnOrder,@ReorderLevel)", cn);
                cmd.Parameters.AddWithValue("@ProductId", int.Parse(tbProductId.Text));
                //cmd.Parameters.AddWithValue("@VendorID", cmbVendorId.SelectedValue);
                cmd.Parameters.AddWithValue("@ProductTypeId", cmbProductTypeId.SelectedValue);
                cmd.Parameters.AddWithValue("@ProductNm", tbProductNm.Text);                            
	            cmd.Parameters.AddWithValue("@ProductSeason", tbProductSeason.Text);
                //cmd.Parameters.AddWithValue("@ProductSize", tbProductSize.Text);
                cmd.Parameters.AddWithValue("@ProductPrice", tbProductPrice.Text);
                cmd.Parameters.AddWithValue("@Margin", tbMargin.Text);
                cmd.Parameters.AddWithValue("@Stock", tbStock.Text);
                cmd.Parameters.AddWithValue("@UnitOnOrder", tbUnitOnOrder.Text);
                cmd.Parameters.AddWithValue("@ReorderLevel", tbReorderLevel.Text);
               
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record Saved", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                buttonSave.Enabled = false;
                fillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("DELETE Products WHERE ProductId = @ProductId", cn);
                
                cmd.Parameters.AddWithValue("@ProductId", int.Parse(tbProductId.Text));
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
                Clear();
                buttonAdd.Enabled = true;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
                fillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
            Clear();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            lblSearch.Visible = true;
            tbSearch.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Update Products SET  ProductTypeId=@ProductTypeId, ProductNm=@ProductNm, ProductSeason=@ProductSeason, ProductPrice=@ProductPrice, Margin=@Margin, Stock=@Stock, UnitOnOrder=@UnitOnOrder, ReorderLevel=@ReorderLevel  where ProductId=@ProductId ", cn);
            
                cmd.Parameters.AddWithValue("@ProductId", int.Parse(tbProductId.Text));
                //cmd.Parameters.AddWithValue("@VendorID", cmbVendorId.SelectedValue);
                cmd.Parameters.AddWithValue("@ProductTypeId", cmbProductTypeId.SelectedValue);
                cmd.Parameters.AddWithValue("@ProductNm", tbProductNm.Text);                               
                cmd.Parameters.AddWithValue("@ProductSeason", tbProductSeason.Text);
               // cmd.Parameters.AddWithValue("@ProductSize", tbProductSize.Text);
                cmd.Parameters.AddWithValue("@ProductPrice", tbProductPrice.Text);
                cmd.Parameters.AddWithValue("@Margin", tbMargin.Text);
                cmd.Parameters.AddWithValue("@Stock", tbStock.Text);
                cmd.Parameters.AddWithValue("@UnitOnOrder", tbUnitOnOrder.Text);
                cmd.Parameters.AddWithValue("@ReorderLevel", tbReorderLevel.Text);
               
   
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                buttonAdd.Enabled = true;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
                fillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Enabled = false;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            if (dgvProducts.SelectedRows.Count > 0)
            {
                tbProductId.Text = dgvProducts.SelectedRows[0].Cells[0].Value.ToString();
                //cmbVendorId.SelectedValue = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
                cmbProductTypeId.SelectedValue = dgvProducts.SelectedRows[0].Cells[1].Value.ToString();
                tbProductNm.Text = dgvProducts.SelectedRows[0].Cells[2].Value.ToString();
                //tbProductColour.Text = dgvProducts.SelectedRows[0].Cells[3].Value.ToString();
                tbProductSeason.Text = dgvProducts.SelectedRows[0].Cells[3].Value.ToString();
                //tbProductSize.Text = dgvProducts.SelectedRows[0].Cells[4].Value.ToString();
                tbProductPrice.Text = dgvProducts.SelectedRows[0].Cells[4].Value.ToString();
                tbMargin.Text = dgvProducts.SelectedRows[0].Cells[5].Value.ToString();
                tbStock.Text = dgvProducts.SelectedRows[0].Cells[6].Value.ToString();
                tbUnitOnOrder.Text = dgvProducts.SelectedRows[0].Cells[7].Value.ToString();
                tbReorderLevel.Text = dgvProducts.SelectedRows[0].Cells[8].Value.ToString();
             
                
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT * FROM Products WHERE  ProductNm LIKE '" + tbSearch.Text + "%'", cn);
                ds = new DataSet();
                da.Fill(ds, "Products");
                dgvProducts.DataSource = ds.Tables["Products"];
                dgvProducts.Refresh();
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
       
     
     }
}



