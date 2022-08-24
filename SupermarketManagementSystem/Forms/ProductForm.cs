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
    public partial class ProductForm : Form, IDataConnection
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Supermarket;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillComboBox();
            DisplayDataFromDB("Product");
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
            SelectCategoryComboBox2.ValueMember = "Name";
            SelectCategoryComboBox2.DataSource = dt;
            connection.Close();

        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm catForm = new CategoryForm();
            catForm.Show();
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if(!int.TryParse(IDTextBox.Text, out id))
                {
                    MessageBox.Show("Invalid ID");
                }
                else
                {
                    connection.Open();
                    string price = PriceTextBox.Text.ToString();
                    List<int> listOfProductIDs = Globalization.ListOfIDFromDB("Product");
                    int sameProductIDindex = listOfProductIDs.FindIndex(x => x == Convert.ToInt32(IDTextBox.Text));

                    if (sameProductIDindex != -1)
                    {
                        MessageBox.Show("Entered ID for product alredy exists.");
                        connection.Close();
                    }
                    else
                    {
                        if (price.Contains(','))
                        {
                            price = String.Format("{0:0.00}", Convert.ToDouble(price));
                        }
                        string insertQuery = $@"INSERT INTO dbo.Product 
                            VALUES({id}, '{NameTextBox.Text}', {QuantityTextBox.Text}, '{SelectCategoryComboBox.SelectedValue.ToString()}', '{price}')";
                        SqlCommand cmd = new SqlCommand(insertQuery, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully!");
                        connection.Close();

                        DisplayDataFromDB("Product");
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        public void DisplayDataFromDB(string nameDB)
        {
            connection.Open();
            string query = $"SELECT * FROM dbo.{nameDB}";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataGrid.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if (!int.TryParse(IDTextBox.Text, out id))
                {
                    MessageBox.Show("Select the ID of Product to Delete.");
                }
                else
                {
                    connection.Open();
                    string deleteQuery = $"DELETE FROM dbo.Product WHERE ProdID={id}";
                    SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected product deleted successfully.");
                    connection.Close();

                    DisplayDataFromDB("Product");
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

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTextBox.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            NameTextBox.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            QuantityTextBox.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            PriceTextBox.Text = DataGrid.SelectedRows[0].Cells[4].Value.ToString();
            SelectCategoryComboBox.SelectedValue = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void SelectCategoryComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM dbo.Product WHERE ProdCategory='{SelectCategoryComboBox2.SelectedValue.ToString()}'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataGrid.DataSource = dataSet.Tables[0];
            connection.Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                if (IDTextBox.Text == "" || NameTextBox.Text == "" || QuantityTextBox.Text == "" || PriceTextBox.Text == "")
                {
                    MessageBox.Show("Missing informations.");
                }
                else if(!int.TryParse(IDTextBox.Text, out id))
                {
                    MessageBox.Show("Invalid ID");
                }
                else
                {
                    connection.Open();
                    string updateQuery = $@"UPDATE dbo.Product SET ProdName='{NameTextBox.Text}',
                            ProdQuantity={QuantityTextBox.Text}, ProdPrice={PriceTextBox.Text},
                            ProdCategory='{SelectCategoryComboBox.SelectedValue}' WHERE ID={IDTextBox.Text}";
                    SqlCommand cmd = new SqlCommand(updateQuery, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected product successfully updated.");
                    connection.Close();

                    DisplayDataFromDB("Product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            DisplayDataFromDB("Product");
        }

        private void SellerButton_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
