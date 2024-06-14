using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Flowershopmanaement
{
    public partial class LoginForm : Form
    {
        string cn = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        //Connection String is a normal String representation which contains Database connection information to establish the connection between Database and the Application.
        public LoginForm()
        {
            InitializeComponent();
            //InitializeComponent() method in Visual Studio.NET C# or VB.NET is method that is automatically created and managed by Windows Forms designer and it defines everything you see on the form
        }

        private void buttonOK_Click(object sender, EventArgs e)
            //C# Button class in .NET Framework class library represents a Windows Forms Button control.
         {
            if (textBoxUsername.Text == " " || textBoxPassword.Text == " ")
                //With the TextBox control, the user can enter text in an application.
            {
                MessageBox.Show("Please enter valid username and password","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxUsername.Focus();
                return;
            }
            try
            {
                string query = "SELECT UserNm, UserPassword FROM UsersTable WHERE UserNm='" + textBoxUsername.Text.Trim() + " 'and UserPassword='" + textBoxPassword.Text.Trim() + " ' ";
              
                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                //It is bridge between DataSet and DataSource
                DataTable dt = new DataTable();
                //The DataTable class in C# ADO.NET is a database table representation and provides a collection of columns and rows to store data in a grid form. 

                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful " + "'" + textBoxUsername.Text + "'", "WELCOME");
                    this.Hide();
                    MDI_FSMS mdi = new MDI_FSMS();
                    mdi.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed ", "TRY AGAIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBoxUsername.Text = ""; textBoxPassword.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelNewusser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SignUp NewUser = new SignUp();
                NewUser.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        
    }
}
