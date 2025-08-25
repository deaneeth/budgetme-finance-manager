using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Collections;

namespace BudgetMe
{
    public partial class DebtTransact : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private int amount;
        private bool isCredit = false;

        public DebtTransact()
        {
            InitializeComponent();
        }

        private void DebtTransact_Load(object sender, EventArgs e)
        {
            // Any initialization logic can be added here
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

            int allPaid = 0;
            int allDebts = 0;

            if (isCredit)
            {
                allDebts = amount; // Minus amount for credit
            }
            else
            {
                allPaid = amount; // Plus amount for debit
            }

            // Ensure the connection is closed before opening
            if (connect.State == System.Data.ConnectionState.Open)
            {
                connect.Close();
            }

            // Transaction queries
            string transactionQuery = "INSERT INTO Debts (Dates, Names, Descriptions, Amount) VALUES (@Dates, @Names, @Descriptions, @Amount)";
            string debtorQuery = "IF EXISTS (SELECT 1 FROM Debtors WHERE Names = @Names) " +
                                 "UPDATE Debtors SET Amount = Amount + @Amount WHERE Names = @Names " +
                                 "ELSE " +
                                 "INSERT INTO Debtors (Names, Amount) VALUES (@Names, @Amount)";
            string paymentQuery = "INSERT INTO DebtPayment (AllPaid, AllDebts) VALUES (@AllPaid, @AllDebts)";

            try
            {
                connect.Open();

                using (SqlCommand cmd = new SqlCommand(transactionQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@Dates", date.Trim());
                    cmd.Parameters.AddWithValue("@Names", name.Trim());
                    cmd.Parameters.AddWithValue("@Descriptions", description.Trim());
                    cmd.Parameters.AddWithValue("@Amount", isCredit ? -amount : amount);

                    cmd.ExecuteNonQuery();
                }

                using (SqlCommand debtorCmd = new SqlCommand(debtorQuery, connect))
                {
                    debtorCmd.Parameters.AddWithValue("@Names", name.Trim());
                    debtorCmd.Parameters.AddWithValue("@Amount", isCredit ? -amount : amount);

                    debtorCmd.ExecuteNonQuery();
                }

                using (SqlCommand paymentCmd = new SqlCommand(paymentQuery, connect))
                {
                    paymentCmd.Parameters.AddWithValue("@AllPaid", allPaid);
                    paymentCmd.Parameters.AddWithValue("@AllDebts", allDebts);

                    paymentCmd.ExecuteNonQuery();
                }

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
                cmdd.Parameters.AddWithValue("@Amount", isCredit ? -amount : amount); // Use the amount field directly

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

        private void Credit_check_CheckedChanged(object sender, EventArgs e)
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

        private void Debit_check_CheckedChanged(object sender, EventArgs e)
        {
            if (Debit_check.Checked)
            {
                isCredit = false;
                Credit_check.Checked = false; // Ensure only one checkbox is checked at a time
            }
        }
    }
}
