namespace BankManagement
{
    partial class Customer
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            btnSave = new Button();
            btnAdd = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            btnReactivate = new Button();
            btnClear = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            comboBoxStatus = new ComboBox();
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            comboBoxSearch = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(14, 13);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 0;
            label2.Text = "Customer_ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(657, 10);
            label3.Name = "label3";
            label3.Size = new Size(161, 28);
            label3.TabIndex = 1;
            label3.Text = "Customer_Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(14, 54);
            label4.Name = "label4";
            label4.Size = new Size(69, 28);
            label4.TabIndex = 2;
            label4.Text = "Phone";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(657, 60);
            label5.Name = "label5";
            label5.Size = new Size(63, 28);
            label5.TabIndex = 3;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(14, 98);
            label6.Name = "label6";
            label6.Size = new Size(81, 28);
            label6.TabIndex = 4;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Enabled = false;
            textBox1.Location = new Point(177, 10);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(373, 31);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(869, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 31);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 54);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(373, 31);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(177, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(373, 31);
            textBox4.TabIndex = 8;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(869, 57);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(373, 31);
            textBox5.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(1356, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(141, 44);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.GradientActiveCaption;
            btnAdd.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(1356, 9);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 44);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Reload";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(1356, 54);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(141, 44);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Deactivate";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnReactivate);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.ForeColor = Color.YellowGreen;
            panel1.Location = new Point(12, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(1614, 150);
            panel1.TabIndex = 1;
            // 
            // btnReactivate
            // 
            btnReactivate.BackColor = SystemColors.GradientActiveCaption;
            btnReactivate.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReactivate.ForeColor = Color.Black;
            btnReactivate.Location = new Point(1356, 104);
            btnReactivate.Name = "btnReactivate";
            btnReactivate.Size = new Size(141, 44);
            btnReactivate.TabIndex = 20;
            btnReactivate.Text = "Reactivate";
            btnReactivate.UseVisualStyleBackColor = false;
            btnReactivate.Click += btnReactivate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(1101, 103);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 44);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(75, 54);
            label10.Name = "label10";
            label10.Size = new Size(20, 25);
            label10.TabIndex = 18;
            label10.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(812, 10);
            label9.Name = "label9";
            label9.Size = new Size(20, 25);
            label9.TabIndex = 17;
            label9.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(716, 57);
            label8.Name = "label8";
            label8.Size = new Size(20, 25);
            label8.TabIndex = 16;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(87, 98);
            label7.Name = "label7";
            label7.Size = new Size(20, 25);
            label7.TabIndex = 15;
            label7.Text = "*";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1614, 521);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(683, 9);
            label11.Name = "label11";
            label11.Size = new Size(209, 57);
            label11.TabIndex = 21;
            label11.Text = "Customers";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(label11);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1638, 76);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Controls.Add(comboBoxStatus);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(textBoxSearch);
            panel3.Controls.Add(comboBoxSearch);
            panel3.Controls.Add(btnAdd);
            panel3.Location = new Point(12, 236);
            panel3.Name = "panel3";
            panel3.Size = new Size(1614, 59);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Active", "Inactive", "All" });
            comboBoxStatus.Location = new Point(1119, 14);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(186, 33);
            comboBoxStatus.TabIndex = 12;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(224, 224, 224);
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(692, 9);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(248, 42);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(251, 14);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(426, 34);
            textBoxSearch.TabIndex = 2;
            textBoxSearch.TextChanged += textBox6_TextChanged;
            textBoxSearch.Enter += textBoxSearch_Enter;
            textBoxSearch.Leave += textBoxSearch_Leave;
            // 
            // comboBoxSearch
            // 
            comboBoxSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearch.FormattingEnabled = true;
            comboBoxSearch.Items.AddRange(new object[] { "Select Search Type", "Customer ID", "Customer Name", "Phone", "Email" });
            comboBoxSearch.Location = new Point(25, 16);
            comboBoxSearch.Name = "comboBoxSearch";
            comboBoxSearch.Size = new Size(207, 33);
            comboBoxSearch.TabIndex = 0;
            // 
            // Customer
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1638, 834);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Location = new Point(270, 120);
            Name = "Customer";
            StartPosition = FormStartPosition.Manual;
            Text = "Customer";
            TopMost = true;
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnSave;
        private Button btnAdd;
        private Button btnDelete;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnClear;
        private Label label11;
        private Panel panel2;
        private Panel panel3;
        private ComboBox comboBoxSearch;
        private TextBox textBoxSearch;
        private Button btnSearch;
        private ComboBox comboBoxStatus;
        private Button btnReactivate;
    }
}