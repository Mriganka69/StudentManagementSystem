namespace SchoolManagementSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.AddStudents_Btn = new System.Windows.Forms.Button();
            this.Dashboart_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.dashboardForm2 = new SchoolManagementSystem.DashboardForm();
            this.dashboardForm1 = new SchoolManagementSystem.DashboardForm();
            this.addStudentForm1 = new SchoolManagementSystem.AddStudentForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 25);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1052, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "School Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.AddStudents_Btn);
            this.panel2.Controls.Add(this.Dashboart_Btn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 628);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(15, 580);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddStudents_Btn
            // 
            this.AddStudents_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudents_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.AddStudents_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.AddStudents_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudents_Btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudents_Btn.ForeColor = System.Drawing.Color.White;
            this.AddStudents_Btn.Location = new System.Drawing.Point(12, 228);
            this.AddStudents_Btn.Name = "AddStudents_Btn";
            this.AddStudents_Btn.Size = new System.Drawing.Size(200, 40);
            this.AddStudents_Btn.TabIndex = 2;
            this.AddStudents_Btn.Text = "Add Students";
            this.AddStudents_Btn.UseVisualStyleBackColor = true;
            this.AddStudents_Btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dashboart_Btn
            // 
            this.Dashboart_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dashboart_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Dashboart_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Dashboart_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboart_Btn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboart_Btn.ForeColor = System.Drawing.Color.White;
            this.Dashboart_Btn.Location = new System.Drawing.Point(12, 140);
            this.Dashboart_Btn.Name = "Dashboart_Btn";
            this.Dashboart_Btn.Size = new System.Drawing.Size(200, 40);
            this.Dashboart_Btn.TabIndex = 1;
            this.Dashboart_Btn.Text = "Dashboard";
            this.Dashboart_Btn.UseVisualStyleBackColor = true;
            this.Dashboart_Btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin !";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dashboardForm2);
            this.panel3.Controls.Add(this.dashboardForm1);
            this.panel3.Controls.Add(this.addStudentForm1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 628);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dashboardForm2
            // 
            this.dashboardForm2.Location = new System.Drawing.Point(276, 208);
            this.dashboardForm2.Name = "dashboardForm2";
            this.dashboardForm2.Size = new System.Drawing.Size(8, 16);
            this.dashboardForm2.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.Location = new System.Drawing.Point(-1, -1);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(857, 628);
            this.dashboardForm1.TabIndex = 1;
            this.dashboardForm1.Load += new System.EventHandler(this.dashboardForm1_Load);
            // 
            // addStudentForm1
            // 
            this.addStudentForm1.Location = new System.Drawing.Point(-4, -1);
            this.addStudentForm1.Name = "addStudentForm1";
            this.addStudentForm1.Size = new System.Drawing.Size(857, 628);
            this.addStudentForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Dashboart_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button AddStudents_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private AddStudentForm addStudentForm1;
        private DashboardForm dashboardForm2;
        private DashboardForm dashboardForm1;
    }
}