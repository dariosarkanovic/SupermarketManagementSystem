using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class Selling : Form, IDataConnection
    {
        private string s;
        public Selling(string sellerName)
        {
            s = sellerName;
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Supermarket;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void Selling_Load(object sender, EventArgs e)
        {
            
            DisplayDataFromDB("Bill");
            fillComboBox();
            DisplayDataFromDB("Product");
            SellerNameLabel.Text = s;
        }

        public void DisplayDataFromDB(string nameDB)
        {
            string query = "";
            if(nameDB == "Product")
            {
                 query = $"SELECT ProdName, ProdPrice FROM dbo.{nameDB}";
            }
            else if(nameDB == "Bill")
            {
                 query = $"SELECT * FROM dbo.{nameDB}";
            }
            else
            {
                MessageBox.Show("Can't find Database.");
                return;
            }
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder cmd = new SqlCommandBuilder(dataAdapter);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataGrid.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTextBox.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            PriceTextBox.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToShortDateString();
        }

        double orderTotal = 0;
        int n = 0;
        private void AddProdButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || PriceTextBox.Text == "" || QuantityTextBox.Text == "")
            {
                MessageBox.Show("Missing data!");
            }
            else
            {
                string t = PriceTextBox.Text.ToString();
                if (PriceTextBox.Text.ToString().Contains('.'))
                {
                     t = PriceTextBox.Text.ToString().Replace('.', ',');
                }
                
                double total = Convert.ToDouble(t) * Convert.ToInt32(QuantityTextBox.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(OrderData);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = NameTextBox.Text;
                newRow.Cells[2].Value = PriceTextBox.Text;
                newRow.Cells[3].Value = QuantityTextBox.Text;
                newRow.Cells[4].Value = total;
                n++;
                OrderData.Rows.Add(newRow);
                
                orderTotal += total;
                TotalLabel.Text = $"{orderTotal}";

                QuantityTextBox.Text = "";
                IDTextBox.Text = "";
                NameTextBox.Text = "";
                PriceTextBox.Text = "";
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int id = 0;
            if(!int.TryParse(IDTextBox.Text, out id))
            {
                MessageBox.Show("Invalid ID");
            }
            else { 
                try
                {
                    List<int> listOfBillIDs = ListOfBillIDs();
                    int sameBillIDIndex = listOfBillIDs.FindIndex(x => x == id);
                    if(sameBillIDIndex != -1)
                    {
                        MessageBox.Show("Entered ID alredy exists.");
                    }
                    else
                    {
                        string tot = TotalLabel.Text.ToString();
                        double d = Convert.ToDouble(tot);
                        if (TotalLabel.Text.ToString().Contains(','))
                        {
                            tot = String.Format("{0:0.00}", d);
                        }

                        connection.Open();
                        string insertQuery = $@"INSERT INTO dbo.Bill 
                            VALUES({id}, '{SellerNameLabel.Text}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{tot}')";
                        SqlCommand cmd = new SqlCommand(insertQuery, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Order added successfully!");
                        connection.Close();
                        DisplayDataFromDB("Bill");

                        int numOfRows = OrderData.RowCount - 1;
                        connection.Open();

                        for (int i = 0; i < numOfRows; i++)
                        {
                            string prodName = OrderData.Rows[i].Cells[1].Value.ToString();
                            int prodQuantity = Convert.ToInt32(OrderData.Rows[i].Cells[3].Value.ToString());
                            string t = OrderData.Rows[i].Cells[2].Value.ToString();
                            double prodPrice = Convert.ToDouble(t);
                            if (t.Contains(','))
                            {
                                t = String.Format("{0:0.00}", prodPrice);
                            }

                            string insert = $@"USE Supermarket
                            insert into dbo.Orders  
                            VALUES('{prodName}', {prodQuantity}, '{t}', {id})";
                            SqlCommand cmd2 = new SqlCommand(insert, connection);
                            cmd2.ExecuteNonQuery();

                        }
                        connection.Close();

                        OrderData.Rows.Clear();
                        orderTotal = 0;
                        n = 0;
                        IDTextBox.Text = "";
                        TotalLabel.Text = "Total"; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        List<int> ListOfBillIDs()
        {
            string query = "SELECT * FROM dbo.Bill";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable billTable = dataSet.Tables[0];
            List<int> billIDs = new List<int>();
            foreach (DataRow row in billTable.Rows)
            {
                billIDs.Add(Convert.ToInt32(row["ID"]));
            }

            return billIDs;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if (!int.TryParse(IDTextBox.Text, out id))
                {
                    MessageBox.Show("Select the ID of Bill to Delete");
                }
                else
                {
                    connection.Open();
                    //delete order bill from Orders table.
                    string deleteOrderQuery = $"DELETE FROM dbo.Orders WHERE BillID={id}";
                    SqlCommand cmd1 = new SqlCommand(deleteOrderQuery, connection);
                    cmd1.ExecuteNonQuery();
                    
                    //delete bill from Bill table
                    string deleteQuery = $"DELETE FROM dbo.Bill WHERE ID={id}";
                    SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected Bill deleted successfully.");
                    connection.Close();

                    //refresh DataGrid display
                    DisplayDataFromDB("Bill");
                    IDTextBox.Text = "";
                    NameTextBox.Text = "";
                    QuantityTextBox.Text = "";
                    PriceTextBox.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void BillDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTextBox.Text = BillDataGrid.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void SelectCategoryComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = $"SELECT ProdName, ProdPrice FROM dbo.Product WHERE ProdCategory='{SelectCategoryComboBox.SelectedValue.ToString()}'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataGrid.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void fillComboBox()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM dbo.Category", connection);
            SqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Load(dataReader);
            SelectCategoryComboBox.ValueMember = "Name";
            SelectCategoryComboBox.DataSource = dt;
            connection.Close();

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DisplayDataFromDB("Product");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int axisY = 240;
            int billID = Convert.ToInt32(IDTextBox.Text.ToString());//Convert.ToInt32(BillDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            e.Graphics.DrawString("MySupermarket", new Font("Segui UI", 25, FontStyle.Bold),Brushes.CadetBlue, new Point(280, 20));
            e.Graphics.DrawString("Bill ID: " + BillDataGrid.SelectedRows[0].Cells[0].Value.ToString(), new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(70, 150));
            e.Graphics.DrawString("Seller: " + BillDataGrid.SelectedRows[0].Cells[1].Value.ToString(), new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(70, 180));
            e.Graphics.DrawString("Created: " + BillDataGrid.SelectedRows[0].Cells[2].Value.ToString().Substring(0,11), new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(70, 210));
            e.Graphics.DrawString("Product", new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(70, 240));
            e.Graphics.DrawString("Quantity", new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(200, 240));
            e.Graphics.DrawString("Price for one product", new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(330, 240));
            
            //getting data from Orders table for selected bill in DataGridView
            string query = $"SELECT * FROM dbo.Orders WHERE BillID={billID}";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataTable ordersDataTable = dataSet.Tables[0];

            //display data from selected bill on printDocument
            foreach(DataRow row in ordersDataTable.Rows)
            {
                e.Graphics.DrawString(row["ProdName"].ToString(), new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(70, axisY += 30));
                e.Graphics.DrawString(row["ProdQuantity"].ToString(), new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(200, axisY));
                e.Graphics.DrawString(row["ProdPrice"].ToString(), new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(330, axisY));
            }
            connection.Close();


            e.Graphics.DrawString("Total Amount: " + BillDataGrid.SelectedRows[0].Cells[3].Value.ToString() + "$", new Font("Segui UI", 15, FontStyle.Bold), Brushes.Black, new Point(70, axisY += 30));
            
            //random generated Barcode Image from web.
            Image img = Image.FromFile(@"D:\DESKTOP\DarioBarcode.gif");
            e.Graphics.DrawImage(img,new Point(320, axisY += 30));
            
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void Selling_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
