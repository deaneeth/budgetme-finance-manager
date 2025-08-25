using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMe
{
    public partial class Investment : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        public Investment()
        {
            InitializeComponent();
        }

        private void Transactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int GetTotalInvestments()
        {
            int totalInvestments = 0;
            string query = "SELECT Amount FROM InvestmentDetails";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    totalInvestments += reader.GetInt32(reader.GetOrdinal("Amount"));
                }
            }

            return totalInvestments;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            DebtTransact debttransact = new DebtTransact();
            debttransact.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InvestTransact investtransact = new InvestTransact();
            investtransact.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Investments", connect);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                SqlDataAdapter adapterr = new SqlDataAdapter("SELECT * FROM InvestmentDetails", connect);
                DataTable dataTablee = new DataTable();
                adapterr.Fill(dataTablee);

                dataGridView3.DataSource = dataTablee;

                int investtotal = GetTotalInvestments();
                invstamt.Text = investtotal.ToString();




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

        private void Investment_Load(object sender, EventArgs e)
        {

        }
    }
}




