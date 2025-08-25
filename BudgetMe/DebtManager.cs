using System;
using System.Collections;
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
    public partial class DebtManager : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public DebtManager()
        {
            InitializeComponent();
            debtprgbar.Value = 0;
            LoadDebtData();
        }

        private void Transactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int GetTotalDebt()
        {
            int totalDebt = 0;
            string query = "SELECT Amount FROM Debtors";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                try
                {
                    connect.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            totalDebt += reader.GetInt32(reader.GetOrdinal("Amount"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception as needed
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally
                {
                    connect.Close(); // Explicitly close the connection (although using statement should handle it)
                }
            }

            return totalDebt;
        }

        private void LoadDebtData()
        {
            try
            {
                connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Debts", connect);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                SqlDataAdapter adapterr = new SqlDataAdapter("SELECT * FROM Debtors", connect);
                DataTable dataTablee = new DataTable();
                adapterr.Fill(dataTablee);

                dataGridView3.DataSource = dataTablee;

                int totalDebt = GetTotalDebt();
                debtamt.Text = totalDebt.ToString();

                UpdateDebtProgressBar();

            }
            finally
            {
                connect.Close();
            }
        }

        private void UpdateDebtProgressBar()
        {
            try
            {
                (int allPaid, int allDebts) = GetDebtPaymentData();

                if (allDebts == 0)
                {
                    debtprgbar.Value = 0;
                }
                else
                {
                    double percentage = (double)allPaid / allDebts * 100;
                    if (percentage < 0) percentage = 0;
                    if (percentage > 100) percentage = 100;

                    debtprgbar.Value = (int)percentage;
                }

                debtamt.Text = allDebts.ToString(); // Display total debt amount
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private (int allPaid, int allDebts) GetDebtPaymentData()
        {
            int allPaid = 0;
            int allDebts = 0;
            string query = "SELECT SUM(AllPaid) AS TotalPaid, SUM(AllDebts) AS TotalDebts FROM DebtPayment";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                try
                {
                    connect.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            allPaid = reader.IsDBNull(reader.GetOrdinal("TotalPaid")) ? 0 : reader.GetInt32(reader.GetOrdinal("TotalPaid"));
                            allDebts = reader.IsDBNull(reader.GetOrdinal("TotalDebts")) ? 0 : reader.GetInt32(reader.GetOrdinal("TotalDebts"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the exception as needed
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }

            return (allPaid, allDebts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Debts", connect);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                SqlDataAdapter adapterr = new SqlDataAdapter("SELECT * FROM Debtors", connect);
                DataTable dataTablee = new DataTable();
                adapterr.Fill(dataTablee);

                dataGridView3.DataSource = dataTablee;

                int debtstotal = GetTotalDebt();
                debtamt.Text = debtstotal.ToString();

                LoadDebtData();
            }
            finally
            {
                connect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebtTransact debttransact = new DebtTransact();
            debttransact.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DebtManager_Load(object sender, EventArgs e)
        {

        }

        private void debtprgbar_Click(object sender, EventArgs e)
        {

        }

        private void debtprgbar_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
