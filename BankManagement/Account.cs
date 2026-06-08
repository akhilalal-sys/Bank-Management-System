using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


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
            // VALIDATION

            // ACCOUNT TYPE REQUIRED
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select Account Type!");
                comboBox1.Focus();
                return;
            }

            // BALANCE REQUIRED
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Balance is required!");
                textBox3.Focus();
                return;
            }

            // BALANCE MUST BE NUMERIC
            if (!decimal.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("Balance must be numeric!");
                textBox3.Focus();
                return;
            }

            // ONLY NUMBERS
            if (!System.Text.RegularExpressions.Regex.IsMatch(
                textBox3.Text,
                @"^\d+$"))
            {
                MessageBox.Show("Balance must contain numbers only!");
                textBox3.Focus();
                return;
            }

            // CUSTOMER REQUIRED
            if (comboBox2.Text.Trim() == "")
            {
                MessageBox.Show("Customer is required!");
                comboBox2.Focus();
                return;
            }

            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            try
            {
                // GET CUSTOMER ID FROM:
                // "1 - Akhil"

                string[] parts = comboBox2.Text.Split('-');

                int customerId = int.Parse(parts[0].Trim());

                con.Open();

                // ONLY ONE SAVINGS / CURRENT / SALARY ACCOUNT
                if (comboBox1.Text != "FD" && textBox5.Text == "")
                {
                    SqlCommand checkCmd = new SqlCommand(
                        "select count(*) from accounts where Customer_ID=@Customer_ID and Account_Type=@Account_Type and Account_Status='Active'",
                        con);

                    checkCmd.Parameters.AddWithValue(
                        "@Customer_ID",
                        customerId);

                    checkCmd.Parameters.AddWithValue(
                        "@Account_Type",
                        comboBox1.Text);

                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show(
                            "Customer already has this account type!");

                        return;
                    }
                }

                // UPDATE
                if (textBox5.Text != "")
                {
                    SqlCommand cnn = new SqlCommand(
                        @"update accounts 
                  set Account_Type=@Account_Type,
                      Balance=@Balance,
                      Date_Opened=@Date_Opened,
                      Customer_ID=@Customer_ID
                  where Account_ID=@Account_ID",
                        con);

                    cnn.Parameters.AddWithValue(
                        "@Account_ID",
                        int.Parse(textBox5.Text));

                    cnn.Parameters.AddWithValue(
                        "@Account_Type",
                        comboBox1.Text);

                    cnn.Parameters.AddWithValue(
                        "@Balance",
                        int.Parse(textBox3.Text));

                    cnn.Parameters.AddWithValue(
                        "@Date_Opened",
                        dateTimePicker1.Value);

                    cnn.Parameters.AddWithValue(
                        "@Customer_ID",
                        customerId);

                    cnn.ExecuteNonQuery();

                    MessageBox.Show(
                        "Account Updated Successfully!");

                    // AUTO REFRESH GRID
                    LoadAccountData();
                }

                // INSERT
                else
                {
                    SqlCommand cnn = new SqlCommand(
                        @"insert into accounts
                  (Account_Type,Balance,Date_Opened,Customer_ID)
                  values
                  (@Account_Type,@Balance,@Date_Opened,@Customer_ID)",
                        con);

                    cnn.Parameters.AddWithValue(
                        "@Account_Type",
                        comboBox1.Text);

                    cnn.Parameters.AddWithValue(
                        "@Balance",
                        int.Parse(textBox3.Text));

                    cnn.Parameters.AddWithValue(
                        "@Date_Opened",
                        dateTimePicker1.Value);

                    cnn.Parameters.AddWithValue(
                        "@Customer_ID",
                        customerId);

                    cnn.ExecuteNonQuery();

                    MessageBox.Show(
                        "Account Saved Successfully!");

                    // AUTO REFRESH GRID
                    LoadAccountData();
                }

                // CLEAR FIELDS
                textBox5.Clear();

                textBox3.Clear();

                textBoxCustomerName.Clear();

                comboBox1.SelectedIndex = -1;

                comboBox2.SelectedIndex = -1;

                dateTimePicker1.Value = DateTime.Now;

                comboBox1.Focus();
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
            comboBoxStatus.SelectedIndex = 0;
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // ACCOUNT SELECTION CHECK
                if (textBox5.Text == "")
                {
                    MessageBox.Show(
                        "Please select account!");

                    return;
                }

                // CONFIRMATION
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to close this account?",
                    "Confirm",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                // SOFT DELETE / CLOSE ACCOUNT
                SqlCommand cmd = new SqlCommand(
                    "update accounts set Account_Status='Closed' where Account_ID=@Account_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@Account_ID",
                    int.Parse(textBox5.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Account Closed Successfully!");

                // AUTO REFRESH GRID
                LoadAccountData();


                // CLEAR FIELDS
                textBox5.Clear();
                textBox3.Clear();
                textBoxCustomerName.Clear();

                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;

                dateTimePicker1.Value = DateTime.Now;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            // LOAD GRID
            comboBoxStatus.SelectedItem = "Active";
            LoadAccountData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.ReadOnly = true;

            // SEARCH PLACEHOLDER
            textBoxSearch.Text = "Enter search value...";
            textBoxSearch.ForeColor = Color.Gray;

            // DEFAULT SEARCH TYPE
            comboBoxSearch.SelectedIndex = 0;

            // DEFAULT STATUS
            comboBoxStatus.SelectedItem = "Active";

            // CLEAR OLD ITEMS
            comboBox2.Items.Clear();

            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            // LOAD ONLY ACTIVE CUSTOMERS
            SqlCommand cmd = new SqlCommand(
                "select customer_id, customer_name from customers where Status='Active'",
                con);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox2.Items.Add(
                    dr["customer_id"].ToString()
                    + " - " +
                    dr["customer_name"].ToString());
            }

            con.Close();
        }
        public void LoadAccountData()
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            string query = "";

            // ACTIVE
            if (comboBoxStatus.Text == "Active")
            {
                query =
                    "select * from accounts where Account_Status='Active'";
            }

            // CLOSED
            else if (comboBoxStatus.Text == "Closed")
            {
                query =
                    "select * from accounts where Account_Status='Closed'";
            }

            // FROZEN
            else if (comboBoxStatus.Text == "Frozen")
            {
                query =
                    "select * from accounts where Account_Status='Frozen'";
            }

            // ALL
            else
            {
                query =
                    "select * from accounts";
            }

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable table =
                new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

            con.Close();
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
                    statusCondition = " Account_Status='Active'";
                }

                else if (comboBoxStatus.Text == "Closed")
                {
                    statusCondition = " Account_Status='Closed'";
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
                    query = "select * from accounts where "
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
                    query = @"select * from accounts
                      where Customer_ID=@value
                      and " + statusCondition;
                }

                // ACCOUNT ID
                else if (comboBoxSearch.Text == "Account ID")
                {
                    query = @"select * from accounts
                      where Account_ID=@value
                      and " + statusCondition;
                }

                // CUSTOMER NAME
                else if (comboBoxSearch.Text == "Customer Name")
                {
                    query = @"select a.*
                      from accounts a
                      inner join customers c
                      on a.Customer_ID = c.customer_id
                      where c.customer_name like @value
                      and " + statusCondition;
                }

                // ACCOUNT TYPE
                else if (comboBoxSearch.Text == "Account Type")
                {
                    query = @"select * from accounts
                      where Account_Type like @value
                      and " + statusCondition;
                }

                SqlCommand cmd = new SqlCommand(query, con);

                // PARTIAL SEARCH
                if (comboBoxSearch.Text == "Customer Name" ||
                    comboBoxSearch.Text == "Account Type")
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dataGridView1.Rows[e.RowIndex];

                textBox5.Text =
                    row.Cells["Account_ID"].Value.ToString();

                comboBox1.Text =
                    row.Cells["Account_Type"].Value.ToString();

                textBox3.Text =
                    row.Cells["Balance"].Value.ToString();

                dateTimePicker1.Value =
                    Convert.ToDateTime(
                        row.Cells["Date_Opened"].Value);

                string customerId =
                    row.Cells["Customer_ID"].Value.ToString();

                // FIND MATCHING ITEM IN COMBOBOX
                for (int i = 0; i < comboBox2.Items.Count; i++)
                {
                    if (comboBox2.Items[i].ToString()
                        .StartsWith(customerId + " -"))
                    {
                        comboBox2.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox5.Clear();

            textBox3.Clear();

            textBoxCustomerName.Clear();

            comboBox1.SelectedIndex = -1;

            comboBox2.SelectedIndex = -1;

            comboBoxSearch.SelectedIndex = 0;

            comboBoxStatus.SelectedItem = "Active";

            textBoxSearch.Text = "Enter search value...";

            textBoxSearch.ForeColor = Color.Gray;

            dateTimePicker1.Value = DateTime.Now;

            // AUTO REFRESH GRID
            LoadAccountData();

            comboBox1.Focus();
            textBoxSearch.Refresh();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "")
            {
                string[] parts = comboBox2.Text.Split('-');

                string customerId = parts[0].Trim();

                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "select customer_name from customers where customer_id=@id", con);

                cmd.Parameters.AddWithValue("@id", customerId);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    textBoxCustomerName.Text = result.ToString();
                }

                con.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReactivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show(
                        "Please select closed account!");

                    return;
                }

                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "update accounts set Account_Status='Active' where Account_ID=@Account_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@Account_ID",
                    int.Parse(textBox5.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Account Reopened Successfully!");

                LoadAccountData();

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

        private void btnSearch_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Trim() == "")
            {
                textBoxSearch.Text = "Enter search value...";

                textBoxSearch.ForeColor = Color.Gray;
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadAccountData();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
