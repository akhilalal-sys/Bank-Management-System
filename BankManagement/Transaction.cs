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
            con.Open();
            SqlCommand cnn = new SqlCommand("insert into transactions values(@tid,@transaction_type,@amount,@transaction_date,@account_id)", con);
            cnn.Parameters.AddWithValue("TID", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@Transaction_Type", textBox2.Text);
            cnn.Parameters.AddWithValue("@Amount", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@Transaction_Date", dateTimePicker2.Value);
            cnn.Parameters.AddWithValue("@Account_Id", int.Parse(textBox4.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfullly!");

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("update transactions set transaction_type=@transaction_type,amount=@amount,transaction_date=@transaction_date,account_id=@account_id where tid=@tid", con);
            cnn.Parameters.AddWithValue("TID", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@Transaction_Type", textBox2.Text);
            cnn.Parameters.AddWithValue("@Amount", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@Transaction_Date", dateTimePicker2.Value);
            cnn.Parameters.AddWithValue("@Account_Id", int.Parse(textBox4.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfullly!");
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
    }
}
