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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            // UPDATE
            if (textBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand(
                    "update customers set customer_name=@customer_name, phone=@phone, email=@email, address=@address where customer_id=@customer_id",
                    con);

                cmd.Parameters.AddWithValue("@customer_id", textBox1.Text);
                cmd.Parameters.AddWithValue("@customer_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@phone", textBox3.Text);
                cmd.Parameters.AddWithValue("@email", textBox5.Text);
                cmd.Parameters.AddWithValue("@address", textBox4.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Updated Successfully");
            }

            // INSERT
            else
            {
                SqlCommand cmd = new SqlCommand(
                    "insert into customers(customer_name,phone,email,address) values(@customer_name,@phone,@email,@address)",
                    con);

                cmd.Parameters.AddWithValue("@customer_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@phone", textBox3.Text);
                cmd.Parameters.AddWithValue("@email", textBox5.Text);
                cmd.Parameters.AddWithValue("@address", textBox4.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Saved Successfully");
            }

            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from customers", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete customers where customer_id=@customer_id", con);
            cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(textBox1.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfullly!");
        }

        private void Customer_Load_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from customers", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from customers", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from customers", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = row.Cells["Customer_ID"].Value.ToString();
                textBox2.Text = row.Cells["Customer_Name"].Value.ToString();
                textBox3.Text = row.Cells["Phone"].Value.ToString();
                textBox5.Text = row.Cells["Email"].Value.ToString();
                textBox4.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
        }
    }
}
