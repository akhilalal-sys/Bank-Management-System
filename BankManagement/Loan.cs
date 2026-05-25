using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace BankManagement
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete loans where loan_id=@loan_id", con);
            cnn.Parameters.AddWithValue("Loan_ID", int.Parse(textBox5.Text));

            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfullly!");
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker3.CustomFormat = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            try
            {
                con.Open();

                // UPDATE
                if (textBox5.Text != "")
                {
                    SqlCommand cnn = new SqlCommand(
                        "update loans set Loan_Type=@Loan_Type, Amount=@Amount, Interest_Rate=@Interest_Rate, Loan_Date=@Loan_Date, Customer_ID=@Customer_ID where Loan_ID=@Loan_ID",
                        con);

                    cnn.Parameters.AddWithValue("@Loan_ID", int.Parse(textBox5.Text));
                    cnn.Parameters.AddWithValue("@Loan_Type", comboBox1.Text);
                    cnn.Parameters.AddWithValue("@Amount", int.Parse(textBox3.Text));
                    cnn.Parameters.AddWithValue("@Interest_Rate", textBox1.Text);
                    cnn.Parameters.AddWithValue("@Loan_Date", dateTimePicker3.Value);
                    cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(textBox4.Text));

                    cnn.ExecuteNonQuery();

                    MessageBox.Show("Record Updated Successfully!");
                    textBox5.Clear();
                    textBox3.Clear();
                    textBox1.Clear();
                    textBox4.Clear();

                    comboBox1.SelectedIndex = -1;

                    dateTimePicker3.Value = DateTime.Now;
                }

                // INSERT
                else
                {
                    SqlCommand cnn = new SqlCommand(
                        "insert into loans(Loan_Type,Amount,Interest_Rate,Loan_Date,Customer_ID) values(@Loan_Type,@Amount,@Interest_Rate,@Loan_Date,@Customer_ID)",
                        con);

                    cnn.Parameters.AddWithValue("@Loan_Type", comboBox1.Text);
                    cnn.Parameters.AddWithValue("@Amount", int.Parse(textBox3.Text));
                    cnn.Parameters.AddWithValue("@Interest_Rate", textBox1.Text);
                    cnn.Parameters.AddWithValue("@Loan_Date", dateTimePicker3.Value);
                    cnn.Parameters.AddWithValue("@Customer_ID", int.Parse(textBox4.Text));

                    cnn.ExecuteNonQuery();

                    MessageBox.Show("Record Saved Successfully!");
                    textBox5.Clear();
                    textBox3.Clear();
                    textBox1.Clear();
                    textBox4.Clear();

                    comboBox1.SelectedIndex = -1;

                    dateTimePicker3.Value = DateTime.Now;
                }
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
            SqlCommand cnn = new SqlCommand("select * from loans", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        

        private void Loan_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from loans", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                textBox5.Text = row.Cells["Loan_ID"].Value.ToString();

                comboBox1.Text = row.Cells["Loan_Type"].Value.ToString();

                textBox3.Text = row.Cells["Amount"].Value.ToString();

                textBox1.Text = row.Cells["Interest_Rate"].Value.ToString();

                dateTimePicker3.Value =
                    Convert.ToDateTime(row.Cells["Loan_Date"].Value);

                textBox4.Text = row.Cells["Customer_ID"].Value.ToString();
            }
        }
    }
}
