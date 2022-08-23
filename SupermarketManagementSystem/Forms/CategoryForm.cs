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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Supermarket;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (!Validation())
                {
                    connection.Close();
                }
                else
                {
                    string insertQuery = $@"INSERT INTO dbo.Category 
                    VALUES({IDTextBox.Text}, '{NameTextBox.Text}', '{DescriptionTextBox.Text}')";
                    SqlCommand cmd = new SqlCommand(insertQuery, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category added successfully!");
                    connection.Close();
                    DisplayDataFromDB("Category");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private bool Validation()
        {
            if (IDTextBox.Text == "" || NameTextBox.Text == "")
            {
                MessageBox.Show($"Enter ID and Name for Category");
                connection.Close();
                return false;
            }
            
                List<string> categoryNames = ListOfCategoryNames();
                int sameNameIndex = categoryNames.FindIndex(x => x.ToLower() == NameTextBox.Text.ToString().ToLower());
                List<int> categoryIDs = ListOfCategoryIDs();
                int sameIDIndex = categoryIDs.FindIndex(x => x == Convert.ToInt32(IDTextBox.Text));

                if (sameNameIndex != -1)
                {
                    MessageBox.Show($@"Category ""{NameTextBox.Text.ToString()}"" alredy exist.");
                    connection.Close();
                    return false;
                }
                else if (sameIDIndex != -1)
                {
                    MessageBox.Show($"Entered ID for category alredy exists.");
                    connection.Close();
                    return false;
                }
            return true;
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            DisplayDataFromDB("Category");
        }

        private void DisplayDataFromDB(string nameDB)
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

      
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTextBox.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            NameTextBox.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            DescriptionTextBox.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDTextBox.Text == "")
                {
                    MessageBox.Show("Select the Category to Delete.");
                }
                else
                {
                    var result = MessageBox.Show("If you delete category, all products within this category will be deleted also.", "Warning", MessageBoxButtons.OKCancel);
                    
                    if(result == DialogResult.OK) {
                        connection.Open();
                        string deleteQuery = $"DELETE FROM dbo.Category WHERE ID={IDTextBox.Text}";
                        SqlCommand cmd = new SqlCommand(deleteQuery, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Selected category deleted successfully.");

                        string deleteProductQuery = $"DELETE FROM dbo.Product WHERE ProdCategory='{NameTextBox.Text}'";
                        SqlCommand cmd1 = new SqlCommand(deleteProductQuery, connection);
                        cmd1.ExecuteNonQuery();

                        connection.Close();
                        DisplayDataFromDB("Category");
                        IDTextBox.Text = "";
                        NameTextBox.Text = "";
                        DescriptionTextBox.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
        List<string> ListOfCategoryNames()
        {
            string query = "SELECT * FROM dbo.Category";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable categoryTable = dataSet.Tables[0];
            List<string> categoryNames = new List<string>();
            foreach (DataRow row in categoryTable.Rows)
            {
                categoryNames.Add(row["Name"].ToString());
            }

            return categoryNames;
        }

        List<int> ListOfCategoryIDs()
        {
            string query = "SELECT * FROM dbo.Category";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adapter);
            var dataSet = new DataSet();
            adapter.Fill(dataSet);
            DataTable categoryTable = dataSet.Tables[0];
            List<int> categoryIDs = new List<int>();
            foreach (DataRow row in categoryTable.Rows)
            {
                categoryIDs.Add(Convert.ToInt32(row["ID"]));
            }

            return categoryIDs;
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(IDTextBox.Text == "" || NameTextBox.Text == "")
                {
                    MessageBox.Show("Missing informations.");
                }
                else { 
                    connection.Open();

                    List<string> categoryNames = ListOfCategoryNames();
                    
                    int index = categoryNames.FindIndex(x => x.ToLower() == NameTextBox.Text.ToString().ToLower());
                    
                    if (index != -1)
                    {
                        MessageBox.Show($@"Category ""{NameTextBox.Text.ToString()}"" alredy exist.");
                    }
                    else
                    {
                        string updateQuery = $@"UPDATE dbo.Category SET Name='{NameTextBox.Text}', 
                                Description='{DescriptionTextBox.Text}' WHERE ID={IDTextBox.Text}";
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Selected product successfully updated.");

                        string updateProduct = $@"UPDATE dbo.Product SET ProdCategory='{NameTextBox.Text}'
                                   WHERE ProdCategory='{DataGrid.SelectedRows[0].Cells[1].Value.ToString()}'";
                        SqlCommand cmd1 = new SqlCommand(updateProduct, connection);
                        cmd1.ExecuteNonQuery();
                    }

                    connection.Close();
                    DisplayDataFromDB("Category");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm();
            prodForm.Show();
            this.Hide();
        }

        private void SellerButton_Click(object sender, EventArgs e)
        {
            SellerForm sellerForm = new SellerForm();
            sellerForm.Show();
            this.Hide();
        }

        private void CategoryForm_FormClosing(object sender, FormClosingEventArgs e)
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
