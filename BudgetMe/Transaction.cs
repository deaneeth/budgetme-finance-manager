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
    public partial class Transaction : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BudgetMeDatabases.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        public Transaction()
        {
            InitializeComponent();
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
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }
    }
}
