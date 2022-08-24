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
    public partial class SellerForm : Form, IDataConnection
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Supermarket;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
      
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = 0;
                if (!int.TryParse(IDTextBox.Text, out id)) {
                    MessageBox.Show("Invalid ID");
                    //connection.Close();
                }
                else
                {
                    connection.Open();
                    List<int> listOfSellersIDs = Globalization.ListOfIDFromDB("Seller");
                    int sameSellerIDIndex = listOfSellersIDs.FindIndex(x => x == id);
                    if (sameSellerIDIndex != -1)
                    {
                        MessageBox.Show("Entered ID alredy exists.");
                        connection.Close();
                    }
                    else if (!Validation())
                    {
                        connection.Close();
                    }
                    else
                    {
                        string insertQuery = $@"INSERT INTO dbo.Seller 
                        VALUES({IDTextBox.Text}, '{NameTextBox.Text}', {AgeTextBox.Text}, '{PhoneTextBox.Text}', '{PasswordTextBox.Text}')";
                        SqlCommand cmd = new SqlCommand(insertQuery, connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Seller added successfully!");
                        connection.Close();

                        DisplayDataFromDB("Seller");
                    }
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
            if (IDTextBox.Text == "" || NameTextBox.Text == "" || AgeTextBox.Text == "" ||
                    Convert.ToInt32(AgeTextBox.Text) <= 0 ||
                    PhoneTextBox.Text == "" ||
                    PasswordTextBox.Text == "")
            {
                MessageBox.Show("Enter valid data");
                return false;
            }
            return true;
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

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDTextBox.Text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
            NameTextBox.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
            AgeTextBox.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTextBox.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
            PasswordTextBox.Text = DataGrid.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(IDTextBox.Text == "")
                {
                    MessageBox.Show("Enter valid ID");
                }
                else { 
                    connection.Open();
                    string deleteString = $"DELETE FROM dbo.Seller WHERE ID={IDTextBox.Text}";
                    SqlCommand cmd = new SqlCommand(deleteString, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Selected seller successfully deleted!");
                    connection.Close();

                    DisplayDataFromDB("Seller");
                    IDTextBox.Text = "";
                    NameTextBox.Text = "";
                    AgeTextBox.Text = "";
                    PhoneTextBox.Text = "";
                    PasswordTextBox.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            DisplayDataFromDB("Seller");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation())
                {
                    connection.Open();
                    string updateQuery = $@"UPDATE dbo.Seller SET Name='{NameTextBox.Text}',
                        Age={AgeTextBox.Text}, Phone='{PhoneTextBox.Text}', Password='{PasswordTextBox.Text}'
                        WHERE ID={IDTextBox.Text}";
                    SqlCommand cmd = new SqlCommand(updateQuery, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully updated selected row.");
                    connection.Close();
                    DisplayDataFromDB("Seller");
                }
            }catch(Exception ex)
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

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm catForm = new CategoryForm();
            catForm.Show();
            this.Hide();
        }

        private void SellerForm_FormClosing(object sender, FormClosingEventArgs e)
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
