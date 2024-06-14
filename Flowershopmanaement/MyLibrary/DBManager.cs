using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace MyLibrary 
{
public class DBManager 
{
public string connectionstring;
public SqlConnection dbconnection = null;
public DataSet DatabaseDataSet;
public SqlConnection con = null;
public SqlDataAdapter daVendorType = new SqlDataAdapter();
public SqlDataAdapter daVendors = new SqlDataAdapter();
public SqlDataAdapter daOrder_Details = new SqlDataAdapter();
public SqlDataAdapter daOrder_s = new SqlDataAdapter();
public SqlDataAdapter daOrder_Status = new SqlDataAdapter();
public SqlDataAdapter daProduct_Type = new SqlDataAdapter();
public SqlDataAdapter daProduct_s = new SqlDataAdapter();
public SqlDataAdapter daPayment_Mode = new SqlDataAdapter();
public SqlDataAdapter daPayment_s = new SqlDataAdapter();

public BindingSource bsVendorType = new BindingSource();
public BindingSource bsVendors = new BindingSource();
public BindingSource bsOrder_s = new BindingSource();
public BindingSource bsOrder_Details = new BindingSource();
public BindingSource bsOrder_Status = new BindingSource();
public BindingSource bsProduct_Type = new BindingSource();
public BindingSource bsProduct_s = new BindingSource();

public BindingSource bsPayment_Mode = new BindingSource();
public BindingSource bsPayment_s = new BindingSource();

public DBManager () 
{
connectionstring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saloni & Sayani\OneDrive\Documents\Visual Studio 2012\Projects\Flowershopmanaement\Flowershopmanaement\Database.mdf;Integrated Security=True";
dbconnection = new SqlConnection(connectionstring);
DatabaseDataSet = new DataSet();
DatabaseDataSet.Locale = System.Globalization.CultureInfo.InvariantCulture;
}
public void open()
{
Handleconnection();
}
public void close()
{
dbconnection.Close();
}
public void Handleconnection() 
{
if (dbconnection.State == ConnectionState.Open)
{
dbconnection.Close();
dbconnection.Open();
}
else if (dbconnection.State == ConnectionState.Closed)
{
dbconnection.Open();
}
else 
{
dbconnection.Close();
dbconnection.Open();
}
}
#region Create Data Adapter
public SqlDataAdapter createDataAdapter(string tableName)
{
SqlDataAdapter adapter = new SqlDataAdapter();
adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
try 
{
string cmd = string.Format("SELECT * FROM {0}", tableName);
adapter.SelectCommand = new SqlCommand(cmd, dbconnection);
adapter.SelectCommand.Connection = dbconnection;
SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
adapter.UpdateCommand = Builder.GetUpdateCommand();
adapter.DeleteCommand = Builder.GetDeleteCommand();
adapter.InsertCommand = Builder.GetInsertCommand();
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message, "Exception at command creation");
}
return adapter;
}
public void cdaVendorType(){
daVendorType = createDataAdapter("VendorTypes");
daVendorType.Fill(DatabaseDataSet, "VendorTypes");
bsVendorType = new BindingSource(DatabaseDataSet,"VendorTypes");
}
public void cdaVendors() {
daVendors = createDataAdapter("Vendors");
daVendors.Fill(DatabaseDataSet, "Vendors");
bsVendors = new BindingSource(DatabaseDataSet, "Vendors");
}
public void cdaOrderStatus()
{
    daOrder_Status = createDataAdapter("OrderStatus");
    daOrder_Status.Fill(DatabaseDataSet, "OrderStatus");
    bsOrder_Status = new BindingSource(DatabaseDataSet, "OrderStatus");
}
public void cdaOrders()
{
    daOrder_s = createDataAdapter("Orders");
    daOrder_s.Fill(DatabaseDataSet, "Orders");
    bsOrder_s = new BindingSource(DatabaseDataSet, "Orders");
}
public void cdaOrderDetails()
{
    daOrder_Details = createDataAdapter("OrderDetails");
    daOrder_Details.Fill(DatabaseDataSet, "OrderDetails");
    bsOrder_Details = new BindingSource(DatabaseDataSet, "OrderDetails");
}
public void cdaProductType()
{
    daProduct_Type = createDataAdapter("ProductTypes");
    daProduct_Type.Fill(DatabaseDataSet, "ProductTypes");
    bsProduct_Type = new BindingSource(DatabaseDataSet, "ProductTypes");
}
public void cdaProducts()
{
    daProduct_s = createDataAdapter("Products");
    daProduct_s.Fill(DatabaseDataSet, "Products");
    bsProduct_s = new BindingSource(DatabaseDataSet, "Products");
}
public void cdaPaymentMode()
{
    daPayment_Mode = createDataAdapter("PayModes");
    daPayment_Mode.Fill(DatabaseDataSet, "PayModes");
    bsPayment_Mode = new BindingSource(DatabaseDataSet, "PayModes");
}
public void cdaPayment()
{
  daPayment_s = createDataAdapter("Payments");
   daPayment_s.Fill(DatabaseDataSet, "Payments");
    bsPayment_s = new BindingSource(DatabaseDataSet, "Payments");
}




#endregion
#region Relation
public string CreateRelation(string ParentTable, string ChildTable, string ColumnName) 
{
string relationName = string.Concat(ParentTable, "2", ChildTable);
DatabaseDataSet.Relations.Add(relationName,
DatabaseDataSet.Tables[ParentTable].Columns[ColumnName],
DatabaseDataSet.Tables[ChildTable].Columns[ColumnName]);
return relationName;
}
public void RemoveRelation(string relationName)
{
DatabaseDataSet.Relations.Remove(relationName);
}
public BindingSource GetRelationBS(string relationName, BindingSource bsMaster)
{
BindingSource bs = new BindingSource(bsMaster, relationName);
return bs;
}
public string crVendorType_Vendors()
{
string r1 = CreateRelation("VendorTypes", "Vendors", "VendorTypeId");
bsVendors = GetRelationBS(r1, bsVendorType);
return r1;
}
public string crVendors_Orders()
{
    string r2 = CreateRelation("Vendors", "Orders", "VendorID");
    bsOrder_s = GetRelationBS(r2, bsVendors);
    return r2;
}
public string crOrders_OrderDetails()
{
    string r3 = CreateRelation("Orders", "OrderDetails", "OrderId");
    bsOrder_Details = GetRelationBS(r3, bsOrder_s);
    return r3;
}
public string crProductType_Products()
{
    string r4 = CreateRelation("ProductTypes", "Products","ProductTypeId");
    bsProduct_s = GetRelationBS(r4, bsProduct_Type);
    return r4;
}
public string crOrders_Payment()
{
    string r5 = CreateRelation("Orders", "Payments", "OrderId");
    bsPayment_s = GetRelationBS(r5, bsOrder_s);
    return r5;
}

#endregion
#region Utils
public int GetNextID(string TableName, string Primarykey)
{
int NextId = 0;
try 
{
DataSet ds = new DataSet();
SqlDataAdapter da = new SqlDataAdapter();
da = createDataAdapter(TableName);
da.Fill(ds, TableName);
DataTable Table = ds.Tables[TableName];
DataView Row = Table.DefaultView;
string qry = string.Format("max({0})", Primarykey);
NextId = Convert.ToInt32(Table.Compute(qry, " "));
}
catch (Exception ex) {
MessageBox.Show(ex.ToString());
}
return NextId + 1;
}
public void RejectChanges() {
MessageBox.Show("Changes Rejectes!!");
}
#endregion
#region validation
public bool charactorValidation(char ch) 
{
if (ch == '\b' || ch == (char)32) { }
else
{
if ((ch < (char)65 || ch > (char)90) & (ch < (char)97 || ch > (char)122))
{
MessageBox.Show("Enter charactor only", "Charactorvalidation", MessageBoxButtons.OK, MessageBoxIcon.Error);
return true;
}
else {
return false;
}
}
return false;
}
public bool NumberValitadion(char ch)
{
if (ch != '\b')
{
}
else 
{
if (ch < (char)48 || ch > (char)57) 
{
MessageBox.Show("Enter digit number only", "Digitalvalidation", MessageBoxButtons.OK, MessageBoxIcon.Information);
return true;
}
else
{
return false;
}
}
return false;
}
#endregion
public String AddNewData(BindingSource bs, String tblName, String primaryKey)
{
bs.AddNew();
return GetNextID(tblName, primaryKey).ToString();
}
public void saveData(BindingSource bsVendors, SqlDataAdapter daVendors, String tblName)
{
BindingSource bs = bsVendors;
SqlDataAdapter da = daVendors;
try
{
bs.EndEdit();
da.Update(DatabaseDataSet, tblName);
DatabaseDataSet.AcceptChanges();
MessageBox.Show("Record Save Sucessfully...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
bs.MoveLast();
}
catch (Exception ex)
{
bs.RemoveCurrent();
MessageBox.Show(ex.ToString());
}
}
public void bsProductType()
{
throw new NotImplementedException();
}
public void DeleteData(BindingSource bsVendors)
{
BindingSource bs = bsVendors;
try
{
bs.RemoveCurrent();
MessageBox.Show("Record delete Sucessfully...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
bs.MoveLast();
}
catch (Exception ex){
MessageBox.Show(ex.ToString());
}
}
}
}

