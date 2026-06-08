namespace BankManagement
{
    partial class Account
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
            panel1 = new Panel();
            label1 = new Label();
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            panel2 = new Panel();
            btnReactivate = new Button();
            btnClear = new Button();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            label10 = new Label();
            textBoxCustomerName = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnDelete = new Button();
            btnSave = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            comboBoxSearch = new ComboBox();
            panel3 = new Panel();
            comboBoxStatus = new ComboBox();
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
            panel1.Size = new Size(1638, 86);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(736, 26);
            label1.Name = "label1";
            label1.Size = new Size(157, 45);
            label1.TabIndex = 0;
            label1.Text = "Accounts";
            label1.Click += label1_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(310, 15);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(363, 34);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.Location = new Point(710, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(248, 42);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            btnSearch.Leave += btnSearch_Leave;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnReactivate);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxCustomerName);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.YellowGreen;
            panel2.Location = new Point(12, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(1614, 191);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnReactivate
            // 
            btnReactivate.BackColor = SystemColors.GradientActiveCaption;
            btnReactivate.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReactivate.ForeColor = Color.Black;
            btnReactivate.Location = new Point(1340, 133);
            btnReactivate.Name = "btnReactivate";
            btnReactivate.Size = new Size(130, 44);
            btnReactivate.TabIndex = 25;
            btnReactivate.Text = "Reopen AC";
            btnReactivate.UseVisualStyleBackColor = false;
            btnReactivate.Click += btnReactivate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(1100, 19);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(130, 44);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Red;
            label12.Location = new Point(832, 130);
            label12.Name = "label12";
            label12.Size = new Size(20, 25);
            label12.TabIndex = 24;
            label12.Text = "*";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(175, 131);
            label11.Name = "label11";
            label11.Size = new Size(20, 25);
            label11.TabIndex = 23;
            label11.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(832, 80);
            label8.Name = "label8";
            label8.Size = new Size(20, 25);
            label8.TabIndex = 21;
            label8.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(215, 32);
            label10.Name = "label10";
            label10.Size = new Size(20, 25);
            label10.TabIndex = 20;
            label10.Text = "*";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(701, 24);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.ReadOnly = true;
            textBoxCustomerName.Size = new Size(339, 31);
            textBoxCustomerName.TabIndex = 19;
            textBoxCustomerName.TextChanged += textBoxCustomerName_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(272, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(349, 33);
            comboBox2.TabIndex = 18;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Savings", "Current", "Salary", "Fixed Deposit" });
            comboBox1.Location = new Point(890, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(350, 33);
            comboBox1.TabIndex = 17;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(272, 77);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(349, 31);
            textBox5.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(891, 131);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(349, 31);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(1340, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 44);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Close AC";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(1340, 16);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 44);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(349, 31);
            textBox3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(95, 32);
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
            label5.Location = new Point(701, 133);
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 3;
            label5.Text = "Date_Opened";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(95, 133);
            label4.Name = "label4";
            label4.Size = new Size(83, 28);
            label4.TabIndex = 2;
            label4.Text = "Balance";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(701, 80);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 1;
            label3.Text = "Account_Type";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(95, 80);
            label2.Name = "label2";
            label2.Size = new Size(114, 28);
            label2.TabIndex = 0;
            label2.Text = "Account_ID";
            label2.Click += label2_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.GradientActiveCaption;
            btnAdd.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(1340, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 44);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Reload";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 366);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1614, 456);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "Select Search Type", "Account ID", "Customer ID", "Customer Name", "Account Type" });
            comboBoxSearch.Location = new Point(25, 15);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(248, 36);
            comboBoxSearch.TabIndex = 6;
            comboBoxSearch.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(comboBoxStatus);
            panel3.Controls.Add(comboBoxSearch);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(textBoxSearch);
            panel3.Controls.Add(btnSearch);
            panel3.Location = new Point(12, 289);
            panel3.Name = "panel3";
            panel3.Size = new Size(1614, 71);
            panel3.TabIndex = 12;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Closed", "Frozen", "All" });
            comboBoxStatus.Location = new Point(998, 15);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(297, 33);
            comboBoxStatus.TabIndex = 13;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // Account
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
            Name = "Account";
            StartPosition = FormStartPosition.Manual;
            Text = "Account";
            Load += Account_Load;
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
        private TextBox textBoxSearch;
        private Button btnSearch;
        private Panel panel2;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnSave;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private Button btnClear;
        private ComboBox comboBox1;
        private ComboBox comboBoxSearch;
        private TextBox textBoxCustomerName;
        private ComboBox comboBox2;
        private Label label11;
        private Label label8;
        private Label label10;
        private Label label12;
        private Panel panel3;
        private ComboBox comboBoxStatus;
        private Button btnReactivate;
    }
}