using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Flowershopmanaement
{
    public partial class Vendors : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        //SQL Connection Represents a connection to a SQL Server database. 
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public Vendors()
        {
            InitializeComponent();
        }
        private void Vendors_Load(object sender, EventArgs e)
        {      
            fillGridView();
            fillCombo();
        }
        public void fillGridView()
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("select * from Vendors", cn);
                ds = new DataSet();
                da.Fill(ds, "Vendors");
                dgvVendors.DataSource = ds.Tables["Vendors"];
                dgvVendors.Refresh();
                cn.Close();
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
                tbVendorNm.Focus();
                buttonSave.Enabled = true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void fillCombo()
        {
            da = new SqlDataAdapter("select * from VendorTypes", cn);
            dt = new DataTable();
            da.Fill(dt);
            cmbVendorTypeID.DataSource = dt;
            cmbVendorTypeID.DisplayMember = "VendorTypeNm";
            cmbVendorTypeID.ValueMember = "VendorTypeId";
        }
         public void GetNextID()
        //The GetNext method returns the next object in the specified collection. It returns Nothing if no next object exists, for example, if already positioned at the end of the collection.
          {
            try
            {
                int NewID = 0;
                cmd = new SqlCommand("SELECT MAX(VendorID) FROM Vendors", cn);
                cn.Open();
                NewID = Convert.ToInt32(cmd.ExecuteScalar());
                NewID = NewID + 1;
                tbVendorId.Text = NewID.ToString();
                cn.Close();
                tbVendorNm.Focus();
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
                SqlCommand cmd = new SqlCommand("insert into Vendors values (@VendorID,@VendorNm,@VendorAddress,@VendorContactNum,@VendorEmailId,@VendorJoinDate,@VendorTypeId)", cn);
                //A SqlCommand object allows you to query and send commands to a database.
                cmd.Parameters.AddWithValue("@VendorID", int.Parse(tbVendorId.Text));
              
                cmd.Parameters.AddWithValue("@VendorNm", tbVendorNm.Text);
                cmd.Parameters.AddWithValue("@VendorAddress", tbVendorAddress.Text);
                cmd.Parameters.AddWithValue("@VendorContactNum", tbVendorContNm.Text);
                cmd.Parameters.AddWithValue("@VendorEmailId", tbVendorEmailId.Text);
                cmd.Parameters.AddWithValue("@VendorJoinDate", tbVendorJoinDate.Value);
                cmd.Parameters.AddWithValue("@VendorTypeId", cmbVendorTypeID.SelectedValue);
              
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record Saved", "SAVED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                buttonSave.Enabled = false;
                fillGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void clear()
        {

            tbVendorId.Text = "";
            cmbVendorTypeID.Text = "";
            tbVendorNm.Text = "";
            tbVendorContNm.Text = "";
            tbVendorAddress.Text = "";
            tbVendorEmailId.Text = "";
            tbVendorJoinDate.Text = "";
        }
        
        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Update Vendors SET VendorNm=@VendorNm,VendorAddress=@VendorAddress, VendorContactNum=@VendorContactNum,VendorEmailId= @VendorEmailId, VendorJoinDate=@VendorJoinDate,VendorTypeId=@VendorTypeId  where VendorID=@VendorID", cn);
                cmd.Parameters.AddWithValue("@VendorID", int.Parse(tbVendorId.Text));
                
                cmd.Parameters.AddWithValue("@VendorNm", tbVendorNm.Text);
                cmd.Parameters.AddWithValue("@VendorAddress", tbVendorAddress.Text);
                cmd.Parameters.AddWithValue("@VendorContactNum", tbVendorContNm.Text);
                cmd.Parameters.AddWithValue("@VendorEmailId", tbVendorEmailId.Text);
                cmd.Parameters.AddWithValue("@VendorJoinDate", tbVendorJoinDate.Value);
                cmd.Parameters.AddWithValue("@VendorTypeId", cmbVendorTypeID.SelectedValue);
               
            
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record Updated", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                buttonAdd.Enabled = true;
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
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("DELETE Vendors WHERE VendorID=@VendorID", cn);
                cmd.Parameters.AddWithValue("@VendorID", int.Parse (tbVendorId.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cn.Close();
                clear();
                buttonAdd.Enabled = true;
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
        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSave.Enabled = false;
            clear();
        }
        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
        try
        {
         cn.Open();
         da = new SqlDataAdapter("SELECT * FROM Vendors WHERE VendorNm LIKE '" +tbSearch.Text+ "%'", cn);
         ds = new DataSet();
         da.Fill(ds, "Vendors");
         dgvVendors.DataSource = ds.Tables["Vendors"];
         dgvVendors.Refresh();
         cn.Close();
         }
         catch (Exception ex)
         {
           MessageBox.Show(ex.ToString());
        
         }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
          lblSearch.Visible = true;
          tbSearch.Visible = true;
        }

        private void dgvVendors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            //The GridView control displays the values of a data source in a table.
        {
            
            buttonAdd.Enabled = false;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;

            if (dgvVendors.SelectedRows.Count > 0)
            {

                tbVendorId.Text = dgvVendors.SelectedRows[0].Cells[0].Value.ToString();

              

                tbVendorNm.Text = dgvVendors.SelectedRows[0].Cells[1].Value.ToString();

                tbVendorAddress.Text = dgvVendors.SelectedRows[0].Cells[2].Value.ToString();

                tbVendorContNm.Text = dgvVendors.SelectedRows[0].Cells[3].Value.ToString();

                tbVendorEmailId.Text = dgvVendors.SelectedRows[0].Cells[4].Value.ToString();

                tbVendorJoinDate.Text = dgvVendors.SelectedRows[0].Cells[5].Value.ToString();

                cmbVendorTypeID.SelectedValue = dgvVendors.SelectedRows[0].Cells[6].Value.ToString();

              

            }
        }

        private void tbVendorContNm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & (Keys)e.KeyChar != Keys.Enter)
            {
                e.Handled = true;
            }
            if (tbVendorContNm.Text.Length < 10)
            {
                tbVendorContNm.Focus();
            }
        }

        private void tbVendorEmailId_Validating(object sender, CancelEventArgs e)
        {
            string email = tbVendorEmailId.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
            {
              //  MessageBox.Show("Valid EmailID", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid EmailID", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    

      

      
       



    
    }
}
