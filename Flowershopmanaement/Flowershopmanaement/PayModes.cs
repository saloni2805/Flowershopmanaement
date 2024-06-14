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
    public partial class PayModes : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public PayModes()
        {
            InitializeComponent();
        }
        private void PayModes_Load(object sender, EventArgs e)
        {
          


            fillGridView();
        }
        public void fillGridView()
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("select * from PayModes", cn);
                ds = new DataSet();
                da.Fill(ds, "PayModes");
                dgvPayModes.DataSource = ds.Tables["PayModes"];
                dgvPayModes.Refresh();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Clear()
        {
            tbPayModesID.Text = " ";
            tbPayModesNm.Text = " ";
        }

        public void GetNextID()
        {
            try
            {
                int NewID = 0;
                cmd = new SqlCommand("SELECT Max(PayModeId)from PayModes ", cn);
                cn.Open();
                NewID = Convert.ToInt32(cmd.ExecuteScalar());
                NewID = NewID + 1;
                tbPayModesID.Text = NewID.ToString();
                cn.Close();
                tbPayModesNm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvPayModes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Enabled = false;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            if (dgvPayModes.SelectedRows.Count > 0)
            {
                tbPayModesID.Text = dgvPayModes.SelectedRows[0].Cells[0].Value.ToString();
                tbPayModesNm.Text = dgvPayModes.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                GetNextID();
                tbPayModesNm.Focus();
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
                SqlCommand cmd = new SqlCommand("insert into PayModes values (@PayModeId, @PayModeName)", cn);
                cmd.Parameters.AddWithValue("@PayModeId", int.Parse(tbPayModesID.Text));
                cmd.Parameters.AddWithValue("@PayModeName", tbPayModesNm.Text);
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
        private void buttonUpdate_Click_1(object sender, EventArgs e)
     
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Update PayModes SET PayModeName=@PayModeName where PayModeId=@PayModeId", cn);
                cmd.Parameters.AddWithValue("@PayModeId", int.Parse(tbPayModesID.Text));
                cmd.Parameters.AddWithValue("@PayModeName", tbPayModesNm.Text);
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
        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("DELETE PayModes WHERE PayModeId = @PayModeId", cn);
                cmd.Parameters.AddWithValue("@PayModeId", int.Parse(tbPayModesID.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted ", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            lblmsg.Visible = true;
            tbSearch.Visible = true;

        }

        private void tbSearch_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("SELECT * FROM PayModes WHERE  PayModeName LIKE '" + tbSearch.Text + "%'", cn);
                ds = new DataSet();
                da.Fill(ds, "PayModes");
                dgvPayModes.DataSource = ds.Tables["PayModes"];
                dgvPayModes.Refresh();
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}