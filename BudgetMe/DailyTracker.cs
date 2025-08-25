using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace BudgetMe
{
    public partial class DailyTracker : UserControl
    {
        private const int DaysInMonth = 30; // Avoid magic numbers
        private readonly SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public DailyTracker()
        {
            InitializeComponent();
            dailyprgbar.Value = 100;
        }

        private void LoadData()
        {
            try
            {
                connect.Open();

                int totalSpendable = GetTotalSpendable();
                int dailySpendable = totalSpendable / DaysInMonth;
                label2.Text = dailySpendable.ToString();
                label5.Text = "Daily Limit: " + dailySpendable;

                int totalExpenses = GetTotalExpenses();
                UpdateSurplus(dailySpendable, totalExpenses);
                LoadDaily(dailySpendable, totalExpenses);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            int totalExp = totalExpenses / 2;
            return totalExp;
        }

        private int ExecuteScalarQuery(string query)
        {
            int total = 0;
            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    total += reader.GetInt32(0);
                }
            }
            return total;
        }

        // The LoadDaily method to update the progress bar based on daily spendable and total expenses
        public void LoadDaily(int dailySpendable, int totalExpenses)
        {
            int amount = dailySpendable - totalExpenses;
            label2.Text = amount.ToString(); // Updated from dailyamt to label2

            // Calculate the percentage
            double percentage = (double)amount / dailySpendable * 100;
            if (percentage < 0) percentage = 0; // Ensure the percentage is not negative
            if (percentage > 100) percentage = 100; // Ensure the percentage does not exceed 100

            // Update the progress bar
            dailyprgbar.Value = (int)percentage;
        }

        public void UpdateDailyProgressBar(int totalSpendable, int totalExpenses)
        {
            int dailySpendable = totalSpendable / DaysInMonth;
            int amount = dailySpendable - totalExpenses;
            label2.Text = amount.ToString();

            // Calculate the percentage based on the passed daily spendable amount
            double percentage = (double)amount / dailySpendable * 100;
            if (percentage < 0) percentage = 0; // Ensure the percentage is not negative
            if (percentage > 100) percentage = 100; // Ensure the percentage does not exceed 100

            // Update the progress bar
            dailyprgbar.Value = (int)percentage;
        }


        private void UpdateSurplus(int dailySpendable, int totalExpenses)
        {
            int surplus = dailySpendable - totalExpenses;
            if (surplus > 0)
            {
                surplusamt.Text = surplus.ToString();
                shortageamt.Text = string.Empty;
            }
            else
            {
                shortageamt.Text = surplus.ToString();
                surplusamt.Text = string.Empty;
            }
        }

        private void LoadYestStatus()
        {
            try
            {
                connect.Open();
                int yestday = GetYesterdayDayId();
                if (yestday == 0) return;

                (int yestSurplus, int yestShortage) = GetYesterdaySurplusAndShortage(yestday);

                if (yestSurplus > 0)
                {
                    statusamt.Text = yestSurplus.ToString();
                    shortageamt.Text = string.Empty;
                }
                else
                {
                    statusamt.Text = yestShortage.ToString();
                    surplusamt.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private int GetYesterdayDayId()
        {
            const string query = "SELECT MAX(dayid) AS yestday FROM dailydes";
            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                return reader.Read() ? reader.GetInt32(0) : 0;
            }
        }

        private (int, int) GetYesterdaySurplusAndShortage(int yestday)
        {
            const string query = "SELECT surplus, shortage FROM dailydes WHERE dayid = @yestday";
            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                cmd.Parameters.AddWithValue("@yestday", yestday);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return (reader.GetInt32(0), reader.GetInt32(1));
                    }
                }
            }
            return (0, 0);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transacts transact = new Transacts();
            transact.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DailyExpensess", connect);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Transactions.DataSource = dataTable;

                int totalExpenses = dataTable.AsEnumerable().Sum(row => row.Field<int>("Amount"));
                int totalSpendable = GetTotalSpendable();
                int dailySpendable = totalSpendable / DaysInMonth;

                label2.Text = dailySpendable.ToString();
                label5.Text = "Daily Limit: " + dailySpendable;

                UpdateSurplus(dailySpendable, totalExpenses);
                LoadDaily(dailySpendable, totalExpenses);
                UpdateDailyProgressBar(totalSpendable, totalExpenses);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void newday_button_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                int daily = int.Parse(label2.Text);
                int exp = GetTotalExpenses();
                int dailyexp = daily - exp; 

                string surplusAmt = surplusamt.Text;
                string shortageAmt = shortageamt.Text;

                const string query = "INSERT INTO dailydes (dailyexp, surplus, shortage) VALUES (@dailyexp, @surplus, @shortage)";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@dailyexp", dailyexp); 
                    cmd.Parameters.AddWithValue("@surplus", surplusAmt.Trim());
                    cmd.Parameters.AddWithValue("@shortage", shortageAmt.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }

            
            RefreshTransactionData();

            
            LoadYestStatus();

            
            ResetToInitialValues();
            ResetDailyProgressBar();
            ResetDelete();
        }

        private void ResetDailyProgressBar()
        {
            dailyprgbar.Value = 0;
            label2.Text = "0";      
            label5.Text = "Daily Limit: 0"; 
        }
        private void ResetDelete()
        {
            try
            {
                connect.Open();

                string deleteDailyExp = "DELETE FROM DailyExpensess";
                using (SqlCommand cmd = new SqlCommand(deleteDailyExp, connect))
                {
                    cmd.ExecuteNonQuery();
                }


            }

            finally
            {
                connect.Close();
            }
        }


        private void RefreshTransactionData()
        {
            try
            {
                connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DailyExpensess", connect);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                Transactions.DataSource = dataTable;

                int totalExpenses = dataTable.AsEnumerable().Sum(row => row.Field<int>("Amount"));
                int totalSpendable = GetTotalSpendable();
                int dailySpendable = totalSpendable / DaysInMonth;

                label2.Text = dailySpendable.ToString();
                label5.Text = "Daily Limit: " + dailySpendable;

                UpdateSurplus(dailySpendable, totalExpenses);
                LoadDaily(dailySpendable, totalExpenses);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void ResetToInitialValues()
        {
            // Clear the DataGridView
            Transactions.DataSource = null;

            // Reset the labels to their initial state
            surplusamt.Text = string.Empty;
            shortageamt.Text = string.Empty;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                connect.Open();

                using (SqlDataAdapter da = new SqlDataAdapter("SELECT dayid, dailyexp FROM dailydes", connect))
                {
                    da.Fill(dt);
                }

                chart1.DataSource = dt;
                chart1.Series.Clear();

                var series = chart1.Series.Add("DailyChart");
                series.XValueMember = "dayid";
                series.YValueMembers = "dailyexp";

                chart1.Titles.Clear();
                chart1.Titles.Add("Daily Expenses Chart");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void DailyTracker_Load(object sender, EventArgs e) { }
        private void Transactions_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dailyExpensesBindingNavigatorSaveItem_Click(object sender, EventArgs e) { }
        private void dailyExpensessDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void statusamt_Click(object sender, EventArgs e) { }
        private void chart1_Click(object sender, EventArgs e) { }
        private void panel6_Paint_1(object sender, PaintEventArgs e) { }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


