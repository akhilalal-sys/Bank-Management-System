using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            // VALIDATION

            // Customer Name Required
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Customer Name is required!");
                textBox2.Focus();
                return;
            }

            // Minimum Length
            if (textBox2.Text.Length < 3)
            {
                MessageBox.Show("Customer Name must contain at least 3 characters!");
                textBox2.Focus();
                return;
            }

            // Only Letters and Spaces
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                textBox2.Text,
                @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Customer Name should contain only letters!");
                textBox2.Focus();
                return;
            }

            // Phone Required
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Phone Number is required!");
                textBox3.Focus();
                return;
            }

            // Phone Validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                textBox3.Text,
                @"^\d{10}$"))
            {
                MessageBox.Show("Phone number must be exactly 10 digits!");
                textBox3.Focus();
                return;
            }

            // Email Required
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("Email is required!");
                textBox5.Focus();
                return;
            }

            // Email Validation
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                textBox5.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid Email Address!");
                textBox5.Focus();
                return;
            }

            // Address Required
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Address is required!");
                textBox4.Focus();
                return;
            }

            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            try
            {
                con.Open();
                // DUPLICATE PHONE CHECK

                SqlCommand phoneCheck = new SqlCommand(
                    "select count(*) from customers where phone=@phone and customer_id!=@customer_id",
                    con);

                phoneCheck.Parameters.AddWithValue(
                    "@phone",
                    textBox3.Text);

                // FOR INSERT textBox1 may be empty
                if (textBox1.Text == "")
                {
                    phoneCheck.Parameters.AddWithValue(
                        "@customer_id",
                        0);
                }
                else
                {
                    phoneCheck.Parameters.AddWithValue(
                        "@customer_id",
                        int.Parse(textBox1.Text));
                }

                int phoneExists = (int)phoneCheck.ExecuteScalar();

                if (phoneExists > 0)
                {
                    MessageBox.Show("Phone number already exists!");

                    textBox3.Focus();

                    return;
                }


                // DUPLICATE EMAIL CHECK

                SqlCommand emailCheck = new SqlCommand(
                    "select count(*) from customers where email=@email and customer_id!=@customer_id",
                    con);

                emailCheck.Parameters.AddWithValue(
                    "@email",
                    textBox5.Text);

                if (textBox1.Text == "")
                {
                    emailCheck.Parameters.AddWithValue(
                        "@customer_id",
                        0);
                }
                else
                {
                    emailCheck.Parameters.AddWithValue(
                        "@customer_id",
                        int.Parse(textBox1.Text));
                }

                int emailExists = (int)emailCheck.ExecuteScalar();

                if (emailExists > 0)
                {
                    MessageBox.Show("Email already exists!");

                    textBox5.Focus();

                    return;
                }
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
                    LoadCustomerData();
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
                    LoadCustomerData();
                }

                // CLEAR FIELDS
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                // CURSOR FOCUS
                textBox2.Focus();
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
            SqlCommand cnn = new SqlCommand("select * from customers where Status='Active'", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            comboBoxStatus.SelectedIndex = 0;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();
                DialogResult result = MessageBox.Show(
                                            "Are you sure you want to deactivate this customer?",
                                            "Confirm",
                                             MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    "update customers set Status='Inactive' where customer_id=@customer_id",
                    con);

                cmd.Parameters.AddWithValue(
                    "@customer_id",
                    int.Parse(textBox1.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Deactivated Successfully!");
                // CLOSE NORMAL ACCOUNTS

                SqlCommand closeAccounts = new SqlCommand(
                    @"update accounts
      set Account_Status='Closed'
      where Customer_ID=@Customer_ID
      and Account_Type!='Fixed Deposit'",
                    con);

                closeAccounts.Parameters.AddWithValue(
                    "@Customer_ID",
                    int.Parse(textBox1.Text));

                closeAccounts.ExecuteNonQuery();


                // FREEZE FD ACCOUNTS

                SqlCommand freezeFD = new SqlCommand(
                    @"update accounts
      set Account_Status='Frozen'
      where Customer_ID=@Customer_ID
      and Account_Type='Fixed Deposit'",
                    con);

                freezeFD.Parameters.AddWithValue(
                    "@Customer_ID",
                    int.Parse(textBox1.Text));

                freezeFD.ExecuteNonQuery();
                LoadCustomerData();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Customer_Load_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand cnn = new SqlCommand("select * from customers where Status='Active'", con);
            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // SEARCH PLACEHOLDER
            textBoxSearch.Text = "Enter search value...";
            textBoxSearch.ForeColor = Color.Gray;

            // DEFAULT SEARCH TYPE
            comboBoxSearch.SelectedIndex = 0;

            // DEFAULT STATUS
            comboBoxStatus.SelectedItem = "Active";

            // LOAD GRID
            LoadCustomerData();
        }
        public void LoadCustomerData()
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "select * from customers where Status='Active'",
                con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

            con.Close();
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
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            textBox2.Focus();


            textBoxSearch.Clear();

            comboBoxSearch.SelectedIndex = -1;
            LoadCustomerData();

            Customer_Load(null, null);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                string query = "";

                // STATUS FILTER
                string statusCondition = "";

                if (comboBoxStatus.Text == "Active")
                {
                    statusCondition = " Status='Active'";
                }

                else if (comboBoxStatus.Text == "Inactive")
                {
                    statusCondition = " Status='Inactive'";
                }

                else if (comboBoxStatus.Text == "All" ||
                         comboBoxStatus.Text == "")
                {
                    statusCondition = " 1=1 ";
                }

                // ONLY STATUS FILTER
                if (textBoxSearch.Text.Trim() == "" ||
                    textBoxSearch.Text == "Enter search value...")
                {
                    query = "select * from customers where "
                            + statusCondition;

                    SqlDataAdapter da1 = new SqlDataAdapter(query, con);

                    DataTable table1 = new DataTable();

                    da1.Fill(table1);

                    dataGridView1.DataSource = table1;

                    con.Close();

                    return;
                }

                // SEARCH TYPE VALIDATION
                if (comboBoxSearch.Text == "Select Search Type" ||
                    comboBoxSearch.Text == "")
                {
                    MessageBox.Show("Please select search type!");
                    comboBoxSearch.Focus();
                    return;
                }

                // CUSTOMER ID
                if (comboBoxSearch.Text == "Customer ID")
                {
                    query = "select * from customers where customer_id=@value and "
                            + statusCondition;
                }

                // CUSTOMER NAME
                else if (comboBoxSearch.Text == "Customer Name")
                {
                    query = "select * from customers where customer_name like @value and "
                            + statusCondition;
                }

                // PHONE
                else if (comboBoxSearch.Text == "Phone")
                {
                    query = "select * from customers where phone like @value and "
                            + statusCondition;
                }

                // EMAIL
                else if (comboBoxSearch.Text == "Email")
                {
                    query = "select * from customers where email like @value and "
                            + statusCondition;
                }

                SqlCommand cmd = new SqlCommand(query, con);

                // EXACT SEARCH FOR CUSTOMER ID
                if (comboBoxSearch.Text == "Customer ID")
                {
                    cmd.Parameters.AddWithValue(
                        "@value",
                        int.Parse(textBoxSearch.Text));
                }

                // PARTIAL SEARCH FOR OTHERS
                else
                {
                    cmd.Parameters.AddWithValue(
                        "@value",
                        "%" + textBoxSearch.Text + "%");
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
            if (textBoxSearch.Text == "")
            {
                textBoxSearch.Text = "Enter search value...";
                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void btnReactivate_Click(object sender, EventArgs e)
        {
            try
            {
                // CHECK CUSTOMER SELECTED
                if (textBox1.Text == "")
                {
                    MessageBox.Show(
                        "Please select inactive customer!");

                    return;
                }

                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                // REACTIVATE CUSTOMER
                SqlCommand cmd = new SqlCommand(
                    "update customers set Status='Active' where customer_id=@customer_id",
                    con);

                cmd.Parameters.AddWithValue(
                    "@customer_id",
                    int.Parse(textBox1.Text));

                cmd.ExecuteNonQuery();

                // REACTIVATE ALL RELATED ACCOUNTS
                SqlCommand reactivateAccounts = new SqlCommand(
                    @"update accounts
              set Account_Status='Active'
              where Customer_ID=@Customer_ID",
                    con);

                reactivateAccounts.Parameters.AddWithValue(
                    "@Customer_ID",
                    int.Parse(textBox1.Text));

                reactivateAccounts.ExecuteNonQuery();

                MessageBox.Show(
                    "Customer and related accounts reactivated successfully!");

                // REFRESH GRID
                LoadCustomerData();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSearch.PerformClick();
        }
    }
}
