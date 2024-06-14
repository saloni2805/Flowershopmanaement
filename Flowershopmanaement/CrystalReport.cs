using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace  Flowershopmanaement
{
    public partial class CrystalReport : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public CrystalReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from VendorTypes", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "VendorTypes");
            VendorTypeReport rvt = new VendorTypeReport();
            rvt.SetDataSource(ds.Tables["VendorTypes"]);
            ReportDocument crpt = new ReportDocument();
            crpt.Load(@"C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\VendorTypeReport.rpt");
            crvFlowerShop.ReportSource = rvt;
            crvFlowerShop.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from VendorTypes_VendorsView", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "VendorTypes_VendorsView");
            VendorsReport rvt = new VendorsReport();
            rvt.SetDataSource(ds.Tables["VendorTypes_VendorsView"]);
            ReportDocument crpt = new ReportDocument();
            crpt.Load(@"C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\VendorsReport.rpt");
            crvFlowerShop.ReportSource = rvt;
            crvFlowerShop.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from ProductTypes", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ProductTypes");
            ProductTypesReport rvt = new ProductTypesReport();
            rvt.SetDataSource(ds.Tables["ProductTypes"]);
            ReportDocument crpt = new ReportDocument();
            crpt.Load(@"C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\ProductTypesReport.rpt");
            crvFlowerShop.ReportSource = rvt;
            crvFlowerShop.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from PayModes", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "PayModes");
            PayModesReport rvt = new PayModesReport();
            rvt.SetDataSource(ds.Tables["PayModes"]);
            ReportDocument crpt = new ReportDocument();
            crpt.Load(@"C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\PayModesReport.rpt");
            crvFlowerShop.ReportSource = rvt;
            crvFlowerShop.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from UsersTable", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "UsersTable");
            UserTableReport rvt = new UserTableReport();
            rvt.SetDataSource(ds.Tables["UsersTable"]);
            ReportDocument crpt = new ReportDocument();
            crpt.Load(@"C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\UserTableReport.rpt");
            crvFlowerShop.ReportSource = rvt;
            crvFlowerShop.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from OrderStatus", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "OrderStatus");
            OrderStatusReport rvt = new OrderStatusReport();
            rvt.SetDataSource(ds.Tables["OrderStatus"]);
            ReportDocument crpt = new ReportDocument();
            crpt.Load(@"C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\OrderStatusReport.rpt");
            crvFlowerShop.ReportSource = rvt;
            crvFlowerShop.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from ProductTypes_ProductsView", cn);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "ProductTypes_ProductsView");
            ProductsReport rvt = new ProductsReport();
            rvt.SetDataSource(ds.Tables["ProductTypes_ProductsView"]);
            ReportDocument crpt = new ReportDocument();
            crpt.Load(@"C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\ProductsReport.rpt");
            crvFlowerShop.ReportSource = rvt;
            crvFlowerShop.Refresh();
        }
    }
}
