namespace BankManagement
{
    partial class Dashboard
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
            lblTotalCustomers = new Label();
            label2 = new Label();
            panel3 = new Panel();
            lblTodayDeposits = new Label();
            label4 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            lblActiveAccounts = new Label();
            label7 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            lblClosedAccounts = new Label();
            label10 = new Label();
            label11 = new Label();
            panel6 = new Panel();
            lblTotalTransactions = new Label();
            label13 = new Label();
            label14 = new Label();
            panel7 = new Panel();
            lblTodayWithdrawals = new Label();
            label16 = new Label();
            label17 = new Label();
            panel8 = new Panel();
            lblActiveLoans = new Label();
            label19 = new Label();
            label20 = new Label();
            panel9 = new Panel();
            lblTotalLoanAmount = new Label();
            label22 = new Label();
            label23 = new Label();
            dgvTopCustomers = new DataGridView();
            dgvRecentTransactions = new DataGridView();
            formsPlotTopCustomers = new ScottPlot.WinForms.FormsPlot();
            formsPlotTransactions = new ScottPlot.WinForms.FormsPlot();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(536, 15);
            label1.Name = "label1";
            label1.Size = new Size(565, 45);
            label1.TabIndex = 0;
            label1.Text = "BANK MANAGEMENT DASHBOARD";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lblTotalCustomers);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(13, 95);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 125);
            panel2.TabIndex = 3;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomers.Location = new Point(44, 46);
            lblTotalCustomers.Margin = new Padding(4, 0, 4, 0);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(56, 65);
            lblTotalCustomers.TabIndex = 1;
            lblTotalCustomers.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(2, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 0;
            label2.Text = "Total Customers";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(lblTodayDeposits);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(1063, 95);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 125);
            panel3.TabIndex = 4;
            // 
            // lblTodayDeposits
            // 
            lblTodayDeposits.AutoSize = true;
            lblTodayDeposits.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayDeposits.Location = new Point(53, 46);
            lblTodayDeposits.Margin = new Padding(4, 0, 4, 0);
            lblTodayDeposits.Name = "lblTodayDeposits";
            lblTodayDeposits.Size = new Size(56, 65);
            lblTodayDeposits.TabIndex = 2;
            lblTodayDeposits.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 82);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 65);
            label4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(24, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 0;
            label5.Text = "Deposits";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(lblActiveAccounts);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(221, 95);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 125);
            panel4.TabIndex = 4;
            // 
            // lblActiveAccounts
            // 
            lblActiveAccounts.AutoSize = true;
            lblActiveAccounts.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveAccounts.Location = new Point(54, 46);
            lblActiveAccounts.Margin = new Padding(4, 0, 4, 0);
            lblActiveAccounts.Name = "lblActiveAccounts";
            lblActiveAccounts.Size = new Size(56, 65);
            lblActiveAccounts.TabIndex = 2;
            lblActiveAccounts.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 82);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(0, 65);
            label7.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 10);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 25);
            label8.TabIndex = 0;
            label8.Text = "Active Accounts";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Controls.Add(lblClosedAccounts);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Location = new Point(429, 95);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 125);
            panel5.TabIndex = 4;
            // 
            // lblClosedAccounts
            // 
            lblClosedAccounts.AutoSize = true;
            lblClosedAccounts.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClosedAccounts.Location = new Point(51, 46);
            lblClosedAccounts.Margin = new Padding(4, 0, 4, 0);
            lblClosedAccounts.Name = "lblClosedAccounts";
            lblClosedAccounts.Size = new Size(56, 65);
            lblClosedAccounts.TabIndex = 2;
            lblClosedAccounts.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(64, 82);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 65);
            label10.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(-3, 10);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(152, 25);
            label11.TabIndex = 0;
            label11.Text = "Closed Accounts";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Controls.Add(lblTotalTransactions);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label14);
            panel6.Location = new Point(855, 95);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(150, 125);
            panel6.TabIndex = 4;
            // 
            // lblTotalTransactions
            // 
            lblTotalTransactions.AutoSize = true;
            lblTotalTransactions.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTransactions.Location = new Point(51, 46);
            lblTotalTransactions.Margin = new Padding(4, 0, 4, 0);
            lblTotalTransactions.Name = "lblTotalTransactions";
            lblTotalTransactions.Size = new Size(56, 65);
            lblTotalTransactions.TabIndex = 2;
            lblTotalTransactions.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(64, 82);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(0, 65);
            label13.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.ForeColor = Color.White;
            label14.Location = new Point(23, 9);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(119, 25);
            label14.TabIndex = 0;
            label14.Text = "Transactions";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveCaption;
            panel7.Controls.Add(lblTodayWithdrawals);
            panel7.Controls.Add(label16);
            panel7.Controls.Add(label17);
            panel7.Location = new Point(1269, 95);
            panel7.Margin = new Padding(4, 5, 4, 5);
            panel7.Name = "panel7";
            panel7.Size = new Size(150, 125);
            panel7.TabIndex = 4;
            // 
            // lblTodayWithdrawals
            // 
            lblTodayWithdrawals.AutoSize = true;
            lblTodayWithdrawals.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodayWithdrawals.Location = new Point(50, 46);
            lblTodayWithdrawals.Margin = new Padding(4, 0, 4, 0);
            lblTodayWithdrawals.Name = "lblTodayWithdrawals";
            lblTodayWithdrawals.Size = new Size(56, 65);
            lblTodayWithdrawals.TabIndex = 2;
            lblTodayWithdrawals.Text = "0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(64, 82);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(0, 65);
            label16.TabIndex = 1;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label17.ForeColor = Color.White;
            label17.Location = new Point(22, 9);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(118, 25);
            label17.TabIndex = 0;
            label17.Text = "Withdrawals";
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveCaption;
            panel8.Controls.Add(lblActiveLoans);
            panel8.Controls.Add(label19);
            panel8.Controls.Add(label20);
            panel8.Location = new Point(643, 95);
            panel8.Margin = new Padding(4, 5, 4, 5);
            panel8.Name = "panel8";
            panel8.Size = new Size(150, 125);
            panel8.TabIndex = 4;
            // 
            // lblActiveLoans
            // 
            lblActiveLoans.AutoSize = true;
            lblActiveLoans.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveLoans.Location = new Point(54, 46);
            lblActiveLoans.Margin = new Padding(4, 0, 4, 0);
            lblActiveLoans.Name = "lblActiveLoans";
            lblActiveLoans.Size = new Size(56, 65);
            lblActiveLoans.TabIndex = 2;
            lblActiveLoans.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(64, 82);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(0, 65);
            label19.TabIndex = 1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label20.ForeColor = Color.White;
            label20.Location = new Point(18, 10);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(120, 25);
            label20.TabIndex = 0;
            label20.Text = "Active Loans";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveCaption;
            panel9.Controls.Add(lblTotalLoanAmount);
            panel9.Controls.Add(label22);
            panel9.Controls.Add(label23);
            panel9.Location = new Point(1475, 95);
            panel9.Margin = new Padding(4, 5, 4, 5);
            panel9.Name = "panel9";
            panel9.Size = new Size(150, 125);
            panel9.TabIndex = 4;
            // 
            // lblTotalLoanAmount
            // 
            lblTotalLoanAmount.AutoSize = true;
            lblTotalLoanAmount.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLoanAmount.Location = new Point(50, 46);
            lblTotalLoanAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalLoanAmount.Name = "lblTotalLoanAmount";
            lblTotalLoanAmount.Size = new Size(56, 65);
            lblTotalLoanAmount.TabIndex = 2;
            lblTotalLoanAmount.Text = "0";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(64, 82);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(0, 65);
            label22.TabIndex = 1;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label23.ForeColor = Color.White;
            label23.Location = new Point(18, 9);
            label23.Margin = new Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new Size(127, 25);
            label23.TabIndex = 0;
            label23.Text = "Loan Amount";
            // 
            // dgvTopCustomers
            // 
            dgvTopCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopCustomers.Location = new Point(29, 544);
            dgvTopCustomers.Name = "dgvTopCustomers";
            dgvTopCustomers.RowHeadersWidth = 62;
            dgvTopCustomers.Size = new Size(679, 250);
            dgvTopCustomers.TabIndex = 5;
            // 
            // dgvRecentTransactions
            // 
            dgvRecentTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentTransactions.Location = new Point(855, 544);
            dgvRecentTransactions.Name = "dgvRecentTransactions";
            dgvRecentTransactions.RowHeadersWidth = 62;
            dgvRecentTransactions.Size = new Size(654, 250);
            dgvRecentTransactions.TabIndex = 6;
            // 
            // formsPlotTopCustomers
            // 
            formsPlotTopCustomers.Location = new Point(28, 273);
            formsPlotTopCustomers.Name = "formsPlotTopCustomers";
            formsPlotTopCustomers.Size = new Size(680, 250);
            formsPlotTopCustomers.TabIndex = 7;
            // 
            // formsPlotTransactions
            // 
            formsPlotTransactions.Location = new Point(884, 273);
            formsPlotTransactions.Name = "formsPlotTransactions";
            formsPlotTransactions.Size = new Size(550, 250);
            formsPlotTransactions.TabIndex = 8;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 834);
            Controls.Add(formsPlotTransactions);
            Controls.Add(formsPlotTopCustomers);
            Controls.Add(dgvRecentTransactions);
            Controls.Add(dgvTopCustomers);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Location = new Point(270, 120);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            StartPosition = FormStartPosition.Manual;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecentTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Label lblTotalCustomers;
        private Panel panel3;
        private Label lblTodayDeposits;
        private Label label4;
        private Label label5;
        private Panel panel4;
        private Label lblActiveAccounts;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private Label lblClosedAccounts;
        private Label label10;
        private Label label11;
        private Panel panel6;
        private Label lblTotalTransactions;
        private Label label13;
        private Label label14;
        private Panel panel7;
        private Label lblTodayWithdrawals;
        private Label label16;
        private Label label17;
        private Panel panel8;
        private Label lblActiveLoans;
        private Label label19;
        private Label label20;
        private Panel panel9;
        private Label lblTotalLoanAmount;
        private Label label22;
        private Label label23;
        private DataGridView dgvTopCustomers;
        private DataGridView dgvRecentTransactions;
        private ScottPlot.WinForms.FormsPlot formsPlotTopCustomers;
        private ScottPlot.WinForms.FormsPlot formsPlotTransactions;
    }
}