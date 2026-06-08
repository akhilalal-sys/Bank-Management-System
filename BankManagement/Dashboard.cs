using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BankManagement
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboard();
            LoadTopCustomers();
            LoadRecentTransactions();
            StyleGrid(dgvTopCustomers);
            StyleGrid(dgvRecentTransactions);
            LoadTopCustomerChart();
            LoadTransactionChart();
        }
        private void StyleGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgv.ReadOnly = true;

            dgv.AllowUserToAddRows = false;

            dgv.RowHeadersVisible = false;

            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgv.RowTemplate.Height = 35;

            // Specific column widths for Recent Transactions grid
            if (dgv.Name == "dgvRecentTransactions")
            {
                dgv.Columns["TID"].FillWeight = 15;
                dgv.Columns["Transaction_Type"].FillWeight = 25;
                dgv.Columns["Amount"].FillWeight = 25;
                dgv.Columns["Transaction_Date"].FillWeight = 35;
            }
        }
        public void LoadTransactionChart()
        {
            double deposits = 0;
            double withdrawals = 0;

            using (SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False"))
            {
                con.Open();

                string query = @"
                SELECT
                Transaction_Type,
                COUNT(*) AS Total
                FROM transactions
                GROUP BY Transaction_Type";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string transactionType =
                            dr["Transaction_Type"].ToString();

                        double total =
                            Convert.ToDouble(dr["Total"]);

                        if (transactionType == "Deposit")
                        {
                            deposits = total;
                        }
                        else if (transactionType == "Withdraw")
                        {
                            withdrawals = total;
                        }
                    }
                }
            }

            formsPlotTransactions.Plot.Clear();

            double[] values =
            {
                deposits,
                withdrawals
            };

            var pie = formsPlotTransactions.Plot.Add.Pie(values);

            // Labels
            pie.Slices[0].Label = "Deposit";
            pie.Slices[1].Label = "Withdraw";

            // Optional styling
            pie.SliceLabelDistance = 0.6;
            pie.ExplodeFraction = 0.05;

            // Show legend
            formsPlotTransactions.Plot.ShowLegend();

            // Remove axes and grid for cleaner pie chart
            formsPlotTransactions.Plot.Axes.Frameless();
            formsPlotTransactions.Plot.HideGrid();

            formsPlotTransactions.Plot.Title("Transaction Distribution");

            formsPlotTransactions.Refresh();
        }
        public void LoadTopCustomerChart()
        {
            List<double> balances = new List<double>();

            List<string> names = new List<string>();

            using (SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False"))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"SELECT TOP 10
                c.customer_name,
                SUM(a.Balance) AS TotalBalance
              FROM customers c
              INNER JOIN accounts a
                ON c.customer_id = a.Customer_ID
              WHERE c.Status = 'Active'
                AND a.Account_Status = 'Active'
              GROUP BY c.customer_name
              ORDER BY TotalBalance DESC",
                    con);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    names.Add(
                        dr["customer_name"].ToString());

                    balances.Add(
                        Convert.ToDouble(
                            dr["TotalBalance"]));
                }
            }

            formsPlotTopCustomers.Plot.Clear();

            formsPlotTopCustomers.Plot.Add.Bars(
                balances.ToArray());

            formsPlotTopCustomers.Plot.Axes.Bottom.TickGenerator =
                new ScottPlot.TickGenerators.NumericManual(
                    Enumerable.Range(0, names.Count)
                        .Select(x => (double)x)
                        .ToArray(),
                    names.ToArray());

            formsPlotTopCustomers.Plot.Title(
                "Top 10 Customers by Balance");

            formsPlotTopCustomers.Plot.XLabel(
                "Customers");

            formsPlotTopCustomers.Plot.YLabel(
                "Balance");

            formsPlotTopCustomers.Refresh();
        }
        public void LoadDashboard()
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            // TOTAL CUSTOMERS
            SqlCommand cmd1 = new SqlCommand(
                "select count(*) from customers where Status='Active'",
                con);

            lblTotalCustomers.Text =
                cmd1.ExecuteScalar().ToString();

            // ACTIVE ACCOUNTS
            SqlCommand cmd2 = new SqlCommand(
                "select count(*) from accounts where Account_Status='Active'",
                con);

            lblActiveAccounts.Text =
                cmd2.ExecuteScalar().ToString();

            // CLOSED ACCOUNTS
            SqlCommand cmd3 = new SqlCommand(
                "select count(*) from accounts where Account_Status='Closed'",
                con);

            lblClosedAccounts.Text =
                cmd3.ExecuteScalar().ToString();

            // TOTAL TRANSACTIONS
            SqlCommand cmd4 = new SqlCommand(
                "select count(*) from transactions",
                con);

            lblTotalTransactions.Text =
                cmd4.ExecuteScalar().ToString();

            // TOTAL LOAN AMOUNT
            SqlCommand cmd5 = new SqlCommand(
                "select isnull(sum(Amount),0) from loans where Loan_Status='Active'",
                con);

            lblTotalLoanAmount.Text =
                cmd5.ExecuteScalar().ToString();

            // TODAY DEPOSITS
            SqlCommand cmd6 = new SqlCommand(
                @"select isnull(sum(Amount),0)
          from transactions
          where Transaction_Type='Deposit'
          and CAST(Transaction_Date as date)=CAST(GETDATE() as date)",
                con);

            lblTodayDeposits.Text =
                cmd6.ExecuteScalar().ToString();

            // TODAY WITHDRAWALS
            SqlCommand cmd7 = new SqlCommand(
                @"select isnull(sum(Amount),0)
          from transactions
          where Transaction_Type='Withdraw'
          and CAST(Transaction_Date as date)=CAST(GETDATE() as date)",
                con);

            lblTodayWithdrawals.Text =
                cmd7.ExecuteScalar().ToString();

            // ACTIVE LOANS
            SqlCommand cmd8 = new SqlCommand(
                "select count(*) from loans where Loan_Status='Active'",
                con);

            lblActiveLoans.Text =
                cmd8.ExecuteScalar().ToString();

            con.Close();
        }
        public void LoadTopCustomers()
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand(
                @"select top 5
          c.customer_name,
          count(a.Account_ID) as TotalAccounts,
          sum(a.Balance) as TotalBalance
          from customers c
          inner join accounts a
          on c.customer_id = a.Customer_ID
          where c.Status='Active'
          group by c.customer_name
          order by TotalBalance desc",
                con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            da.Fill(table);

            dgvTopCustomers.DataSource = table;

            con.Close();
        }
        public void LoadRecentTransactions()
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand(
                @"select top 10
          TID,
          Transaction_Type,
          Amount,
          Transaction_Date
          from transactions
          order by Transaction_Date desc",
                con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            da.Fill(table);

            dgvRecentTransactions.DataSource = table;

            con.Close();
        }
    }
}
