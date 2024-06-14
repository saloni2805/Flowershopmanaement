using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowershopmanaement
{
    public partial class MDI_FSMS : Form
    {
        

        public MDI_FSMS()
        {
            InitializeComponent();
        }

        private void VendorTypesToolStrip_Click_1(object sender, EventArgs e)
        {
            try
            {
                VendorTypes vt = new VendorTypes();
                vt.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void VendorsToolStrip_Click_1(object sender, EventArgs e)
        {

            try
            {
                Vendors vendors = new Vendors();
                vendors.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ProductTypes producttypes = new ProductTypes();
                producttypes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

       private void PayModesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                PayModes pm = new PayModes();
                pm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("C:\\Windows\\System32\\calc.exe");

        }

        private void notepadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Windows\\System32\\Notepad.exe");
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
             try
            {
                Products producttypes = new Products();
                producttypes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void OrderStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OrderStatus orderstatus = new OrderStatus();
                orderstatus.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

      
        private void ordersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Orders Orders = new Orders();
                Orders.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void masterReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                CrystalReport CrystalReport = new CrystalReport();
                CrystalReport.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

      
       
    }
}
