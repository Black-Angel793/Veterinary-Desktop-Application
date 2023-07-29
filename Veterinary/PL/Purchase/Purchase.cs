using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinary.ML;
using static System.Net.WebRequestMethods;

namespace Veterinary.PL.Purchase
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        ML.CRUD crud = new ML.CRUD();
        DataTable dtc = new DataTable();
        DataTable dtb = new DataTable();
        DataTable productTable = new DataTable();

        string productIds = string.Empty;
        string quantities = string.Empty;
        string costs = string.Empty;

        decimal totalCost = 0;

        private int selectedProductId;

        private void Purchase_Load(object sender, EventArgs e)
        {

            productTable.Columns.Add("Product ID", typeof(int));
            productTable.Columns.Add("Product Name", typeof(string));
            productTable.Columns.Add("Quantity", typeof(int));
            productTable.Columns.Add("Price", typeof(float));
            productTable.Columns.Add("Cost", typeof(float));


            // Set the DataTable as the data source for the DataGridView
            DataGridViewProducts.DataSource = productTable;

            DataTable dtp = new DataTable();
            dtp = crud.list_products();
            foreach (DataRow dr in dtp.Rows)
            {
                string productId = $"{dr["Id_product"].ToString()}";
                string productName = $"{dr["Product_Name"].ToString()}";

                string productInfo = $"{productId}: {productName} ";
                products.Items.Add(productInfo);
            }


            dtc = crud.list_owner();
            if (dtc.Rows.Count > 0)
            {
                DataGridViewClient.DataSource = dtc;

                //Datagridview Header 
                DataGridViewClient.Columns[0].HeaderText = "Identification";
                DataGridViewClient.Columns[1].HeaderText = "First Name";
                DataGridViewClient.Columns[2].HeaderText = "Last Name";
                DataGridViewClient.Columns[5].HeaderText = "Address";
                DataGridViewClient.Columns[6].HeaderText = "Phone Number";
            }
            else
            {
                MessageBox.Show("List est Vide ");
            }

            dtb = crud.list_orders();
            if (dtb.Rows.Count > 0)
            {
                DataGridViewResult.DataSource = dtb;

                //Datagridview Header 
                DataGridViewResult.Columns[0].HeaderText = "Order ID";
                DataGridViewResult.Columns[1].HeaderText = "Order Date";
                DataGridViewResult.Columns[2].HeaderText = "Owner ID";
                DataGridViewResult.Columns[3].HeaderText = "Product ID";
                DataGridViewResult.Columns[4].HeaderText = "Product Name";
                DataGridViewResult.Columns[5].HeaderText = "Price";
                DataGridViewResult.Columns[6].HeaderText = "Quantity Ordered";
                DataGridViewResult.Columns[7].HeaderText = "Cost of each product";
            }
            else
            {
                MessageBox.Show("List est Vide ");
            }
        }

        HashSet<string> selectedProducts = new HashSet<string>();

        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (products.SelectedIndex != -1)
            {
                string selectedProductInfo = products.SelectedItem.ToString();
                string[] productInfoParts = selectedProductInfo.Split(':');

                string selectedProductId = productInfoParts[0].Trim();
                DataTable dtSelectedProduct;
                int productId;
                if (int.TryParse(selectedProductId, out productId))
                {
                    dtSelectedProduct = crud.GetProductByID(selectedProductId);

                    // Retrieve the price from the DataTable
                    decimal productPrice = Convert.ToDecimal(dtSelectedProduct.Rows[0]["price"]);

                    // Display the price in the TextBox
                    price.Text = productPrice.ToString();


                    // Add the selected product ID to the HashSet
                    selectedProducts.Add(selectedProductId);
                }
                else
                {
                    // Product already selected, display a message or perform other actions
                    MessageBox.Show("Ce produit est déjà sélectionné");
                }
                DataGridViewProducts.SelectAll();
            }

        }
        private void addproductbtn_Click(object sender, EventArgs e)
        {
            // Retrieve the selected product, quantity, and cost
            string productName = products.Text;
            int quantity = Convert.ToInt32(qt.Text);
            decimal productPrice = Convert.ToDecimal(price.Text);
            decimal cost = quantity * productPrice;
            int productId;

            totalCost += cost;

            TotalCost.Text = totalCost.ToString();

            if (DataGridViewProducts.SelectedRows.Count>0 && DataGridViewProducts.SelectedRows[0].Cells["Product ID"].Value != null)
            {
                // Get ID from selected row
                productId = (int)DataGridViewProducts.SelectedRows[0].Cells["Product ID"].Value;

                DataColumn idColumn = productTable.Columns["Product ID"];
                productTable.PrimaryKey = new DataColumn[] { idColumn };
                DataRow row = productTable.Rows.Find(productId);

                if (row != null)
                {
                    int currQty = row.Field<int>("Quantity");
                    currQty = quantity;
                    row["Quantity"] = currQty;

                    float currCost = row.Field<float>("Cost");
                    currCost = ((float)cost);
                    row["Cost"] = currCost;
                }
            }
            else
            {
                productId = Convert.ToInt32(products.SelectedIndex) + 1;

                productTable.Rows.Add(productId, productName, quantity, productPrice, cost);
            }
        
        // Refresh grid
            DataGridViewProducts.DataSource = productTable;
            DataGridViewProducts.Update();
            DataGridViewProducts.Refresh();

            // Clear the input fields for the next entry
            products.SelectedIndex = -1;
            qt.Clear();
            price.Clear();

        }
        private void addbtn_Click(object sender, EventArgs e)
        {            
            foreach (DataGridViewRow row in DataGridViewProducts.Rows)
            {
                if (row.Cells["Product ID"].Value != null)
                {
                    string productId = row.Cells["Product ID"].Value.ToString();
                    string quantity = row.Cells["Quantity"].Value.ToString();
                    decimal cost = Convert.ToDecimal(row.Cells["Cost"].Value.ToString());

                    productIds += productId + ",";
                    quantities += quantity + ",";
                    costs += cost.ToString() + ",";

                }
            }

            // Remove the trailing comma
            if (!string.IsNullOrEmpty(productIds))
            {
                productIds = productIds.TrimEnd(',');
                quantities = quantities.TrimEnd(',');
                costs = costs.TrimEnd(',');

                try
                {
                    crud.insert_order(int.Parse(id_c.Text),productIds, quantities,costs); 
                    
                    MessageBox.Show("Commande complétée");

                    dtb = crud.list_orders();
                         
                    DataGridViewResult.DataSource = dtb;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (DataGridViewResult.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataGridViewProducts.Rows)
                {
                    if (row.Cells["Product ID"].Value != null)
                    {
                        string productId = row.Cells["Product ID"].Value.ToString();
                        string quantity = row.Cells["Quantity"].Value.ToString();
                        decimal cost = Convert.ToDecimal(row.Cells["Cost"].Value.ToString());

                        productIds += productId + ",";
                        quantities += quantity + ",";
                        costs += cost.ToString() + ",";

                    }
                }
                // Remove the trailing comma
                if (!string.IsNullOrEmpty(productIds))
                {
                    productIds = productIds.TrimEnd(',');
                    quantities = quantities.TrimEnd(',');
                    costs = costs.TrimEnd(',');

                    try
                    {
                        crud.update_order(int.Parse(id_o.Text), productIds, quantities,costs);

                        MessageBox.Show("Commande mise à jour");

                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    dtb = crud.list_orders();

                    DataGridViewResult.DataSource = dtb;
                }
            }
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Êtes-vous sûr(e) de vouloir supprimer cette commande ?", "Supprimé", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    crud.delete_order(int.Parse(id_o.Text));
                    MessageBox.Show("supprimé avec succès !!!");
                    dtb = crud.list_orders();
                    DataGridViewResult.DataSource = dtb;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Return_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Close();
        }
        private void DataGridViewProducts_Click(object sender, EventArgs e)
        {
            if (DataGridViewProducts.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                selectedProductId = (int)DataGridViewProducts.CurrentRow.Cells["Product ID"].Value;
                products.Text = DataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
                qt.Text = DataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
                price.Text = DataGridViewProducts.CurrentRow.Cells[3].Value.ToString();

            }
        }
        private void DataGridViewClient_Click(object sender, EventArgs e)
        {
            if (DataGridViewClient.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                id_c.Text = DataGridViewClient.CurrentRow.Cells[0].Value.ToString();
            }
        }
        private void DataGridViewResult_Click(object sender, EventArgs e)
        {
            if (DataGridViewResult.SelectedRows.Count > 1)
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
            else
            {
                id_o.Text = DataGridViewResult.CurrentRow.Cells[0].Value.ToString();
                id_c.Text = DataGridViewClient.CurrentRow.Cells[1].Value.ToString();

                // Get selected row
                DataGridViewRow selectedRow = DataGridViewResult.SelectedRows[0];

                // Get order id
                int orderId = (int)selectedRow.Cells["Id_order"].Value;

                // Query details
                DataTable details = crud.GetOrderDetails(orderId);

                // Populate product table 
                productTable.Clear();
                foreach (DataRow row1 in details.Rows)
                {
                    // Add product data to new row
                    DataRow newRow = productTable.NewRow();
                    newRow["Product ID"] = row1["Id_product"];
                    newRow["Product Name"] = row1["Product_Name"];
                    newRow["Quantity"] = row1["QT"];
                    newRow["Price"] = row1["Price"];
                    newRow["Cost"] = row1["Cost"];

                    productTable.Rows.Add(newRow);
                }
            }
        }

    }
}



















// Check if row for this ID is selected
//int? productId = (int?)DataGridViewProducts.CurrentRow?.Cells["Product ID"].Value;
//bool isUpdate = productId != 0;
//MessageBox.Show(isUpdate.ToString());
//if (productId != null)
//{
//productId = selectedProductId;
//}
//else
//{
// No selection, add new row
//int productId = Convert.ToInt32(products.SelectedIndex )+ 1;
// }
/* totalCost += cost;

 TotalCost.Text = totalCost.ToString();

 DataColumn idColumn = productTable.Columns["Product ID"];
 productTable.PrimaryKey = new DataColumn[] { idColumn };
 DataRow row = productTable.Rows.Find(productId);

 if (row != null)
 {
     int currQty = row.Field<int>("Quantity");
     currQty = quantity;
     row["Quantity"] = currQty;

     float currCost = row.Field<float>("Cost");
     currCost = ((float)cost);
     row["Cost"] = currCost;
 }
 else
 {
     productTable.Rows.Add(productId, productName, quantity, productPrice, cost);
 }*/









/*if (DataGridViewResult.SelectedRows != null && DataGridViewResult.SelectedRows.Count > 0)
{
    // Get selected row
    DataGridViewRow selectedRow = DataGridViewResult.SelectedRows[0];

    // Get order id
    int orderId = (int)selectedRow.Cells["Id_order"].Value;

    // Query details
    DataTable details = crud.GetOrderDetails(orderId);

    // Populate product table 
    productTable.Clear();
    foreach (DataRow row1 in details.Rows)
    {
        // Add product data to new row
        DataRow newRow = productTable.NewRow();
        newRow["Product ID"] = row1["Id_product"];
        newRow["Product Name"] = row1["Product_Name"];
        newRow["Quantity"] = row1["QT"];
        newRow["Price"] = row1["Price"];
        newRow["Cost"] = row1["Cost"];

        productTable.Rows.Add(newRow);
    }
}*/