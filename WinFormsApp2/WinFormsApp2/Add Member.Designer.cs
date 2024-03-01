namespace House_Finance_management
{
    partial class Add_Member
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
            label2 = new Label();
            label3 = new Label();
            cmbJob = new ComboBox();
            label4 = new Label();
            numAge = new NumericUpDown();
            numMonthlySalary = new NumericUpDown();
            numExperience = new NumericUpDown();
            label5 = new Label();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            label7 = new Label();
            panel1 = new Panel();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            dtpAge = new DateTimePicker();
            label10 = new Label();
            txtMName = new TextBox();
            label9 = new Label();
            txtLName = new TextBox();
            label8 = new Label();
            txtFName = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMonthlySalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 151);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Monthly salary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 34);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 4;
            label3.Text = "Job:";
            // 
            // cmbJob
            // 
            cmbJob.Font = new Font("David", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cmbJob.FormattingEnabled = true;
            cmbJob.Location = new Point(72, 30);
            cmbJob.Name = "cmbJob";
            cmbJob.Size = new Size(393, 36);
            cmbJob.Sorted = true;
            cmbJob.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 207);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 6;
            label4.Text = "Age:";
            // 
            // numAge
            // 
            numAge.Location = new Point(516, 205);
            numAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(75, 31);
            numAge.TabIndex = 8;
            numAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // numMonthlySalary
            // 
            numMonthlySalary.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numMonthlySalary.Location = new Point(153, 149);
            numMonthlySalary.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            numMonthlySalary.Name = "numMonthlySalary";
            numMonthlySalary.Size = new Size(154, 31);
            numMonthlySalary.TabIndex = 9;
            // 
            // numExperience
            // 
            numExperience.Location = new Point(163, 90);
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(75, 31);
            numExperience.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 92);
            label5.Name = "label5";
            label5.Size = new Size(142, 25);
            label5.TabIndex = 12;
            label5.Text = "Work experience";
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(3, 5);
            radMale.Name = "radMale";
            radMale.Size = new Size(75, 29);
            radMale.TabIndex = 14;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(3, 40);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(110, 29);
            radFemale.TabIndex = 15;
            radFemale.TabStop = true;
            radFemale.Text = "Not Male";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(411, 107);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 16;
            label7.Text = "Gender:";
            // 
            // panel1
            // 
            panel1.Controls.Add(radFemale);
            panel1.Controls.Add(radMale);
            panel1.Location = new Point(490, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 91);
            panel1.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(85, 576);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(832, 58);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add member to the house";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(dtpAge);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMName);
            groupBox1.Controls.Add(numAge);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtLName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtFName);
            groupBox1.Controls.Add(label6);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(686, 248);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person";
            // 
            // dtpAge
            // 
            dtpAge.Format = DateTimePickerFormat.Custom;
            dtpAge.Location = new Point(490, 49);
            dtpAge.Name = "dtpAge";
            dtpAge.Size = new Size(162, 31);
            dtpAge.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(403, 49);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 8;
            label10.Text = "Birthday:";
            // 
            // txtMName
            // 
            txtMName.Location = new Point(142, 168);
            txtMName.Name = "txtMName";
            txtMName.PlaceholderText = "Optional";
            txtMName.Size = new Size(292, 31);
            txtMName.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 168);
            label9.Name = "label9";
            label9.Size = new Size(120, 25);
            label9.TabIndex = 6;
            label9.Text = "Middle name:";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(112, 112);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(222, 31);
            txtLName.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 112);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 4;
            label8.Text = "Last name: ";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(112, 55);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(222, 31);
            txtFName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 55);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 2;
            label6.Text = "First name: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbJob);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numMonthlySalary);
            groupBox2.Controls.Add(numExperience);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(13, 289);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(478, 215);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Job Data";
            // 
            // Add_Member
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1090, 680);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Member";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMonthlySalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private ComboBox cmbJob;
        private Label label4;
        private NumericUpDown numAge;
        private NumericUpDown numMonthlySalary;
        private NumericUpDown numExperience;
        private Label label5;
        private RadioButton radMale;
        private RadioButton radFemale;
        private Label label7;
        private Panel panel1;
        private Button btnAdd;
        private GroupBox groupBox1;
        private TextBox txtFName;
        private Label label6;
        private TextBox txtMName;
        private Label label9;
        private TextBox txtLName;
        private Label label8;
        private DateTimePicker dtpAge;
        private Label label10;
        private GroupBox groupBox2;
    }
}