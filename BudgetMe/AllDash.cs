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
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;

namespace BudgetMe
{
    public partial class AllDash : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public AllDash()
        {
            InitializeComponent();
            totamtprgbar.Value = 0;
            spendprgbar.Value = 0;
            dailyprgbar.Value = 0;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        private void LoadData()
        {
            try
            {
                connect.Open();

                // Load spendable data
                int totalSpendable = GetTotalSpendable();
                int dailySpendable = totalSpendable / 30;
                label2.Text = dailySpendable.ToString();

                label5.Text = "Daily Limit: " + dailySpendable.ToString();

                // Load expenses data
                int totalExpenses = GetTotalExpenses();
                loaddaily(dailySpendable, totalExpenses);
            }
            catch (Exception)
            {
                MessageBox.Show("Done");
            }
            finally
            {
                connect.Close();
            }
        }



        private int GetTotalSpendable()
        {
            int totalSpendable = 0;
            string query = "SELECT spendable FROM moneydes";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    totalSpendable += reader.GetInt32(reader.GetOrdinal("spendable"));
                }
            }

            return totalSpendable;
        }

        private int GetTotalExpenses()
        {
            int totalExpenses = 0;
            string query = "SELECT Amount FROM DailyExpensess";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    totalExpenses += reader.GetInt32(reader.GetOrdinal("Amount"));
                }
            }

            return totalExpenses;
        }

        private int GetTotalAmount()
        {
            int totalAmount = 0;
            int save = 0;
            int exp = 0;
            string query = "SELECT income,savings,expenses FROM moneydes";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    totalAmount += reader.GetInt32(reader.GetOrdinal("income"));
                    save += reader.GetInt32(reader.GetOrdinal("savings"));
                    exp += reader.GetInt32(reader.GetOrdinal("expenses"));
                }
            }
            int totAmount = totalAmount - (save + exp);
            return totAmount;
        }



        private void UpdateDaily(int dailySpendable, int totalExpenses)
        {
            int dayAmt = dailySpendable - totalExpenses;
            label2.Text = dayAmt.ToString();
        }
        private void loaddaily(int dailySpendable, int totalExpenses)
        {
            int amount = dailySpendable - totalExpenses;
            label2.Text = amount.ToString();
        }



        private void Transactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateProgressBar(ProgressBar progressBar, float percentage)
        {
            progressBar.Value = (int)percentage;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(incometext.Text) ||
                string.IsNullOrWhiteSpace(savingtext.Text) ||
                string.IsNullOrWhiteSpace(exptext.Text) ||
                string.IsNullOrWhiteSpace(spendtext.Text))
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(incometext.Text.Trim(), out int income) ||
                !int.TryParse(savingtext.Text.Trim(), out int savings) ||
                !int.TryParse(exptext.Text.Trim(), out int expenses) ||
                !int.TryParse(spendtext.Text.Trim(), out int spendable))
            {
                MessageBox.Show("Please enter valid numbers for all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InsertData(income, savings, expenses, spendable);
            UpdateDashboard();
        }
        private void InsertData(int income, int savings, int expenses, int spendable)
        {
            try
            {
                connect.Open();

                string insertData = "INSERT INTO moneydes (income, savings, expenses, spendable) VALUES (@income, @savings, @expenses, @spendable)";

                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                {
                    cmd.Parameters.AddWithValue("@income", income);
                    cmd.Parameters.AddWithValue("@savings", savings);
                    cmd.Parameters.AddWithValue("@expenses", expenses);
                    cmd.Parameters.AddWithValue("@spendable", spendable);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Details Entered :)", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Done");
            }
            finally
            {
                connect.Close();
            }
        }
        private void UpdateDashboard()
        {
            try
            {
                connect.Open();

                string selectData = "SELECT income, savings, expenses, spendable FROM moneydes";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int totalIncome = 0;
                    int totalSavings = 0;
                    int totalExpenses = 0;
                    int totalSpendables = 0;

                    while (reader.Read())
                    {
                        totalIncome += reader.GetInt32(reader.GetOrdinal("income"));
                        totalSavings += reader.GetInt32(reader.GetOrdinal("savings"));
                        totalExpenses += reader.GetInt32(reader.GetOrdinal("expenses"));
                        totalSpendables += reader.GetInt32(reader.GetOrdinal("spendable"));
                    }

                    // Correctly calculate totalAmountRemaining
                    int totalAmountRemaining = totalIncome - (totalSavings + totalExpenses);

                    // Update labels with actual values
                    totamtlabel.Text = totalAmountRemaining.ToString();
                    label3.Text = totalSpendables.ToString();

                    // Calculate daily spendable amount
                    int dailySpendable = totalSpendables / 30;
                    label2.Text = dailySpendable.ToString();
                    label5.Text = "Daily Limit: " + dailySpendable;

                    // Calculate percentages for progress bars
                    float totamtPercentage = totalIncome > 0 ? (float)totalAmountRemaining / totalIncome * 100 : 0;
                    float spendablePercentage = totalAmountRemaining > 0 ? (float)totalSpendables / totalAmountRemaining * 100 : 0;
                    float dailySpendablePercentage = totalAmountRemaining > 0 ? (float)dailySpendable / totalAmountRemaining * 100 : 0;

                    // Update progress bars with percentages
                    UpdateProgressBar(totamtprgbar, totamtPercentage);
                    UpdateProgressBar(spendprgbar, spendablePercentage);
                    UpdateProgressBar(dailyprgbar, dailySpendablePercentage);

                    // Additional functionality to update bars if needed
                    WorkBars(totalIncome, totalSavings, totalSpendables);

                    // Update DailyTracker progress bar
                    DailyTracker dailyTracker = new DailyTracker(); // Make sure to use the correct instance
                    dailyTracker.UpdateDailyProgressBar(dailySpendable, totalExpenses);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Done");
            }
            finally
            {
                connect.Close();
            }
        }


        

        private void totamtlabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void transact_button_Click(object sender, EventArgs e)
        {
            Normal transinputt = new Normal();
            transinputt.Show();
        }

        private void AllDash_Load(object sender, EventArgs e)
        {

        }

        private void totamtprgbar_Click(object sender, EventArgs e)
        {

        }

        private void updates(int totalSpendables, int totalIncome, int totalSavings, int totalExpenses)
        {
            int totalAmountRemaining = totalIncome - (totalSavings + totalExpenses);
            totamtlabel.Text = totalAmountRemaining.ToString();
            label3.Text = totalSpendables.ToString();
            //WorkBars(totalIncome, totalSavings, totalSpendables);
        }
        private void WorkBars(int income, int spend, int daily)
        {
            totamtprgbar.Value = income;
            spendprgbar.Value = spend;
            dailyprgbar.Value = daily;
            int totalExpenses = GetTotalExpenses();
            int dailyremain = daily - totalExpenses;
            if (dailyprgbar.Value > dailyremain)
            {
                dailyprgbar.Value = dailyremain;
            }

            // This section is updated now in UpdateDashboard method
            // so no need to repeat the calculation here.
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Transactions", connect);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Transactions.DataSource = dataTable;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
            try
            {
                connect.Open();

                // Load spendable data
                int totalSpendable = GetTotalSpendable();
                int dailySpendable = totalSpendable / 30;
                label2.Text = dailySpendable.ToString();

                label5.Text = "Daily Limit: " + dailySpendable.ToString();

                // Load expenses data
                int totalExpenses = GetTotalExpenses();

                //totalamt load
                int total = GetTotalAmount();
                int totremain = total - totalExpenses;
                totamtlabel.Text = totremain.ToString();

                //spendload
                int totalSpendableremain = totalSpendable - totalExpenses;
                label3.Text = totalSpendableremain.ToString();

                loaddaily(dailySpendable, totalExpenses);


            }
            
            finally
            {
                connect.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Transacts transact = new Transacts();
            transact.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DebtTransact investtransact = new DebtTransact();
            investtransact.ShowDialog();
        }

        private void spendprgbar_Click(object sender, EventArgs e)
        {

        }
    }
}