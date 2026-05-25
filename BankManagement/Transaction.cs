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
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            try
            {
                con.Open();

                int accountId = int.Parse(textBox4.Text);
                int amount = int.Parse(textBox3.Text);

                // GET CURRENT BALANCE
                SqlCommand getBalance = new SqlCommand(
                    "select Balance from accounts where Account_ID=@Account_ID", con);

                getBalance.Parameters.AddWithValue("@Account_ID", accountId);

                int currentBalance = Convert.ToInt32(getBalance.ExecuteScalar());

                int newBalance = currentBalance;

                // DEPOSIT
                if (comboBox1.Text == "Deposit")
                {
                    newBalance = currentBalance + amount;
                }

                // WITHDRAW
                else if (comboBox1.Text == "Withdraw")
                {
                    if (amount > currentBalance)
                    {
                        MessageBox.Show("Insufficient Balance!");
                        return;
                    }

                    newBalance = currentBalance - amount;
                }

                // UPDATE EXISTING TRANSACTION
                

                
                    SqlCommand insertTransaction = new SqlCommand(
                        "insert into transactions(Transaction_Type,Amount,Transaction_Date,Account_Id) values(@type,@amount,@date,@accountid)",
                        con);

                    insertTransaction.Parameters.AddWithValue("@type", comboBox1.Text);
                    insertTransaction.Parameters.AddWithValue("@amount", amount);
                    insertTransaction.Parameters.AddWithValue("@date", dateTimePicker2.Value);
                    insertTransaction.Parameters.AddWithValue("@accountid", accountId);

                    insertTransaction.ExecuteNonQuery();

                    MessageBox.Show("Transaction Saved Successfully!");
                

                // UPDATE ACCOUNT BALANCE
                SqlCommand updateBalance = new SqlCommand(
                    "update accounts set Balance=@Balance where Account_ID=@Account_ID", con);

                updateBalance.Parameters.AddWithValue("@Balance", newBalance);
                updateBalance.Parameters.AddWithValue("@Account_ID", accountId);

                updateBalance.ExecuteNonQuery();

                // CLEAR FIELDS
                textBox5.Clear();
                textBox3.Clear();
                textBox4.Clear();

                comboBox1.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from transactions", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete transactions where tid=@tid", con);
            cnn.Parameters.AddWithValue("TID", int.Parse(textBox5.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully Successfullly!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from transactions", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox5.Text = row.Cells["TID"].Value.ToString();

                comboBox1.Text = row.Cells["Transaction_Type"].Value.ToString();

                textBox3.Text = row.Cells["Amount"].Value.ToString();

                dateTimePicker2.Value =
                    Convert.ToDateTime(row.Cells["Transaction_Date"].Value);

                textBox4.Text = row.Cells["Account_Id"].Value.ToString();
            }
        }
    }
}
