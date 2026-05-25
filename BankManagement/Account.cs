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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                // UPDATE
                if (textBox5.Text != "")
                {
                    SqlCommand cnn = new SqlCommand(
                        "update accounts set Account_Type=@Account_Type, Balance=@Balance, Date_Opened=@Date_Opened, Customer_ID=@Customer_ID where Account_ID=@Account_ID",
                        con);

                    cnn.Parameters.AddWithValue("@Account_ID", int.Parse(textBox5.Text));
                    cnn.Parameters.AddWithValue("@Account_Type", textBox2.Text);
                    cnn.Parameters.AddWithValue("@Balance", textBox3.Text);
                    cnn.Parameters.AddWithValue("@Date_Opened", dateTimePicker1.Value);
                    cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(textBox4.Text));

                    cnn.ExecuteNonQuery();

                    MessageBox.Show("Record Updated Successfully!");
                }

                // INSERT
                else
                {
                    SqlCommand cnn = new SqlCommand(
                        "insert into accounts(Account_Type,Balance,Date_Opened,Customer_ID) values(@Account_Type,@Balance,@Date_Opened,@Customer_ID)",
                        con);

                    cnn.Parameters.AddWithValue("@Account_Type", textBox2.Text);
                    cnn.Parameters.AddWithValue("@Balance", textBox3.Text);
                    cnn.Parameters.AddWithValue("@Date_Opened", dateTimePicker1.Value);
                    cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(textBox4.Text));

                    cnn.ExecuteNonQuery();

                    MessageBox.Show("Record Saved Successfully!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from accounts", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete accounts where account_id=@account_id", con);
            cnn.Parameters.AddWithValue("Account_ID", int.Parse(textBox5.Text));
            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfullly!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from accounts", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from accounts where customer_ID=@customer_ID", con);
            cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(textBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            con.Close();
            dataGridView1.DataSource = table;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox5.Text = row.Cells["Account_ID"].Value.ToString().PadLeft(3, '0'); ;
                textBox2.Text = row.Cells["Account_Type"].Value.ToString();
                textBox3.Text = row.Cells["Balance"].Value.ToString();

                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Date_Opened"].Value);

                textBox4.Text = row.Cells["Customer_ID"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
