using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace capstoneproject
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "Data Source=reyn\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }



        private void OpenNextWindow(string username)
        {
            // Create an instance of the next form
            dashboard nextForm = new dashboard();

            // Pass the username to the next form
            nextForm.username = username;

            // Show the next form
            nextForm.Show();

            // Hide the current login form
            this.Hide();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click_1(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM tbl_login WHERE Username = @username AND password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int userCount = (int)command.ExecuteScalar();

                    if (userCount > 0)
                    {
                        MessageBox.Show("Login successful!");

                        // Pass the username to the OpenNextWindow method
                        OpenNextWindow(username);
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }

        private void usernametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                usernametxt.Focus();
            }
        }

        private void passwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                loginbtn.PerformClick();
        }
    }
}
