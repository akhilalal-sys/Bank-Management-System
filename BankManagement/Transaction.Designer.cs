namespace BankManagement
{
    partial class Transaction
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
            panel2 = new Panel();
            btnClear = new Button();
            textBoxRemarks = new TextBox();
            label8 = new Label();
            textBoxBalanceAfter = new TextBox();
            textBoxBalanceBefore = new TextBox();
            label7 = new Label();
            label2 = new Label();
            comboBoxAccount = new ComboBox();
            comboBox1 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            btnAdd = new Button();
            btnSave = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            btnDateSearch = new Button();
            btnSearch = new Button();
            dateTimePickerSearch = new DateTimePicker();
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 52);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(475, 11);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 30);
            label1.TabIndex = 0;
            label1.Text = "Transactions";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(textBoxRemarks);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBoxBalanceAfter);
            panel2.Controls.Add(textBoxBalanceBefore);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBoxAccount);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.ForeColor = Color.YellowGreen;
            panel2.Location = new Point(12, 56);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1126, 136);
            panel2.TabIndex = 4;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(957, 83);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(73, 26);
            btnClear.TabIndex = 24;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // textBoxRemarks
            // 
            textBoxRemarks.Location = new Point(167, 92);
            textBoxRemarks.Margin = new Padding(2);
            textBoxRemarks.Multiline = true;
            textBoxRemarks.Name = "textBoxRemarks";
            textBoxRemarks.Size = new Size(246, 40);
            textBoxRemarks.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(22, 93);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(63, 19);
            label8.TabIndex = 22;
            label8.Text = "Remarks";
            // 
            // textBoxBalanceAfter
            // 
            textBoxBalanceAfter.Location = new Point(639, 62);
            textBoxBalanceAfter.Margin = new Padding(2);
            textBoxBalanceAfter.Name = "textBoxBalanceAfter";
            textBoxBalanceAfter.ReadOnly = true;
            textBoxBalanceAfter.Size = new Size(246, 23);
            textBoxBalanceAfter.TabIndex = 21;
            // 
            // textBoxBalanceBefore
            // 
            textBoxBalanceBefore.Location = new Point(167, 61);
            textBoxBalanceBefore.Margin = new Padding(2);
            textBoxBalanceBefore.Name = "textBoxBalanceBefore";
            textBoxBalanceBefore.ReadOnly = true;
            textBoxBalanceBefore.Size = new Size(246, 23);
            textBoxBalanceBefore.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(22, 61);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(104, 19);
            label7.TabIndex = 19;
            label7.Text = "Balance Before";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(463, 61);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 18;
            label2.Text = "Balance After";
            // 
            // comboBoxAccount
            // 
            comboBoxAccount.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxAccount.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxAccount.FormattingEnabled = true;
            comboBoxAccount.Location = new Point(167, 6);
            comboBoxAccount.Margin = new Padding(2);
            comboBoxAccount.Name = "comboBoxAccount";
            comboBoxAccount.Size = new Size(246, 23);
            comboBoxAccount.TabIndex = 17;
            comboBoxAccount.SelectedIndexChanged += comboBoxAccount_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Deposit", "Withdraw" });
            comboBox1.Location = new Point(640, 6);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 23);
            comboBox1.TabIndex = 16;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(639, 35);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(244, 23);
            dateTimePicker2.TabIndex = 14;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            dateTimePicker2.KeyDown += dateTimePicker2_KeyDown;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.GradientActiveCaption;
            btnAdd.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(957, 43);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(73, 26);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Reload";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(957, 8);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(73, 26);
            btnSave.TabIndex = 10;
            btnSave.Text = "Process";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 33);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(246, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(22, 8);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 19);
            label6.TabIndex = 4;
            label6.Text = "Account_Id";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(463, 35);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(119, 19);
            label5.TabIndex = 3;
            label5.Text = "Transaction_Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(22, 35);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 2;
            label4.Text = "Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(463, 8);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 1;
            label3.Text = "Transaction_Type";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 246);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1126, 247);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(btnDateSearch);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(dateTimePickerSearch);
            panel3.Controls.Add(textBoxSearch);
            panel3.Controls.Add(comboBoxSearch);
            panel3.Location = new Point(12, 196);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1126, 47);
            panel3.TabIndex = 24;
            // 
            // btnDateSearch
            // 
            btnDateSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnDateSearch.Location = new Point(912, 12);
            btnDateSearch.Margin = new Padding(2);
            btnDateSearch.Name = "btnDateSearch";
            btnDateSearch.Size = new Size(171, 25);
            btnDateSearch.TabIndex = 26;
            btnDateSearch.Text = "Search By Date";
            btnDateSearch.UseVisualStyleBackColor = false;
            btnDateSearch.Click += btnDateSearch_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.Location = new Point(580, 12);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 25);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePickerSearch
            // 
            dateTimePickerSearch.Location = new Point(747, 14);
            dateTimePickerSearch.Margin = new Padding(2);
            dateTimePickerSearch.Name = "dateTimePickerSearch";
            dateTimePickerSearch.Size = new Size(138, 23);
            dateTimePickerSearch.TabIndex = 25;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(243, 14);
            textBoxSearch.Margin = new Padding(2);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(314, 23);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "Transaction ID", "Account ID", "Transaction Type" });
            comboBoxSearch.Location = new Point(22, 14);
            comboBoxSearch.Margin = new Padding(2);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(208, 23);
            comboBoxSearch.TabIndex = 0;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1147, 500);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Location = new Point(270, 120);
            Margin = new Padding(2);
            Name = "Transaction";
            StartPosition = FormStartPosition.Manual;
            Text = "Transaction";
            Load += Transaction_Load;
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
        private DateTimePicker dateTimePicker2;
        private Button btnAdd;
        private Button btnSave;
        private TextBox textBox3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label7;
        private Label label2;
        private ComboBox comboBoxAccount;
        private TextBox textBoxRemarks;
        private Label label8;
        private TextBox textBoxBalanceAfter;
        private TextBox textBoxBalanceBefore;
        private Panel panel3;
        private ComboBox comboBoxSearch;
        private TextBox textBoxSearch;
        private Button btnSearch;
        private Button btnClear;
        private Button btnDateSearch;
        private DateTimePicker dateTimePickerSearch;
    }
}