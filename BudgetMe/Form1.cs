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
using MySql.Data.MySqlClient;

namespace BudgetMe
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(pictureBox5_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            Dashboard.BringToFront();
            dailyTracker1.BringToFront();
            debtManager1.BringToFront();
            transaction1.BringToFront();
            investment1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dashboard.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dailyTracker1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            debtManager1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            transaction1.BringToFront();
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

                string deletedd = "DELETE FROM DebtPayment";
                using (SqlCommand cmd = new SqlCommand(deletedd, connect))
                {
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            investment1.BringToFront();
        }
    }
}
