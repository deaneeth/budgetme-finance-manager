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

namespace BudgetMe
{
    public partial class Signup : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public Signup()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(pictureBox5_Click);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login sForm = new Login();
            sForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usertext.Text == "" || passtext.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM users WHERE username = @username";

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@username", usertext.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show(usertext.Text + " already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, passwords) VALUES(@username, @passwords)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", usertext.Text.Trim());
                                    cmd.Parameters.AddWithValue("@passwords", passtext.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Switch to the Login form
                                    Login lForm = new Login();
                                    lForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                // Option 1: DELETE all rows from the table
                string deleteData = "DELETE FROM moneydes";
                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                {
                    cmd.ExecuteNonQuery();
                }
                string deleteDailyExp = "DELETE FROM DailyExpensess";
                using (SqlCommand cmd = new SqlCommand(deleteDailyExp, connect))
                {
                    cmd.ExecuteNonQuery();
                }
                string deletedailydes = "DELETE FROM dailydes";
                using (SqlCommand cmd = new SqlCommand(deletedailydes, connect))
                {
                    cmd.ExecuteNonQuery();
                }
                string deletedebts = "DELETE FROM Debts";
                using (SqlCommand cmd = new SqlCommand(deletedebts, connect))
                {
                    cmd.ExecuteNonQuery();
                }
                string deletedebtors = "DELETE FROM Debtors";
                using (SqlCommand cmd = new SqlCommand(deletedebtors, connect))
                {
                    cmd.ExecuteNonQuery();
                }
                string deleteInvest = "DELETE FROM Investments";
                using (SqlCommand cmd = new SqlCommand(deleteInvest, connect))
                {
                    cmd.ExecuteNonQuery();
                }
                string deleteinvestdetails = "DELETE FROM InvestmentDetails";
                using (SqlCommand cmd = new SqlCommand(deleteinvestdetails, connect))
                {
                    cmd.ExecuteNonQuery();
                }
                string delete = "DELETE FROM Transactions";
                using (SqlCommand cmd = new SqlCommand(delete, connect))
                {
                    cmd.ExecuteNonQuery();
                }


            }
            
            finally
            {
                connect.Close();
            }
            DialogResult result = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                Application.Exit();
            }


        }
    }
}
