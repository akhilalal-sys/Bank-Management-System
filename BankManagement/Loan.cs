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
            try
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show(
                        "Please select loan!");

                    return;
                }

                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "update loans set Loan_Status='Closed' where Loan_ID=@Loan_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@Loan_ID",
                    int.Parse(textBox5.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Loan Closed Successfully!");

                LoadLoanData();

                // CLEAR
                textBox5.Clear();

                textBox3.Clear();

                textBox1.Clear();

                textBoxCustomerName.Clear();

                textBoxRemaining.Clear();

                textBoxEMI.Clear();

                comboBox1.SelectedIndex = -1;

                comboBoxCustomer.SelectedIndex = -1;

                dateTimePicker3.Value = DateTime.Now;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            try
            {
                // LOAN TYPE REQUIRED
                if (comboBox1.Text == "")
                {
                    MessageBox.Show(
                        "Please select loan type!");

                    comboBox1.Focus();

                    return;
                }

                // AMOUNT REQUIRED
                if (textBox3.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Amount is required!");

                    textBox3.Focus();

                    return;
                }

                // AMOUNT MUST BE NUMERIC
                if (!decimal.TryParse(textBox3.Text, out _))
                {
                    MessageBox.Show(
                        "Amount must be numeric!");

                    textBox3.Focus();

                    return;
                }

                // AMOUNT GREATER THAN 0
                if (Convert.ToDecimal(textBox3.Text) <= 0)
                {
                    MessageBox.Show(
                        "Amount must be greater than zero!");

                    textBox3.Focus();

                    return;
                }

                // INTEREST RATE REQUIRED
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show(
                        "Interest Rate is required!");

                    textBox1.Focus();

                    return;
                }

                // INTEREST RATE MUST BE NUMERIC
                if (!decimal.TryParse(textBox1.Text, out _))
                {
                    MessageBox.Show(
                        "Interest Rate must be numeric!");

                    textBox1.Focus();

                    return;
                }

                // INTEREST RATE RANGE
                decimal rate =
                    Convert.ToDecimal(textBox1.Text);

                if (rate < 1 || rate > 100)
                {
                    MessageBox.Show(
                        "Interest Rate must be between 1 and 100!");

                    textBox1.Focus();

                    return;
                }

                // CUSTOMER REQUIRED
                if (comboBoxCustomer.Text == "")
                {
                    MessageBox.Show(
                        "Please select customer!");

                    comboBoxCustomer.Focus();

                    return;
                }

                // GET CUSTOMER ID
                string[] parts =
                    comboBoxCustomer.Text.Split('-');

                int customerId =
                    int.Parse(parts[0].Trim());

                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                // DUPLICATE LOAN CHECK
                // MULTIPLE PERSONAL LOANS ALLOWED

                if (comboBox1.Text != "Personal")
                {
                    SqlCommand checkCmd = new SqlCommand(
                        @"select count(*)
                  from loans
                  where Customer_ID=@Customer_ID
                  and Loan_Type=@Loan_Type
                  and Loan_Status='Active'
                  and Loan_ID!=@Loan_ID",
                        con);

                    checkCmd.Parameters.AddWithValue(
                        "@Customer_ID",
                        customerId);

                    checkCmd.Parameters.AddWithValue(
                        "@Loan_Type",
                        comboBox1.Text);

                    // INSERT
                    if (textBox5.Text == "")
                    {
                        checkCmd.Parameters.AddWithValue(
                            "@Loan_ID",
                            0);
                    }

                    // UPDATE
                    else
                    {
                        checkCmd.Parameters.AddWithValue(
                            "@Loan_ID",
                            int.Parse(textBox5.Text));
                    }

                    int count =
                        (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show(
                            "Customer already has an active "
                            + comboBox1.Text
                            + " loan!");

                        return;
                    }
                }

                // CHECK CUSTOMER STATUS

                SqlCommand statusCmd = new SqlCommand(
                    "select Status from customers where customer_id=@customer_id",
                    con);

                statusCmd.Parameters.AddWithValue(
                    "@customer_id",
                    customerId);

                string customerStatus =
                    statusCmd.ExecuteScalar().ToString();

                if (customerStatus != "Active")
                {
                    MessageBox.Show(
                        "Loans cannot be created for inactive customers!");

                    return;
                }

                // UPDATE
                if (textBox5.Text != "")
                {
                    SqlCommand cmd = new SqlCommand(
                        @"update loans
                  set Loan_Type=@Loan_Type,
                      Amount=@Amount,
                      Interest_Rate=@Interest_Rate,
                      Loan_Date=@Loan_Date,
                      Customer_ID=@Customer_ID,
                      Remaining_Amount=@Remaining,
                      EMI=@EMI
                        Loan_Years=@Years,
                    Total_Payable=@Total
                      where Loan_ID=@Loan_ID
                    ",
                        con);

                    cmd.Parameters.AddWithValue(
                        "@Loan_ID",
                        int.Parse(textBox5.Text));

                    cmd.Parameters.AddWithValue(
                        "@Loan_Type",
                        comboBox1.Text);

                    cmd.Parameters.AddWithValue(
                        "@Amount",
                        int.Parse(textBox3.Text));

                    cmd.Parameters.AddWithValue(
                        "@Interest_Rate",
                        textBox1.Text);

                    cmd.Parameters.AddWithValue(
                        "@Loan_Date",
                        dateTimePicker3.Value);

                    cmd.Parameters.AddWithValue(
                        "@Customer_ID",
                        customerId);

                    cmd.Parameters.AddWithValue(
                        "@Remaining",
                        textBoxRemaining.Text);

                    cmd.Parameters.AddWithValue(
                        "@EMI",
                        textBoxEMI.Text);
                    cmd.Parameters.AddWithValue(
                         "@Years",
                        textBoxYears.Text);

                    cmd.Parameters.AddWithValue(
                        "@Total",
                        textBoxTotal.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Loan Updated Successfully!");
                }

                // INSERT
                else
                {
                    SqlCommand cmd = new SqlCommand(
                        @"insert into loans
(
    Loan_Type,
    Amount,
    Interest_Rate,
    Loan_Date,
    Customer_ID,
    Remaining_Amount,
    EMI,
    Loan_Years,
    Total_Payable
)
values
(
    @Loan_Type,
    @Amount,
    @Interest_Rate,
    @Loan_Date,
    @Customer_ID,
    @Remaining,
    @EMI,
    @Years,
    @Total
)",
                        con);

                    cmd.Parameters.AddWithValue(
                        "@Loan_Type",
                        comboBox1.Text);

                    cmd.Parameters.AddWithValue(
                        "@Amount",
                        int.Parse(textBox3.Text));

                    cmd.Parameters.AddWithValue(
                        "@Interest_Rate",
                        textBox1.Text);

                    cmd.Parameters.AddWithValue(
                        "@Loan_Date",
                        dateTimePicker3.Value);

                    cmd.Parameters.AddWithValue(
                        "@Customer_ID",
                        customerId);

                    cmd.Parameters.AddWithValue(
                        "@Remaining",
                        textBoxRemaining.Text);

                    cmd.Parameters.AddWithValue(
                        "@EMI",
                        textBoxEMI.Text);

                    // SAVE ACTIVE STATUS
                    cmd.Parameters.AddWithValue(
                        "@Status",
                        "Active");
                    cmd.Parameters.AddWithValue(
                         "@Years",
                         textBoxYears.Text);

                    cmd.Parameters.AddWithValue(
                        "@Total",
                        textBoxTotal.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Loan Saved Successfully!");
                }

                // AUTO REFRESH GRID
                LoadLoanData();

                // CLEAR FIELDS
                textBox5.Clear();

                textBox3.Clear();

                textBox1.Clear();

                textBoxCustomerName.Clear();

                textBoxRemaining.Clear();

                textBoxEMI.Clear();

                comboBox1.SelectedIndex = -1;

                comboBoxCustomer.SelectedIndex = -1;

                dateTimePicker3.Value = DateTime.Now;

                comboBox1.Focus();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            LoadLoanData();
            textBoxSearch.Text = "Enter search value...";
            textBoxSearch.ForeColor = Color.Gray;

            comboBoxSearch.SelectedIndex = 0;

            comboBoxStatus.SelectedItem = "Active";

            // LOAD CUSTOMERS
            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "select customer_id, customer_name from customers where Status='Active'",
                con);

            SqlDataReader dr = cmd.ExecuteReader();

            comboBoxCustomer.Items.Clear();

            while (dr.Read())
            {
                comboBoxCustomer.Items.Add(
                    dr["customer_id"].ToString()
                    + " - " +
                    dr["customer_name"].ToString());
            }

            con.Close();

            // LOAN TYPES
            comboBox1.Items.Clear();

            comboBox1.Items.Add("Personal");
            comboBox1.Items.Add("Home");
            comboBox1.Items.Add("Vehicle");
            comboBox1.Items.Add("Education");
            comboBox1.Items.Add("Gold");
            comboBox1.Items.Add("Business");

            // GRID SETTINGS
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.ReadOnly = true;
        }
        public void LoadLoanData()
        {
            SqlConnection con = new SqlConnection(
                @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

            con.Open();

            SqlCommand cmd = new SqlCommand(
                "select * from loans where Loan_Status='Active'",
                con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dataGridView1.Rows[e.RowIndex];

                textBox5.Text =
                    row.Cells["Loan_ID"].Value.ToString();

                comboBox1.Text =
                    row.Cells["Loan_Type"].Value.ToString();

                textBox3.Text =
                    row.Cells["Amount"].Value.ToString();

                textBox1.Text =
                    row.Cells["Interest_Rate"].Value.ToString();

                dateTimePicker3.Value =
                    Convert.ToDateTime(
                        row.Cells["Loan_Date"].Value);

                textBoxRemaining.Text =
                    row.Cells["Remaining_Amount"].Value.ToString();

                textBoxEMI.Text =
                    row.Cells["EMI"].Value.ToString();

                string customerId =
                    row.Cells["Customer_ID"].Value.ToString();

                for (int i = 0; i < comboBoxCustomer.Items.Count; i++)
                {
                    if (comboBoxCustomer.Items[i]
                        .ToString()
                        .StartsWith(customerId + " -"))
                    {
                        comboBoxCustomer.SelectedIndex = i;

                        break;
                    }
                }
            }
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomer.Text == "")
            {
                return;
            }

            string[] parts = comboBoxCustomer.Text.Split('-');

            textBoxCustomerName.Text = parts[1].Trim();
        }
        private void CalculateEMI()
        {
            try
            {
                if (textBox3.Text == "" ||
                    textBox1.Text == "" ||
                    textBoxYears.Text == "")
                {
                    return;
                }

                double amount =
                    Convert.ToDouble(textBox3.Text);

                double rate =
                    Convert.ToDouble(textBox1.Text);

                int years =
                    Convert.ToInt32(textBoxYears.Text);

                // SIMPLE INTEREST
                double interest =
                    (amount * rate * years) / 100;

                // TOTAL PAYABLE
                double totalPayable =
                    amount + interest;

                // MONTHS
                int months =
                    years * 12;

                // EMI
                double emi =
                    totalPayable / months;

                // DISPLAY
                textBoxTotal.Text =
                    Math.Round(totalPayable).ToString();

                textBoxEMI.Text =
                    Math.Round(emi).ToString();

                textBoxRemaining.Text =
                    Math.Round(totalPayable).ToString();
            }

            catch
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CalculateEMI();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CalculateEMI();
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
                    statusCondition = " Loan_Status='Active'";
                }

                else if (comboBoxStatus.Text == "Closed")
                {
                    statusCondition = " Loan_Status='Closed'";
                }

                else
                {
                    statusCondition = " 1=1 ";
                }

                // ONLY STATUS FILTER
                if (textBoxSearch.Text.Trim() == "" ||
                    textBoxSearch.Text == "Enter search value...")
                {
                    query =
                        "select * from loans where "
                        + statusCondition;

                    SqlDataAdapter da1 =
                        new SqlDataAdapter(query, con);

                    DataTable table1 = new DataTable();

                    da1.Fill(table1);

                    dataGridView1.DataSource = table1;

                    con.Close();

                    return;
                }

                // LOAN ID
                if (comboBoxSearch.Text == "Loan ID")
                {
                    query =
                        "select * from loans where Loan_ID=@value and "
                        + statusCondition;
                }

                // CUSTOMER NAME
                else if (comboBoxSearch.Text == "Customer Name")
                {
                    query =
                        @"select l.*
                  from loans l
                  inner join customers c
                  on l.Customer_ID = c.customer_id
                  where c.customer_name like @value
                  and "
                          + statusCondition;
                }

                // LOAN TYPE
                else if (comboBoxSearch.Text == "Loan Type")
                {
                    query =
                        "select * from loans where Loan_Type like @value and "
                        + statusCondition;
                }

                SqlCommand cmd = new SqlCommand(query, con);

                // PARTIAL SEARCH
                if (comboBoxSearch.Text == "Customer Name" ||
                    comboBoxSearch.Text == "Loan Type")
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

                SqlDataAdapter da =
                    new SqlDataAdapter(cmd);

                DataTable table =
                    new DataTable();

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
                textBoxSearch.Text =
                    "Enter search value...";

                textBoxSearch.ForeColor =
                    Color.Gray;
            }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text == "")
                {
                    MessageBox.Show(
                        "Please select loan!");

                    return;
                }

                SqlConnection con = new SqlConnection(
                    @"Data Source=AALAL-PC;Initial Catalog=BankDB;Integrated Security=True;Encrypt=False");

                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "update loans set Loan_Status='Active' where Loan_ID=@Loan_ID",
                    con);

                cmd.Parameters.AddWithValue(
                    "@Loan_ID",
                    int.Parse(textBox5.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Loan Reopened Successfully!");

                // AUTO REFRESH
                LoadLoanData();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox5.Clear();

            textBox3.Clear();

            textBox1.Clear();

            textBoxCustomerName.Clear();

            textBoxRemaining.Clear();

            textBoxEMI.Clear();

            comboBox1.SelectedIndex = -1;

            comboBoxCustomer.SelectedIndex = -1;

            comboBoxSearch.SelectedIndex = 0;

            comboBoxStatus.SelectedItem = "Active";

            textBoxSearch.Text =
                "Enter search value...";

            textBoxSearch.ForeColor =
                Color.Gray;

            dateTimePicker3.Value =
                DateTime.Now;

            // AUTO REFRESH
            LoadLoanData();

            comboBox1.Focus();
        }

        private void textBoxYears_TextChanged(object sender, EventArgs e)
        {
            CalculateEMI();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
