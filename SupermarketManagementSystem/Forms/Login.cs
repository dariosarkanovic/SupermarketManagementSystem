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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=.;Initial Catalog=Supermarket;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else
            {
                if(SelectRoleComboBox.SelectedIndex > -1 && SelectRoleComboBox.SelectedItem.ToString() == "Admin")
                {
                    
                    if(UsernameTextBox.Text == "Admin" && PasswordTextBox.Text == "Admin")
                    {
                        ProductForm prodForm = new ProductForm();
                        prodForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Enter valid username and password!");
                    }
                }else if(SelectRoleComboBox.SelectedIndex > -1 && SelectRoleComboBox.SelectedItem.ToString() == "Seller")
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter($@"SELECT 
                                 count(8) FROM dbo.Seller WHERE Name='{UsernameTextBox.Text}' and
                                 Password='{PasswordTextBox.Text}'", connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    if (dataTable.Rows[0][0].ToString() == "1")
                    {
                        string seller = UsernameTextBox.Text;
                        Selling sellingForm = new Selling(seller);
                        sellingForm.Show();
                        this.Hide();
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password.");
                    }
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Select role");
                }
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
