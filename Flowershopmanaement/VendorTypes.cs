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
    public partial class VendorTypes : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        //SQL Connection Represents a connection to a SQL Server database.
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public VendorTypes()
        {
            InitializeComponent();
        }
        private void VendorTypes_Load(object sender, EventArgs e)
        {           
            fillGridView();
        }
        public void fillGridView()
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("select * from VendorTypes", cn);
                ds = new DataSet();
                da.Fill(ds, "VendorTypes");
                dgvVendorTypes.DataSource = ds.Tables["VendorTypes"];
                dgvVendorTypes.Refresh();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void clear()
        {
            tbVendorTypeID.Text = "";
            tbVendorTypeNm.Text = "";
        }
        public void GetNextID()
        //The GetNext method returns the next object in the specified collection. It returns Nothing if no next object exists, for example, if already positioned at the end of the collection.

        {
            try
            {
                int NewID = 0;
                cmd = new SqlCommand("SELECT MAX(VendorTypeId) FROM VendorTypes", cn);
                cn.Open();
                NewID = Convert.ToInt32(cmd.ExecuteScalar());
                NewID = NewID + 1;
                tbVendorTypeID.Text = NewID.ToString();
                cn.Close();
                tbVendorTypeNm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
     
        private void buttonAdd_Click_1(object sender, EventArgs e)
            {
                try
                {
                    GetNextID();
                    tbVendorTypeNm.Focus();
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
                SqlCommand cmd = new SqlCommand("insert into VendorTypes values(@VendorTypeId,@VendorTypeNm)", cn);
                cmd.Parameters.AddWithValue("@VendorTypeId", int.Parse(tbVendorTypeID.Text));
                cmd.Parameters.AddWithValue("@VendorTypeNm", tbVendorTypeNm.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record Saved ", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
                buttonSave.Enabled = false;
                fillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Update VendorTypes SET VendorTypeNm=@VendorTypeNm where VendorTypeId=@VendorTypeId", cn);
                cmd.Parameters.AddWithValue("@VendorTypeId",int.Parse(tbVendorTypeID.Text));
                cmd.Parameters.AddWithValue("@VendorTypeNm", tbVendorTypeNm.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record Updated ", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
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
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
          try
           {
             cn.Open();
              cmd = new SqlCommand("DELETE VendorTypes WHERE VendorTypeId=@VendorTypeId", cn);
               cmd.Parameters.AddWithValue("@VendorTypeId",int.Parse(tbVendorTypeID.Text));
               cmd.ExecuteNonQuery();
               MessageBox.Show("Record Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
                  clear();
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
               clear();
           }
          private void buttonSearch_Click(object sender, EventArgs e)
              {
                 lblSearch.Visible = true;
                 tbSearch.Visible = true;
              }
           private void buttonExit_Click_1(object sender, EventArgs e)
            {
               this.Close();
            }

          

          private void tbSearch_TextChanged_1(object sender, EventArgs e)
          {
              try
              {
                  buttonUpdate.Enabled = false;
                  buttonDelete.Enabled = false;
                  cn.Open();
                  da = new SqlDataAdapter("SELECT * FROM VendorTypes WHERE  VendorTypeNm LIKE '" + tbSearch.Text + "%'", cn);
                  ds = new DataSet();
                  da.Fill(ds, "VendorType");
                  dgvVendorTypes.DataSource = ds.Tables["VendorType"];
                  dgvVendorTypes.Refresh();
                  cn.Close();

                 
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.ToString());

              }
   
          }

          private void dgvVendorTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
          {
              buttonAdd.Enabled = false;
              buttonSave.Enabled = false;
              buttonUpdate.Enabled = true;
              buttonDelete.Enabled = true;
             
              if (dgvVendorTypes.SelectedRows.Count > 0)
              {
                  tbVendorTypeID.Text = dgvVendorTypes.SelectedRows[0].Cells[0].Value.ToString();
                  tbVendorTypeNm.Text = dgvVendorTypes.SelectedRows[0].Cells[1].Value.ToString();
              }
          }
 
         
    }
}
    


