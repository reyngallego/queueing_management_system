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
using System.IO;

namespace capstoneproject
{
    public partial class adduser : Form
    {
        public adduser()
        {
            InitializeComponent();
        }
        private const string ConnectionString = "Data Source=reyn\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True";

        private void adduser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginformDataSet.tbl_login' table. You can move, or remove it, as needed.
            this.tbl_loginTableAdapter.Fill(this.loginformDataSet.tbl_login);

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;
            string confirmPassword = confirmpasswordtxt.Text;
            string firstName = firstnametxt.Text;
            string lastName = lastnametxt.Text;
            string department = departmentcbx.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(department))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            byte[] imageBytes = null;
            if (pictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "INSERT INTO tbl_login (username, password, firstname, lastname, department, image) " +
                               "VALUES (@username, @password, @firstname, @lastname, @department, @image)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@firstname", firstName);
                    command.Parameters.AddWithValue("@lastname", lastName);
                    command.Parameters.AddWithValue("@department", department);
                    command.Parameters.AddWithValue("@image", imageBytes);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Registration successful!");
            ClearFields();
        }

        private void ClearFields()
        {
            usernametxt.Clear();
            passwordtxt.Clear();
            confirmpasswordtxt.Clear();
            firstnametxt.Clear();
            lastnametxt.Clear();
            departmentcbx.SelectedIndex = -1;
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
     
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Image";
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();

            // Show the previous form (WelcomeForm in this example)
            Users Usersform = new Users();
            Usersform.Show();
        }
    }
    }

        

        

       
