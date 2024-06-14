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
    public partial class OrderStatus : Form
    {
        SqlConnection  cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public OrderStatus()
        {
            InitializeComponent();
        }
        private void OrderStatus_Load(object sender, EventArgs e)
        {
           
           
            fillGridView();
        }
        public void fillGridView()
        {
            try
            {
                cn.Open();
                da = new SqlDataAdapter("select * from OrderStatus", cn);
                ds = new DataSet();
                da.Fill(ds,"OrderStatus");
                dgvOrderStatus.DataSource = ds.Tables["OrderStatus"];
                dgvOrderStatus.Refresh();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Clear()
        {
            tbOrderStatusID.Text = " ";
            tbOrderStatusNm.Text = " ";
        }
         
        public void GetNextID()
        {
            try
            {
                int NewID = 0;
                cmd = new SqlCommand("SELECT Max(OrderStatusId)from OrderStatus ", cn);
                cn.Open();
                NewID = Convert.ToInt32(cmd.ExecuteScalar());
                NewID = NewID + 1;
                tbOrderStatusID.Text = NewID.ToString();
                cn.Close();
                tbOrderStatusNm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvOrderStatus_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonAdd.Enabled = false;
            buttonSave.Enabled = false;
            buttonUpdate.Enabled = true;
            buttonDelete.Enabled = true;
            if (dgvOrderStatus.SelectedRows.Count > 0)
            {
                tbOrderStatusID.Text = dgvOrderStatus.SelectedRows[0].Cells[0].Value.ToString();
                tbOrderStatusNm.Text = dgvOrderStatus.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                GetNextID();
                tbOrderStatusNm.Focus();
                buttonSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into OrderStatus values (@OrderStatusId, @OrderStatusName)", cn);
                cmd.Parameters.AddWithValue("@OrderStatusId", int.Parse(tbOrderStatusID.Text));
                cmd.Parameters.AddWithValue("@OrderStatusName", tbOrderStatusNm.Text);
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
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("Update OrderStatus SET OrderStatusName=@OrderStatusName where OrderStatusId=@OrderStatusId", cn);
                cmd.Parameters.AddWithValue("@OrderStatusId" , int.Parse(tbOrderStatusID.Text));
                cmd.Parameters.AddWithValue("@OrderStatusName", tbOrderStatusNm.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Record Updated","UPDATED",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear();
                buttonAdd.Enabled = true;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
                fillGridView();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("DELETE OrderStatus WHERE OrderStatusId = @OrderStatusId",cn);
                cmd.Parameters.AddWithValue("@OrderStatusId",int.Parse(tbOrderStatusID.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted ","DELETED",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cn.Close();
                Clear();
                buttonAdd.Enabled = true;
                buttonUpdate.Enabled = false;
                buttonDelete.Enabled = false;
                fillGridView();
            }
            catch(Exception ex)
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
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            lblmsg.Visible = true;
            tbSearch.Visible = true;

        }
         
         private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
           
                 try
              {
                  cn.Open();
                  da = new SqlDataAdapter("SELECT * FROM OrderStatus WHERE  OrderStatusName LIKE '" + tbSearch.Text + "%'", cn);
                  ds = new DataSet();
                  da.Fill(ds, "OrderStatus");
                  dgvOrderStatus.DataSource = ds.Tables["OrderStatus"];
                  dgvOrderStatus.Refresh();
                  cn.Close();

                 
              }
           
             catch (Exception ex)
             {
                 MessageBox.Show(ex.ToString());
             }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
 
     }
}
