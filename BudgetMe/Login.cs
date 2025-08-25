using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BudgetMe
{
    public partial class Login : Form
    {
        private SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public Login()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(pictureBox5_Click);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Signup sForm = new Signup();
            sForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usertext.Text) || string.IsNullOrWhiteSpace(passtext.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                string selectData = "SELECT * FROM users WHERE username = @username AND passwords = @password";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@username", usertext.Text);
                    cmd.Parameters.AddWithValue("@password", passtext.Text);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            MessageBox.Show("Logged in successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Form1 mForm = new Form1();
                            mForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
            finally
            {
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}