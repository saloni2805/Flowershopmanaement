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
    public partial class ProductTypes : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public ProductTypes()
        {
            InitializeComponent();
        }

        private void ProductTypes_Load(object sender, EventArgs e)
        {
          
              fillGridView();
        }
        public void fillGridView()
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("select * from ProductTypes", cn);
                ds = new DataSet();
                da.Fill(ds,"ProductTypes");
                dgvProductTypes.DataSource = ds.Tables["ProductTypes"];
                dgvProductTypes.Refresh();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Clear()
        {
            tbProductTypeId.Text = "";
            tbProductTypeNm.Text = "";
            tbCGST.Text = "";
            tbSGST.Text = "";
        }
        public void GetNextID()
        {
            try
            {
                int NewID = 0;
                cmd = new SqlCommand("SELECT Max(ProductTypeId)from ProductTypes", cn);
                cn.Open();
                NewID = Convert.ToInt32(cmd.ExecuteScalar());
                NewID = NewID + 1;
                tbProductTypeId.Text = NewID.ToString();
                cn.Close();
                tbProductTypeNm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvProductTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Enabled = false;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            if (dgvProductTypes.SelectedRows.Count > 0)
            {
                tbProductTypeId.Text = dgvProductTypes.SelectedRows[0].Cells[0].Value.ToString();
                tbProductTypeNm.Text = dgvProductTypes.SelectedRows[0].Cells[1].Value.ToString();
                tbCGST.Text = dgvProductTypes.SelectedRows[0].Cells[2].Value.ToString();
                tbSGST.Text = dgvProductTypes.SelectedRows[0].Cells[3].Value.ToString();
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {

            try
            {
                GetNextID();
                tbProductTypeNm.Focus();
                buttonSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTypes values (@ProductTypeId,@ProductTypeNm,@C_GST,@S_GST)", cn);
                cmd.Parameters.AddWithValue("@ProductTypeId", int.Parse(tbProductTypeId.Text));
                cmd.Parameters.AddWithValue("@ProductTypeNm", tbProductTypeNm.Text);
                cmd.Parameters.AddWithValue("@C_GST", tbCGST.Text);
                cmd.Parameters.AddWithValue("@S_GST", tbSGST.Text);
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

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("DELETE ProductTypes WHERE ProductTypeId = @ProductTypeId", cn);
                cmd.Parameters.AddWithValue("@ProductTypeId", int.Parse(tbProductTypeId.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Records Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonClear_Click_1(object sender, EventArgs e)
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
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT * FROM ProductTypes WHERE ProductTypeNm LIKE '" + tbSearch.Text + "%'", cn);
                ds = new DataSet();
                da.Fill(ds, "ProductTypes");
                dgvProductTypes.DataSource = ds.Tables["ProductTypes"];
                dgvProductTypes.Refresh();
                cn.Close();
            }
        
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            lblSearch.Visible = true;
            tbSearch.Visible = true;
        }

        private void buttonExit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Update ProductTypes SET ProductTypeNm=@ProductTypeNm, C_GST=@C_GST,S_GST=@S_GST where ProductTypeId=@ProductTypeId", cn);
            
                cmd.Parameters.AddWithValue("@ProductTypeId", int.Parse(tbProductTypeId.Text));
                cmd.Parameters.AddWithValue("@ProductTypeNm", tbProductTypeNm.Text);
                cmd.Parameters.AddWithValue("@C_GST", tbCGST.Text);
                cmd.Parameters.AddWithValue("@S_GST", tbSGST.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Records Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label2_Click(object sender, EventArgs e)
        {

        } 

     }
}

