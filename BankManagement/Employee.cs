using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankManagement
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            try
            {
                con.Open();

                // UPDATE
                if (textBox1.Text != "")
                {
                    SqlCommand cnn = new SqlCommand(
                        "update employees set Name=@Name, Position=@Position, Salary=@Salary where EID=@EID",
                        con);

                    cnn.Parameters.AddWithValue("@EID", int.Parse(textBox1.Text));
                    cnn.Parameters.AddWithValue("@Name", textBox2.Text);
                    cnn.Parameters.AddWithValue("@Position", comboBox1.Text);
                    cnn.Parameters.AddWithValue("@Salary", textBox4.Text);

                    cnn.ExecuteNonQuery();

                    MessageBox.Show("Record Updated Successfully!");
                }

                // INSERT
                else
                {
                    SqlCommand cnn = new SqlCommand(
                        "insert into employees(Name,Position,Salary) values(@Name,@Position,@Salary)",
                        con);

                    cnn.Parameters.AddWithValue("@Name", textBox2.Text);
                    cnn.Parameters.AddWithValue("@Position", comboBox1.Text);
                    cnn.Parameters.AddWithValue("@Salary", textBox4.Text);

                    cnn.ExecuteNonQuery();

                    MessageBox.Show("Record Saved Successfully!");
                }

                // CLEAR FIELDS
                textBox1.Clear();
                textBox2.Clear();
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
            SqlCommand cnn = new SqlCommand("select * from employees", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("delete employees where eid=@eid", con);
            cnn.Parameters.AddWithValue("@EID", int.Parse(textBox1.Text));


            cnn.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfullly!");
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from employees", con);
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

                textBox1.Text = row.Cells["EID"].Value.ToString();

                textBox2.Text = row.Cells["Name"].Value.ToString();

                comboBox1.Text = row.Cells["Position"].Value.ToString();

                textBox4.Text = row.Cells["Salary"].Value.ToString();
            }
        }
    }
}
