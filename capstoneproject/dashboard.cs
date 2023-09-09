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
    public partial class dashboard : Form
    {
        public string username { get; set; }

        private const string ConnectionString = "Data Source=reyn\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True";
        public dashboard()
        {
            InitializeComponent();
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;

        }
        private void LoadTodayData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                // Create a SQL query to fetch today's data
                string query = "SELECT Name, Department, Purpose, QueueNumber,QueueCode, QueueDate FROM stu_data WHERE CONVERT(date, QueueDate) = @QueueDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@QueueDate", DateTime.Today);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable todayData = new DataTable();
                        adapter.Fill(todayData);

                        // Bind the DataGridView to the filtered data
                        dataGridView1.DataSource = todayData;
                    }
                }
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            Users form3 = new Users();
            form3.Show();
            this.Hide();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            lblusername.Text = "Welcome, " + username;


            lbldate.Text = DateTime.Now.ToLongDateString();
            LoadTodayData();
            timer1.Start();

        }

        private void dashboard_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginformDataSet.tbl_login' table. You can move, or remove it, as needed.
            this.tbl_loginTableAdapter.Fill(this.loginformDataSet.tbl_login);
            // TODO: This line of code loads data into the 'loginformDataSet7.stu_data' table. You can move, or remove it, as needed.
            this.stu_dataTableAdapter.Fill(this.loginformDataSet7.stu_data);



            LoadTodayData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Cast the sender to a Button

            if (clickedButton != null)
            {
                lblshow.Text = "" + clickedButton.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Cast the sender to a Button

            if (clickedButton != null)
            {
                lblshow.Text = " " + clickedButton.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Cast the sender to a Button

            if (clickedButton != null)
            {
                lblshow.Text = " " + clickedButton.Text;
            }
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; // Cast the sender to a Button

            Users form3 = new Users();
            form3.Show();
            this.Hide();

            if (clickedButton != null)
            {
                lblshow.Text = "" + clickedButton.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadTodayData();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the application
                Application.Exit();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtsearch.Text;
            if (!string.IsNullOrEmpty(searchText))
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = $"Name LIKE '%{searchText}%'";
            }
            else
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Empty;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadTodayData();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string searchText = txtsearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Filter the DataGridView based on the search text
                string filterExpression = $"Name LIKE '%{searchText}%' OR Department LIKE '%{searchText}%' OR Purpose LIKE '%{searchText}%'";
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = filterExpression;
            }
            else
            {
                // Clear the filter to display all data
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Empty;
            }
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbldate.Text = dateTimePicker.Value.ToLongDateString();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}