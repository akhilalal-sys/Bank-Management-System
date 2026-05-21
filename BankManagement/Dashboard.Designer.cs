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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            lblCount1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblCount2 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lblCount3 = new Label();
            label6 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gray;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1139, 64);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 45);
            label1.TabIndex = 1;
            label1.Text = "DashBoard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblCount1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(82, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 238);
            panel1.TabIndex = 1;
            // 
            // lblCount1
            // 
            lblCount1.AutoSize = true;
            lblCount1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount1.Location = new Point(117, 94);
            lblCount1.Name = "lblCount1";
            lblCount1.Size = new Size(38, 45);
            lblCount1.TabIndex = 1;
            lblCount1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 18);
            label2.Name = "label2";
            label2.Size = new Size(247, 38);
            label2.TabIndex = 0;
            label2.Text = "Total Customers";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblCount2);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(411, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 238);
            panel2.TabIndex = 2;
            // 
            // lblCount2
            // 
            lblCount2.AutoSize = true;
            lblCount2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount2.Location = new Point(131, 94);
            lblCount2.Name = "lblCount2";
            lblCount2.Size = new Size(38, 45);
            lblCount2.TabIndex = 2;
            lblCount2.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 18);
            label4.Name = "label4";
            label4.Size = new Size(247, 38);
            label4.TabIndex = 1;
            label4.Text = "Total Employees";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblCount3);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(740, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 238);
            panel3.TabIndex = 3;
            // 
            // lblCount3
            // 
            lblCount3.AutoSize = true;
            lblCount3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount3.Location = new Point(131, 97);
            lblCount3.Name = "lblCount3";
            lblCount3.Size = new Size(38, 45);
            lblCount3.TabIndex = 3;
            lblCount3.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 18);
            label6.Name = "label6";
            label6.Size = new Size(179, 38);
            label6.TabIndex = 2;
            label6.Text = "Total Loans";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1139, 567);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label lblCount1;
        private Label label2;
        private Label lblCount2;
        private Label label4;
        private Label lblCount3;
        private Label label6;
    }
}