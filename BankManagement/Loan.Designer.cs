namespace BankManagement
{
    partial class Loan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            textBoxTotal = new TextBox();
            textBoxYears = new TextBox();
            label12 = new Label();
            label11 = new Label();
            btnClear = new Button();
            btnReopen = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            textBoxEMI = new TextBox();
            textBoxRemaining = new TextBox();
            textBoxCustomerName = new TextBox();
            comboBoxCustomer = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            btnDelete = new Button();
            btnSave = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            comboBoxStatus = new ComboBox();
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            comboBoxSearch = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1638, 87);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(706, 22);
            label1.Name = "label1";
            label1.Size = new Size(92, 45);
            label1.TabIndex = 0;
            label1.Text = "Loan";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxTotal);
            panel2.Controls.Add(textBoxYears);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnReopen);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBoxEMI);
            panel2.Controls.Add(textBoxRemaining);
            panel2.Controls.Add(textBoxCustomerName);
            panel2.Controls.Add(comboBoxCustomer);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(dateTimePicker3);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.YellowGreen;
            panel2.Location = new Point(11, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(1614, 352);
            panel2.TabIndex = 5;
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(246, 280);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(350, 31);
            textBoxTotal.TabIndex = 31;
            // 
            // textBoxYears
            // 
            textBoxYears.Location = new Point(924, 225);
            textBoxYears.Name = "textBoxYears";
            textBoxYears.Size = new Size(350, 31);
            textBoxYears.TabIndex = 30;
            textBoxYears.TextChanged += textBoxYears_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(50, 273);
            label12.Name = "label12";
            label12.Size = new Size(134, 28);
            label12.TabIndex = 29;
            label12.Text = "Total Payable";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(694, 225);
            label11.Name = "label11";
            label11.Size = new Size(110, 28);
            label11.TabIndex = 28;
            label11.Text = "Loan Years";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(1360, 163);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(137, 43);
            btnClear.TabIndex = 27;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnReopen
            // 
            btnReopen.BackColor = SystemColors.GradientActiveCaption;
            btnReopen.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReopen.ForeColor = Color.Black;
            btnReopen.Location = new Point(1360, 113);
            btnReopen.Name = "btnReopen";
            btnReopen.Size = new Size(137, 43);
            btnReopen.TabIndex = 26;
            btnReopen.Text = "Reopen";
            btnReopen.UseVisualStyleBackColor = false;
            btnReopen.Click += btnReopen_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(694, 20);
            label10.Name = "label10";
            label10.Size = new Size(161, 28);
            label10.TabIndex = 25;
            label10.Text = "Customer_Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(50, 225);
            label9.Name = "label9";
            label9.Size = new Size(45, 28);
            label9.TabIndex = 24;
            label9.Text = "EMI";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(694, 172);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 23;
            label8.Text = "Remaining";
            // 
            // textBoxEMI
            // 
            textBoxEMI.Location = new Point(246, 225);
            textBoxEMI.Margin = new Padding(4, 5, 4, 5);
            textBoxEMI.Name = "textBoxEMI";
            textBoxEMI.ReadOnly = true;
            textBoxEMI.Size = new Size(347, 31);
            textBoxEMI.TabIndex = 22;
            // 
            // textBoxRemaining
            // 
            textBoxRemaining.Location = new Point(924, 168);
            textBoxRemaining.Margin = new Padding(4, 5, 4, 5);
            textBoxRemaining.Name = "textBoxRemaining";
            textBoxRemaining.ReadOnly = true;
            textBoxRemaining.Size = new Size(350, 31);
            textBoxRemaining.TabIndex = 21;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(924, 13);
            textBoxCustomerName.Margin = new Padding(4, 5, 4, 5);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.ReadOnly = true;
            textBoxCustomerName.Size = new Size(350, 31);
            textBoxCustomerName.TabIndex = 20;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(246, 13);
            comboBoxCustomer.Margin = new Padding(4, 5, 4, 5);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(350, 33);
            comboBoxCustomer.TabIndex = 19;
            comboBoxCustomer.SelectedIndexChanged += comboBoxCustomer_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Personal", "Home", "Education", "Vehicle", "Gold", "Business" });
            comboBox1.Location = new Point(924, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(350, 33);
            comboBox1.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 173);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 31);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(50, 175);
            label7.Name = "label7";
            label7.Size = new Size(128, 28);
            label7.TabIndex = 16;
            label7.Text = "Interest_Rate";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(246, 68);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(350, 31);
            textBox5.TabIndex = 15;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.Location = new Point(924, 123);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(350, 31);
            dateTimePicker3.TabIndex = 14;
            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            dateTimePicker3.KeyDown += dateTimePicker3_KeyDown;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(1360, 63);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 43);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Close";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(1360, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(137, 43);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(246, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 31);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(46, 20);
            label6.Name = "label6";
            label6.Size = new Size(128, 28);
            label6.TabIndex = 4;
            label6.Text = "Customer_ID";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(694, 125);
            label5.Name = "label5";
            label5.Size = new Size(107, 28);
            label5.TabIndex = 3;
            label5.Text = "Loan_Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(50, 123);
            label4.Name = "label4";
            label4.Size = new Size(85, 28);
            label4.TabIndex = 2;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(694, 70);
            label3.Name = "label3";
            label3.Size = new Size(106, 28);
            label3.TabIndex = 1;
            label3.Text = "Loan_Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(49, 75);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 0;
            label2.Text = "Loan_ID";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 537);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1614, 285);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(comboBoxStatus);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(textBoxSearch);
            panel3.Controls.Add(comboBoxSearch);
            panel3.Location = new Point(11, 452);
            panel3.Name = "panel3";
            panel3.Size = new Size(1614, 78);
            panel3.TabIndex = 25;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Closed", "All" });
            comboBoxStatus.Location = new Point(954, 23);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(251, 33);
            comboBoxStatus.TabIndex = 27;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.Location = new Point(1259, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 42);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(463, 23);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(458, 31);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "Select Search Type", "Loan ID", "Customer Name", "Loan Type" });
            comboBoxSearch.Location = new Point(117, 23);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(315, 33);
            comboBoxSearch.TabIndex = 0;
            // 
            // Loan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1638, 834);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Location = new Point(270, 120);
            Name = "Loan";
            StartPosition = FormStartPosition.Manual;
            Text = "Loan";
            Load += Loan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker3;
        private Button btnDelete;
        private Button btnSave;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label7;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBoxCustomer;
        private TextBox textBoxCustomerName;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox textBoxEMI;
        private TextBox textBoxRemaining;
        private Panel panel3;
        private ComboBox comboBoxStatus;
        private Button btnSearch;
        private TextBox textBoxSearch;
        private ComboBox comboBoxSearch;
        private Button btnReopen;
        private Button btnClear;
        private TextBox textBoxYears;
        private Label label12;
        private Label label11;
        private TextBox textBoxTotal;
    }
}