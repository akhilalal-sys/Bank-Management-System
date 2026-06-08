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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker2.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDATION

                if (comboBoxAccount.Text == "")
                {
                    MessageBox.Show("Please select account!");
                    comboBoxAccount.Focus();
                    return;
                }

                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Please select transaction type!");
                    comboBox1.Focus();
                    return;
                }

                if (textBox3.Text.Trim() == "")
                {
                    MessageBox.Show("Amount is required!");
                    textBox3.Focus();
                    return;
                }

                if (!int.TryParse(textBox3.Text, out _))
                {
                    MessageBox.Show("Amount must be numeric!");
                    textBox3.Focus();
                    return;
                }

                // GET ACCOUNT ID
                string[] parts = comboBoxAccount.Text.Split('-');

                int accountId = int.Parse(parts[0].Trim());

                int amount = int.Parse(textBox3.Text);
                if (amount <= 0)
                {
                    MessageBox.Show(
                        "Amount must be greater than zero!");

                    textBox3.Focus();

                    return;
                }

                SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();
                SqlCommand statusCmd = new SqlCommand(
                        "select Account_Status from accounts where Account_ID=@Account_ID",
                         con);

                statusCmd.Parameters.AddWithValue(
                    "@Account_ID",
                    accountId);

                string accountStatus =
                    statusCmd.ExecuteScalar().ToString();

                if (accountStatus == "Closed" ||
    accountStatus == "Frozen")
                {
                    MessageBox.Show(
                        "Transactions are not allowed on closed or Frozen accounts!");

                    return;
                }

                // GET CURRENT BALANCE
                SqlCommand getBalance = new SqlCommand(
                    "select Balance from accounts where Account_ID=@Account_ID",
                    con);

                getBalance.Parameters.AddWithValue(
                    "@Account_ID",
                    accountId);

                int currentBalance =
                    Convert.ToInt32(
                        getBalance.ExecuteScalar());

                int newBalance = currentBalance;

                // DEPOSIT
                if (comboBox1.Text == "Deposit")
                {
                    newBalance =
                        currentBalance + amount;
                }

                // WITHDRAW
                else if (comboBox1.Text == "Withdraw")
                {
                    if (amount > currentBalance)
                    {
                        MessageBox.Show(
                            "Insufficient Balance!");

                        return;
                    }

                    newBalance =
                        currentBalance - amount;
                }

                // SHOW BALANCE AFTER
                textBoxBalanceAfter.Text =
                    newBalance.ToString();

                // SAVE TRANSACTION
                SqlCommand insertTransaction =
                    new SqlCommand(
                    @"insert into transactions
            (
                Transaction_Type,
                Amount,
                Transaction_Date,
                Account_Id,
                Balance_After_Transaction,
                Transaction_Status,
                Remarks
            )
            values
            (
                @type,
                @amount,
                @date,
                @accountid,
                @balanceafter,
                @status,
                @remarks
            )",
                    con);

                insertTransaction.Parameters.AddWithValue(
                    "@type",
                    comboBox1.Text);

                insertTransaction.Parameters.AddWithValue(
                    "@amount",
                    amount);

                insertTransaction.Parameters.AddWithValue(
                    "@date",
                    dateTimePicker2.Value);

                insertTransaction.Parameters.AddWithValue(
                    "@accountid",
                    accountId);

                insertTransaction.Parameters.AddWithValue(
                    "@balanceafter",
                    newBalance);

                insertTransaction.Parameters.AddWithValue(
                    "@status",
                    "Success");

                insertTransaction.Parameters.AddWithValue(
                    "@remarks",
                    textBoxRemarks.Text);

                insertTransaction.ExecuteNonQuery();

                // UPDATE ACCOUNT BALANCE
                SqlCommand updateBalance =
                    new SqlCommand(
                    "update accounts set Balance=@Balance where Account_ID=@Account_ID",
                    con);

                updateBalance.Parameters.AddWithValue(
                    "@Balance",
                    newBalance);

                updateBalance.Parameters.AddWithValue(
                    "@Account_ID",
                    accountId);

                updateBalance.ExecuteNonQuery();

                MessageBox.Show(
                    "Transaction Processed Successfully!");

                // AUTO REFRESH GRID
                LoadTransactionData();

                // CLEAR
                comboBoxAccount.SelectedIndex = -1;

                comboBox1.SelectedIndex = -1;

                textBox3.Clear();

                textBoxBalanceBefore.Clear();

                textBoxBalanceAfter.Clear();

                textBoxRemarks.Clear();

                dateTimePicker2.Value = DateTime.Now;

                comboBoxAccount.Focus();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoadTransactionData();

            comboBoxSearch.SelectedIndex = 0;

            textBoxSearch.Text = "Enter search value...";

            textBoxSearch.ForeColor = Color.Gray;
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            LoadTransactionData();

            // TRANSACTION TYPE
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Deposit");

            comboBox1.Items.Add("Withdraw");
            textBoxSearch.Text = "Enter search value...";
            textBoxSearch.ForeColor = Color.Gray;
            dataGridView1.Columns["Amount"].DefaultCellStyle.Format = "N0";

            dataGridView1.Columns["Balance_After_Transaction"]
                .DefaultCellStyle.Format = "N0";
            comboBoxSearch.SelectedIndex = 0;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.ReadOnly = true;
            // LOAD ACTIVE ACCOUNTS
            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand(
                @"select a.Account_ID,
                 a.Account_Type,
                 c.customer_name
                from accounts a
                inner join customers c
                on a.Customer_ID = c.customer_id
                where a.Account_Status='Active'",
                con);

            SqlDataReader dr = cmd.ExecuteReader();

            comboBoxAccount.Items.Clear();

            while (dr.Read())
            {
                comboBoxAccount.Items.Add(
                    dr["Account_ID"].ToString()
                    + " - " +
                    dr["Account_Type"].ToString()
                    + " - " +
                    dr["customer_name"].ToString());
            }

            con.Close();

            // GRID SETTINGS
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.MultiSelect = false;

            dataGridView1.ReadOnly = true;
        }
        public void LoadTransactionData()
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "select * from transactions order by TID desc",
                con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3_TextChanged(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAccount.Text == "")
                {
                    return;
                }

                string[] parts =
                    comboBoxAccount.Text.Split('-');

                int accountId =
                    int.Parse(parts[0].Trim());

                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "select Balance from accounts where Account_ID=@Account_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@Account_ID",
                    accountId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    textBoxBalanceBefore.Text =
                        result.ToString();

                    textBoxBalanceAfter.Text =
                        result.ToString();
                }

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBalanceBefore.Text == "" ||
                    textBox3.Text == "" ||
                    comboBox1.Text == "")
                {
                    return;
                }

                int currentBalance =
                    int.Parse(textBoxBalanceBefore.Text);

                int amount;

                if (!int.TryParse(textBox3.Text, out amount))
                {
                    return;
                }

                int newBalance = currentBalance;

                // DEPOSIT
                if (comboBox1.Text == "Deposit")
                {
                    newBalance =
                        currentBalance + amount;
                }

                // WITHDRAW
                else if (comboBox1.Text == "Withdraw")
                {
                    newBalance =
                        currentBalance - amount;
                }

                textBoxBalanceAfter.Text =
                    newBalance.ToString();
            }

            catch
            {

            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                string query = "";

                // TRANSACTION ID
                if (comboBoxSearch.Text == "Transaction ID")
                {
                    query = "select * from transactions where TID=@value";
                }

                // ACCOUNT ID
                else if (comboBoxSearch.Text == "Account ID")
                {
                    query = "select * from transactions where Account_Id=@value";
                }

                // TRANSACTION TYPE
                else if (comboBoxSearch.Text == "Transaction Type")
                {
                    query = "select * from transactions where Transaction_Type like @value";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                // PARTIAL SEARCH
                if (comboBoxSearch.Text == "Transaction Type")
                {
                    cmd.Parameters.AddWithValue(
                        "@value",
                        "%" + textBoxSearch.Text + "%");
                }

                // EXACT SEARCH
                else
                {
                    cmd.Parameters.AddWithValue(
                        "@value",
                        textBoxSearch.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();

                da.Fill(table);

                dataGridView1.DataSource = table;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Enter search value...")
            {
                textBoxSearch.Text = "";

                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                textBoxSearch.Text = "Enter search value...";

                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxAccount.SelectedIndex = -1;

            comboBox1.SelectedIndex = -1;

            textBox3.Clear();

            textBoxBalanceBefore.Clear();

            textBoxBalanceAfter.Clear();

            textBoxRemarks.Clear();

            dateTimePicker2.Value = DateTime.Now;

            comboBoxAccount.Focus();
        }

        private void btnDateSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"select * from transactions
              where CAST(Transaction_Date as date)=@date",
                    con);

                cmd.Parameters.AddWithValue(
                    "@date",
                    dateTimePickerSearch.Value.Date);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();

                da.Fill(table);

                dataGridView1.DataSource = table;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
