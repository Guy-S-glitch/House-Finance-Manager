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
            label1 = new Label();
            txtName = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMonthlySalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Name: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(86, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(292, 31);
            txtName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 90);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 2;
            label2.Text = "Monthly salary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 9);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 4;
            label3.Text = "Job:";
            // 
            // cmbJob
            // 
            cmbJob.Font = new Font("David", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cmbJob.FormattingEnabled = true;
            cmbJob.Location = new Point(522, 12);
            cmbJob.Name = "cmbJob";
            cmbJob.Size = new Size(292, 36);
            cmbJob.Sorted = true;
            cmbJob.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 90);
            label4.Name = "label4";
            label4.Size = new Size(48, 25);
            label4.TabIndex = 6;
            label4.Text = "Age:";
            // 
            // numAge
            // 
            numAge.Location = new Point(86, 90);
            numAge.Name = "numAge";
            numAge.Size = new Size(75, 31);
            numAge.TabIndex = 8;
            // 
            // numMonthlySalary
            // 
            numMonthlySalary.Location = new Point(522, 88);
            numMonthlySalary.Name = "numMonthlySalary";
            numMonthlySalary.Size = new Size(154, 31);
            numMonthlySalary.TabIndex = 9;
            // 
            // numExperience
            // 
            numExperience.Location = new Point(522, 162);
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(75, 31);
            numExperience.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 164);
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
            label7.Location = new Point(7, 164);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 16;
            label7.Text = "Gender:";
            // 
            // panel1
            // 
            panel1.Controls.Add(radFemale);
            panel1.Controls.Add(radMale);
            panel1.Location = new Point(86, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 91);
            panel1.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 271);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(824, 58);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add member to the house";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Add_Member
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(848, 350);
            Controls.Add(btnAdd);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(numExperience);
            Controls.Add(numMonthlySalary);
            Controls.Add(numAge);
            Controls.Add(label4);
            Controls.Add(cmbJob);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Name = "Add_Member";
            Text = "Add_Member";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMonthlySalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
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
    }
}