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
    public partial class SignUp : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public SignUp()
        {
            InitializeComponent();
        }
      
         public void clear()
        {
            tbUserId.Text = "";
            tbUserName.Text = "";
            tbPassword.Text = "";
        }
        public void GetNextID()
        {
            try
            {
                int NewID = 0;
                cmd = new SqlCommand("SELECT MAX(UserId) FROM UsersTable", cn);
                cn.Open();
                NewID = Convert.ToInt32(cmd.ExecuteScalar());
                NewID = NewID + 1;
                tbUserId.Text = NewID.ToString();
                cn.Close();
                tbUserName.Focus();
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
                tbUserName.Focus();
                buttonSignUp.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       
   
        private void buttonClear_Click(object sender, EventArgs e)
        {
           
            buttonSignUp.Enabled = false;
            clear();
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != "" && tbPassword.Text != "")
            {
                

                cmd = new SqlCommand("insert into UsersTable values(@UserId, @UserNm,@UserPassword)", cn);
                cn.Open();

                cmd.Parameters.AddWithValue("@UserId", tbUserId.Text);
                cmd.Parameters.AddWithValue("@UserNm", tbUserName.Text);
                cmd.Parameters.AddWithValue("@UserPassword", tbPassword.Text);

                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("User Added!!!!");
                clear();
            }
            else
            {
                MessageBox.Show("Please Add New User!!!!!");
            }

        }
        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
      
    
    }
}




       
        

     
        
       
      

        
     



       

 




