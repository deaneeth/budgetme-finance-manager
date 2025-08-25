using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BudgetMe
{
    public partial class Transacts : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private int amount;
        private bool isCredit = false;

        public Transacts()
        {
            InitializeComponent();
        }



        public void button1_Click(object sender, EventArgs e)
        {
            string date = Date.Text;
            string name = Names.Text;
            string description = Description.Text;
            string amountText = Amount.Text;

            if (string.IsNullOrWhiteSpace(date) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(amountText))
            {
                MessageBox.Show("All fields must be filled out");
                return;
            }

            if (!int.TryParse(amountText, out amount))
            {
                MessageBox.Show("Amount must be a valid number");
                return;
            }

            amount = isCredit ? -amount : amount;

            string query = "INSERT INTO DailyExpensess (Dates, Names, Descriptions, Amount) VALUES (@Dates, @Names, @Descriptions, @Amount)";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@Dates", date.Trim());
                cmd.Parameters.AddWithValue("@Names", name.Trim());
                cmd.Parameters.AddWithValue("@Descriptions", description.Trim());
                cmd.Parameters.AddWithValue("@Amount", amount); // Use the amount field directly

                try
                {
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }

                string queryy = "INSERT INTO Transactions (Dates, Names, Descriptions, Amount) VALUES (@Dates, @Names, @Descriptions, @Amount)";

                using (SqlCommand cmdd = new SqlCommand(queryy, connect))
                {
                    cmdd.Parameters.AddWithValue("@Dates", date.Trim());
                    cmdd.Parameters.AddWithValue("@Names", name.Trim());
                    cmdd.Parameters.AddWithValue("@Descriptions", description.Trim());
                    cmdd.Parameters.AddWithValue("@Amount", amount); // Use the amount field directly

                    try
                    {
                        connect.Open();
                        cmdd.ExecuteNonQuery();
                        
                    }
                    
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void Date_TextChanged(object sender, EventArgs e) { }

        private void Name_TextChanged(object sender, EventArgs e) { }

        private void Description_TextChanged(object sender, EventArgs e) { }

        private void Amount_TextChanged(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Transact_Load(object sender, EventArgs e)
        {

        }

        private void Debit_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Credit_check.Checked)
            {
                isCredit = true;
                Debit_check.Checked = false; // Ensure only one checkbox is checked at a time
            }
            else
            {
                isCredit = false;
            }
        }

        private void Credit_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Debit_check.Checked)
            {
                isCredit = false;
                Credit_check.Checked = false; // Ensure only one checkbox is checked at a time
            }
        }
    }

    
}