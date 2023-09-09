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
    public partial class Users : Form
    {
        private const string ConnectionString = "Data Source=reyn\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True";
        public Users()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                using (adduser uu = new adduser())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
                this.Hide();
            }
        }

        private void usersdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginformDataSet.tbl_login' table. You can move, or remove it, as needed.
            this.tbl_loginTableAdapter.Fill(this.loginformDataSet.tbl_login);
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (usersdgv.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected user(s)?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach(DataGridViewRow row in usersdgv.SelectedRows)
{
                        int userId = Convert.ToInt32(row.Cells["id"].Value);
                        DeleteUserFromDatabase(userId);
                    }
                    this.tbl_loginTableAdapter.Fill(this.loginformDataSet.tbl_login);
                    // Refresh DataGridView after deletion

                }
            }
            else
            {
                MessageBox.Show("Select at least one row to delete.");
            }
        }

        private void DeleteUserFromDatabase(int userId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = "DELETE FROM tbl_login WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", userId);
                    command.ExecuteNonQuery();
                }
            }

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            dashboard dashboardform = new dashboard();
            dashboardform.Show();
            this.Hide();
        }
    }

}


