using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Windows;

using MyLibrary;

namespace Flowershopmanaement
{
    public partial class Orders : Form
    {
        DBManager dbm = new DBManager();
        DBManager dbmStock = new DBManager();
        BindingSource bsVendor_Type;
        BindingSource bsVendor_s;
        BindingSource bsOrders;
        BindingSource bsOrderDetails;
        BindingSource bsOrderstatus;
        BindingSource bsProductType;
        BindingSource bsProducts;
        BindingSource bsPayMode;
        BindingSource bsPay;
        BindingSource bsStockProduct;

        public Orders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
           
           
            //call cda’s
            dbm.cdaVendorType();
            dbm.cdaVendors();

            dbm.cdaOrderStatus();
            dbm.cdaOrders();

            dbm.cdaOrderDetails();
            dbm.cdaProductType();
            dbm.cdaProducts();

            dbm.cdaPaymentMode();
            dbm.cdaPayment();
            dbmStock.cdaProducts();


            //call relations
            dbm.crVendorType_Vendors();
            dbm.crVendors_Orders();

            dbm.crOrders_OrderDetails();
            dbm.crProductType_Products();

            dbm.crOrders_Payment();

            //assign bindingSource
            bsVendor_Type = dbm.bsVendorType;
            bsVendor_s = dbm.bsVendors;
            bsOrderstatus = dbm.bsOrder_Status;
         
            bsOrders = dbm.bsOrder_s;
            dgvOrders.DataSource = bsOrders;
            bsOrderDetails = dbm.bsOrder_Details;
            dgvOrderDetails.DataSource = bsOrderDetails;
            bsProductType = dbm.bsProduct_Type;
            bsProducts = dbm.bsProduct_s;
            bsPayMode = dbm.bsPayment_Mode;
            bsPay = dbm.bsPayment_s;
            bsStockProduct = dbmStock.bsProduct_s;
            dgvProductStock.DataSource = bsStockProduct;

           // dgvProductStock.DataSource = bsStockProduct;

            //calculate orderLToDetails tabs “Ltotal=Qty*UnitPrice”  
            dbm.DatabaseDataSet.Tables["OrderDetails"].Columns.Add("LTotal", System.Type.GetType("System.Double"));
            dbm.DatabaseDataSet.Tables["OrderDetails"].Columns["LTotal"].Expression = "Quantity*UnitPrice";

            //calculate Orders Table OrderTotal = sum(Orders2OrderDetails).LTotal 
            dbm.DatabaseDataSet.Tables["Orders"].Columns.Add("OrderTotal", System.Type.GetType("System.Double"));
            dbm.DatabaseDataSet.Tables["Orders"].Columns["OrderTotal"].Expression = "ISNull(sum(child(Orders2OrderDetails).LTotal),0)";

            //calculate Orders Table TotalDiscount=(OrderTotal*Discount)/100" 
            dbm.DatabaseDataSet.Tables["Orders"].Columns.Add("TotalDiscount", System.Type.GetType("System.Double"));
            dbm.DatabaseDataSet.Tables["Orders"].Columns["TotalDiscount"].Expression = "(OrderTotal*Discount)/100";

            //calculate Order Table: FinalTotal=OrderTotal-(OrderTotal*Discount)/100
            dbm.DatabaseDataSet.Tables["Orders"].Columns.Add("FinalTotal", System.Type.GetType("System.Double"));
            dbm.DatabaseDataSet.Tables["Orders"].Columns["FinalTotal"].Expression = "OrderTotal - Discount";

            //Calculate Paid Amount
            dbm.DatabaseDataSet.Tables["Orders"].Columns.Add("Paid", System.Type.GetType("System.Int32"));
            dbm.DatabaseDataSet.Tables["Orders"].Columns["Paid"].Expression = "ISNULL(sum(child(Orders2Payments).Amount),0)";

            //Calculate Due Amount
            dbm.DatabaseDataSet.Tables["Orders"].Columns.Add("Due", System.Type.GetType("System.Int32"));
            dbm.DatabaseDataSet.Tables["Orders"].Columns["Due"].Expression = "ISNULL(FinalTotal - Paid,0)";

            if (dbm.DatabaseDataSet != null)
            {
                //Vendors TAB
                cbVendorTypeID.DataSource = bsVendor_Type;
                cbVendorTypeID.DisplayMember = "VendorTypeNm";
                cbVendorTypeID.ValueMember = "VendorTypeId";
                lstVendors.DataSource = bsVendor_s;
                lstVendors.DisplayMember = "VendorNm";
                lstVendors.ValueMember = "VendorID";

                //Orders TAB

                lblVendorTypeNameOrder.DataBindings.Add(new Binding("Text", bsVendor_Type, "VendorTypeNm", true));
                lblVendorNameOrders.DataBindings.Add(new Binding("Text", bsVendor_s, "VendorNm", true));

                lblOrderTotalOrders.DataBindings.Add(new Binding("Text", bsOrders, "FinalTotal", true));

                tbOrderIDOrders.DataBindings.Add(new Binding("Text", bsOrders, "OrderId", true));
                dtpOrders.DataBindings.Add(new Binding("Value", bsOrders, "OrderDate", true));
                cbOrderStatusName.DataBindings.Add(new Binding("SelectedValue", bsOrders, "OrderStatusId", true));
                tbDiscount.DataBindings.Add(new Binding("Text", bsOrders, "Discount", true));

                cbOrderStatusName.DataSource = bsOrderstatus;
                cbOrderStatusName.DisplayMember = "OrderStatusName";
                cbOrderStatusName.ValueMember = "OrderStatusId";

                dgvOrders.DataSource = bsOrders;
                dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


                lblVTNameOD.DataBindings.Add(new Binding("Text", bsVendor_Type, "VendorTypeNm", true));
                lblVNameOD.DataBindings.Add(new Binding("Text", bsVendor_s, "VendorNm", true));

                lblOrderTotal_OD.DataBindings.Add(new Binding("Text", bsOrders, "FinalTotal", true));
             
                cbProductTypeName.DataSource = bsProductType;
                cbProductTypeName.DisplayMember = "ProductTypeNm";
                cbProductTypeName.ValueMember = "ProductTypeId";

                cbProductName.DataSource = bsProducts;
                cbProductName.DisplayMember = "ProductNm";
                cbProductName.ValueMember = "ProductId";

                tbOrderID_OD.DataBindings.Add(new Binding("Text", bsOrderDetails, "OrderId", true));
               // cbProductTypeName.DataBindings.Add(new Binding("SelectedValue", bsOrderDetails, "ProductTypeId", true));
                cbProductName.DataBindings.Add(new Binding("SelectedValue", bsOrderDetails, "ProductId", true));
                tbQuantity.DataBindings.Add(new Binding("Text", bsOrderDetails, "Quantity", true));
                tbUnitPrice.DataBindings.Add(new Binding("Text", bsOrderDetails, "UnitPrice", true));

                //data from products table
                tbStock_UnitPrice.DataBindings.Add(new Binding("Text", dbm.bsProduct_s, "ProductPrice", true));
                tbStock.DataBindings.Add(new Binding("Text", dbm.bsProduct_s, "Stock", true));
                tbStockMargin.DataBindings.Add(new Binding("Text", dbm.bsProduct_s, "Margin", true));
                lblCGSTOD.DataBindings.Add(new Binding("Text", dbm.bsProduct_Type, "C_GST", true));
                lblSGSTOD.DataBindings.Add(new Binding("Text", dbm.bsProduct_Type, "S_GST", true));


                dgvOrderDetails.DataSource = bsOrderDetails;
                dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                //Stock TAB
                btnRecieveProducts.DataBindings.Add(new Binding("Visible", bsOrders, "OrderStatusId", true));

                //Payments TAB
                lblOrderTotalPayment.DataBindings.Add(new Binding("Text", bsOrders, "FinalTotal", true));
                lblPaidPayment.DataBindings.Add(new Binding("Text", bsOrders, "Paid", true));
                lblDuePayment.DataBindings.Add(new Binding("Text", bsOrders, "Due", true));
                tbPaymentID.DataBindings.Add(new Binding("Text", bsPay, "PaymentId", true));
                dtpPayments.DataBindings.Add(new Binding("Value", bsPay, "PaymentDate", true));
                tbAmount_Payments.DataBindings.Add(new Binding("Text", bsPay, "Amount", true));
                tbDescription.DataBindings.Add(new Binding("Text", bsPay, "Description", true));
                cbPayMode.DataBindings.Add(new Binding("SelectedValue", bsPay, "PayModeId", true));
                tbOrderID_Payments.DataBindings.Add(new Binding("Text", bsPay, "OrderId", true));

                cbPayMode.DataSource = bsPayMode;
                cbPayMode.DisplayMember = "PayModeName";
                cbPayMode.ValueMember = "PayModeId";

                dgvPayments.DataSource = bsPay;
                dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            }
        }
        private void btnAddOrders_Click_1(object sender, EventArgs e)
        {
            tbOrderIDOrders.Text = dbm.AddNewData(bsOrders, "Orders", "OrderId");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            dbm.saveData(bsOrders, dbm.daOrder_s, "Orders");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dbm.DeleteData(bsOrders);
        }
     
        //OrderDetails
        private void btnADDOD_Click(object sender, EventArgs e)
        {
            dbm.AddNewData(bsOrderDetails, "OrderDetails", "OrderId");
        }
        private void btnSaveOD_Click(object sender, EventArgs e)
        {
            dbm.saveData(bsOrderDetails, dbm.daOrder_Details, "OrderDetails");
        }
        private void btnDeleteOD_Click(object sender, EventArgs e)
        {
            dbm.DeleteData(bsOrderDetails);
        }
    

        private void tbQuantity_TextChanged_1(object sender, EventArgs e)
        {
            if (tbQuantity.Text != "")
            {
                double stockMargin = double.Parse(tbStockMargin.Text);

                if (Convert.ToInt32(cbVendorTypeID.SelectedValue) == 2)
                {
                    double Stock_UnitPrice = double.Parse(tbStock_UnitPrice.Text);
                    tbUnitPrice.Text = Stock_UnitPrice.ToString();

                    double cgst = double.Parse(lblCGSTOD.Text);
                    double sgst = double.Parse(lblSGSTOD.Text);
                    double Price = double.Parse(tbUnitPrice.Text);
                    double GST = cgst + sgst;
                    tbUnitPrice.Text = (Price + (Price * GST / 100)).ToString();


                }
                else
                {
                    double Stock_UnitPrice = double.Parse(tbStock_UnitPrice.Text);
                    tbUnitPrice.Text = (Stock_UnitPrice + (Stock_UnitPrice * stockMargin) / 100).ToString();

                    double cgst = double.Parse(lblCGSTOD.Text);
                    double sgst = double.Parse(lblSGSTOD.Text);
                    double Price = double.Parse(tbUnitPrice.Text);
                    double GST = cgst + sgst;
                    tbUnitPrice.Text = (Price + (Price * GST / 100)).ToString();

                    double Quantity = double.Parse(tbQuantity.Text);
                    double stock = double.Parse(tbStock.Text);
                    if (Quantity > stock)
                    {
                        MessageBox.Show("Insufficient Stock...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbQuantity.Text = "";
                    }

                }
            }
        }
        private void btnPayment_ADD_Click(object sender, EventArgs e)
        {
            tbPaymentID.Text = dbm.AddNewData(bsPay, "Payments", "PaymentId");
        }
        private void btnPayment_SAVE_Click(object sender, EventArgs e)
        {
            dbm.saveData(bsPay, dbm.daPayment_s, "Payments");
        }
        private void btnPayment_DELETE_Click(object sender, EventArgs e)
        {
            dbm.DeleteData(bsPay);
        }

        private void btnRecieveProducts_Click(object sender, EventArgs e)
        {
            DataRowView OrderRV = (DataRowView)bsOrders.Current;
            DataRow OrderR = (DataRow)OrderRV.Row;

            if (Convert.ToInt32(OrderR["OrderStatusId"]) == 1)
            {
                int OldStock = 0; for (int i = 0; i < bsOrderDetails.Count; i++)
                {
                    DataRowView OrderDetailsRV = (DataRowView)bsOrderDetails.List[i];
                    DataRow OrderDetailsR = (DataRow)OrderDetailsRV.Row;
                    DataRowView StockRV = (DataRowView)dbmStock.bsProduct_s.List[i];
                    DataRow StockR = (DataRow)StockRV.Row; OldStock = Convert.ToInt32(StockR["Stock"]);
                    DataRowView VendorTypesRV = (DataRowView)dbm.bsVendorType.Current;
                    DataRow VendorTypesR = (DataRow)VendorTypesRV.Row;
                    switch (Convert.ToInt32(VendorTypesR["VendorTypeId"]))
                    {
                        case 1: StockR["Stock"] = OldStock - Convert.ToInt32(OrderDetailsR["Quantity"]);
                            OrderR["OrderStatusId"] = 2;
                            break;
                        case 2: 
                            StockR["Stock"] = OldStock + Convert.ToInt32(OrderDetailsR["Quantity"]);
                            OrderR["OrderStatusId"] = 2;
                            break;
                    }
                }
            }  
            //Update Stock In Table
            try
            {
                this.Validate();
                dbmStock.bsProduct_s.EndEdit();
                dbmStock.daProduct_s.Update(dbmStock.DatabaseDataSet, "Products");
                dbmStock.DatabaseDataSet.AcceptChanges();
                MessageBox.Show("Stock Updated Successfully...!!!!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Change Order Status As Pending
            OrderR["OrderStatusId"] = 2;
            try
            {
                this.Validate();
                dbm.bsOrder_s.EndEdit();
                dbm.daOrder_s.Update(dbm.DatabaseDataSet, "Orders");
                dbm.DatabaseDataSet.AcceptChanges();
                MessageBox.Show("Order Status Updated successfully...!!!!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnRecieveProducts.Visible = false; 
        }

        private void btnUpdateStatus_Click_1(object sender, EventArgs e)
        {
            DataRowView OrderRV = (DataRowView)bsOrders.Current;
            DataRow OrderR = (DataRow)OrderRV.Row;
            if (Convert.ToInt32(OrderR["Due"]) > 0)
            {
            }
            else
            {
                OrderR["OrderStatusId"] = 3;
            }
            try
            {
                this.Validate();
                dbm.bsOrder_s.EndEdit();
                dbm.daOrder_s.Update(dbm.DatabaseDataSet, "Orders");
                dbm.DatabaseDataSet.AcceptChanges();
                MessageBox.Show("Order Status Updated Successfully...!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnUpdateStatus.Visible = false;

        }
        private void tabOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            int value = (Convert.ToInt32(tabOrders.SelectedIndex));
            switch (value)
            {
                //Stock Tab is Selected
                case 3:
                    DataRowView rvVT = (DataRowView)dbm.bsVendorType.Current;
                    DataRow rVT = (DataRow)(rvVT.Row);
                    //Button Enable or Disable
                    DataRowView OrderRowview = (DataRowView)bsOrders.Current;
                    DataRow OrderRow = (DataRow)OrderRowview.Row;
                    switch (Convert.ToInt32(OrderRow["OrderStatusId"]))
                    {
                        case 1:
                            btnRecieveProducts.Visible = true; break;
                        case 2:
                            btnRecieveProducts.Visible = false; break;
                    }
                    // Update Stock
                    int materialCount = bsOrderDetails.Count;
                    dbmStock.bsProduct_s.RemoveFilter();
                    if ((int)materialCount > 0)
                    {
                        string filterStr;
                        DataRowView OrderDetailsRowview;
                        DataRow OrderDetailsRow;
                        OrderDetailsRowview = (DataRowView)bsOrderDetails.List[0];
                        OrderDetailsRow = (DataRow)OrderDetailsRowview.Row;
                        filterStr = "ProductId=" + OrderDetailsRow["ProductId"];
                        for (int i = 1; i < Convert.ToInt32(materialCount); i++)
                        {
                            OrderDetailsRowview = (DataRowView)bsOrderDetails.List[i];
                            OrderDetailsRow = (DataRow)OrderDetailsRowview.Row;
                            filterStr = filterStr + " OR ProductId=" + OrderDetailsRow["ProductId"];
                        }
                        bsStockProduct.Filter = filterStr;
                       // MessageBox.Show(filterStr);
                    }
                    break;
                case 4:
                    DataRowView OrderRV = (DataRowView)bsOrders.Current;
                    DataRow OrderR = (DataRow)OrderRV.Row;
                   // if ((int)OrderR["OrderStatusId"] == 3)
                        if (Convert.ToInt32(OrderR["OrderStatusId"]) == 3)
                    {
                        btnUpdateStatus.Visible = false;
                    }
                    else
                    {
                        btnUpdateStatus.Visible = true;
                    }
                    break;
                   default:
                    break;
            }
            dgvProductStock.DataSource = bsStockProduct;
            dgvProductStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //Generate Bill
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlCommand cmd2;
        SqlCommand cmd3;
        SqlCommand cmd4;
        SqlDataAdapter dr;

        private void btnbill_Click(object sender, EventArgs e)
        {
            if (tbAmount_Payments.Text != "")
            {
               // crv.Visible = true;
                cn.Open();
               
                DataTable dt = new DataTable();
                cmd1 = new SqlCommand("Select * from BillReportView where Orderid = '" + tbOrderID_OD.Text + "'", cn);
                dr = new SqlDataAdapter(cmd1);
                dr.Fill(dt);



                DataTable dt1 = new DataTable();
                cmd2 = new SqlCommand("Select * from Vendors where VendorNm = '" + lblVNameOD.Text + "'", cn);
                dr = new SqlDataAdapter(cmd2);
                dr.Fill(dt1);

             


                 DataTable dt2 = new DataTable();
                 cmd3 = new SqlCommand("Select * from Orders where Orderid = '" + tbOrderIDOrders.Text + "'", cn);
                  dr = new SqlDataAdapter(cmd3);
                  dr.Fill(dt2);


                DataTable dt3 = new DataTable();
                cmd4 = new SqlCommand("Select * from Payments where Paymentid = '" + tbPaymentID.Text + "'", cn);
                dr = new SqlDataAdapter(cmd4);
                dr.Fill(dt3);

                

                DataTable dt4 = new DataTable();
                cmd = new SqlCommand("Select * from PayModes where PayModeID = '" + cbPayMode.SelectedValue + "'", cn);
                dr = new SqlDataAdapter(cmd);
                dr.Fill(dt4);

                BillReport cr = new BillReport();
                cr.Database.Tables["BillReportView"].SetDataSource(dt);
                cr.Database.Tables["Vendors"].SetDataSource(dt1);
                cr.Database.Tables["Orders"].SetDataSource(dt2);
                cr.Database.Tables["Payments"].SetDataSource(dt3);
                cr.Database.Tables["PayModes"].SetDataSource(dt4);
                this.crv.ReportSource = cr;
            }
            else
            {
                MessageBox.Show("Please Complete Payment...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
}
              
    