﻿namespace House_Finance_management
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
            numMonthlySalary = new NumericUpDown();
            numExperience = new NumericUpDown();
            label5 = new Label();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            label7 = new Label();
            pnlvalidateGender = new Panel();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            pnlValidateAge = new Panel();
            dtpAge = new DateTimePicker();
            label10 = new Label();
            txtMName = new TextBox();
            label9 = new Label();
            txtLName = new TextBox();
            label8 = new Label();
            txtFName = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            pnlValidateJob = new Panel();
            cmbJob = new ComboBox();
            clbExpenses = new CheckedListBox();
            groupBox4 = new GroupBox();
            splitContainer1 = new SplitContainer();
            numRestaurant = new NumericUpDown();
            numRent = new NumericUpDown();
            numMarket = new NumericUpDown();
            numUtilities = new NumericUpDown();
            numTransport = new NumericUpDown();
            numSport = new NumericUpDown();
            numClothes = new NumericUpDown();
            lsbExpensesPrices = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numMonthlySalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            pnlvalidateGender.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlValidateAge.SuspendLayout();
            groupBox2.SuspendLayout();
            pnlValidateJob.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRestaurant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMarket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUtilities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTransport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numClothes).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(394, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(171, 29);
            label2.TabIndex = 2;
            label2.Text = "Monthly salary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 44);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 29);
            label3.TabIndex = 4;
            label3.Text = "Job:";
            // 
            // numMonthlySalary
            // 
            numMonthlySalary.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numMonthlySalary.Location = new Point(572, 85);
            numMonthlySalary.Maximum = new decimal(new int[] { 200000, 0, 0, 0 });
            numMonthlySalary.Name = "numMonthlySalary";
            numMonthlySalary.Size = new Size(154, 35);
            numMonthlySalary.TabIndex = 9;
            // 
            // numExperience
            // 
            numExperience.Location = new Point(217, 86);
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(75, 35);
            numExperience.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 85);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(201, 29);
            label5.TabIndex = 12;
            label5.Text = "Work experience:";
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(4, 5);
            radMale.Margin = new Padding(4, 3, 4, 3);
            radMale.Name = "radMale";
            radMale.Size = new Size(91, 33);
            radMale.TabIndex = 14;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(4, 38);
            radFemale.Margin = new Padding(4, 3, 4, 3);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(135, 33);
            radFemale.TabIndex = 15;
            radFemale.TabStop = true;
            radFemale.Text = "Not Male";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(517, 111);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 29);
            label7.TabIndex = 16;
            label7.Text = "Gender:";
            // 
            // pnlvalidateGender
            // 
            pnlvalidateGender.BackColor = SystemColors.AppWorkspace;
            pnlvalidateGender.BorderStyle = BorderStyle.Fixed3D;
            pnlvalidateGender.Controls.Add(radFemale);
            pnlvalidateGender.Controls.Add(radMale);
            pnlvalidateGender.Location = new Point(643, 111);
            pnlvalidateGender.Margin = new Padding(4, 3, 4, 3);
            pnlvalidateGender.Name = "pnlvalidateGender";
            pnlvalidateGender.Size = new Size(236, 88);
            pnlvalidateGender.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.Location = new Point(0, 577);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(1215, 56);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add member to the house";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(pnlValidateAge);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(pnlvalidateGender);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtMName);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtLName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtFName);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(16, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(901, 216);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Person";
            // 
            // pnlValidateAge
            // 
            pnlValidateAge.BackColor = SystemColors.AppWorkspace;
            pnlValidateAge.BorderStyle = BorderStyle.Fixed3D;
            pnlValidateAge.Controls.Add(dtpAge);
            pnlValidateAge.ForeColor = SystemColors.ActiveCaptionText;
            pnlValidateAge.Location = new Point(644, 46);
            pnlValidateAge.Margin = new Padding(4, 3, 4, 3);
            pnlValidateAge.Name = "pnlValidateAge";
            pnlValidateAge.Size = new Size(235, 44);
            pnlValidateAge.TabIndex = 20;
            // 
            // dtpAge
            // 
            dtpAge.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dtpAge.CalendarTitleForeColor = SystemColors.ActiveCaption;
            dtpAge.Format = DateTimePickerFormat.Short;
            dtpAge.Location = new Point(-3, 5);
            dtpAge.Margin = new Padding(4, 3, 4, 3);
            dtpAge.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpAge.Name = "dtpAge";
            dtpAge.Size = new Size(224, 35);
            dtpAge.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(511, 60);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(106, 29);
            label10.TabIndex = 8;
            label10.Text = "Birthday:";
            // 
            // txtMName
            // 
            txtMName.Location = new Point(246, 152);
            txtMName.Margin = new Padding(4, 3, 4, 3);
            txtMName.Name = "txtMName";
            txtMName.PlaceholderText = "Optional";
            txtMName.Size = new Size(287, 35);
            txtMName.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(58, 155);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(159, 29);
            label9.TabIndex = 6;
            label9.Text = "Middle name:";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(175, 108);
            txtLName.Margin = new Padding(4, 3, 4, 3);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(287, 35);
            txtLName.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 108);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(135, 29);
            label8.TabIndex = 4;
            label8.Text = "Last name: ";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(175, 57);
            txtFName.Margin = new Padding(4, 3, 4, 3);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(287, 35);
            txtFName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 60);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(138, 29);
            label6.TabIndex = 2;
            label6.Text = "First name: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pnlValidateJob);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numExperience);
            groupBox2.Controls.Add(numMonthlySalary);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(45, 271);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(733, 135);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Job Data";
            // 
            // pnlValidateJob
            // 
            pnlValidateJob.BackColor = SystemColors.AppWorkspace;
            pnlValidateJob.BorderStyle = BorderStyle.Fixed3D;
            pnlValidateJob.Controls.Add(cmbJob);
            pnlValidateJob.Location = new Point(90, 33);
            pnlValidateJob.Margin = new Padding(4, 3, 4, 3);
            pnlValidateJob.Name = "pnlValidateJob";
            pnlValidateJob.Size = new Size(537, 43);
            pnlValidateJob.TabIndex = 13;
            // 
            // cmbJob
            // 
            cmbJob.Font = new Font("David", 14F, FontStyle.Bold, GraphicsUnit.Point);
            cmbJob.FormattingEnabled = true;
            cmbJob.Location = new Point(-3, 7);
            cmbJob.Margin = new Padding(4, 3, 4, 3);
            cmbJob.Name = "cmbJob";
            cmbJob.Size = new Size(527, 36);
            cmbJob.Sorted = true;
            cmbJob.TabIndex = 5;
            // 
            // clbExpenses
            // 
            clbExpenses.BackColor = SystemColors.AppWorkspace;
            clbExpenses.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clbExpenses.FormattingEnabled = true;
            clbExpenses.Items.AddRange(new object[] { "Transportation", "Clothing And Shoes", "Sports And Leisure", "Markets", "Utilities", "Rent Per Month", "Restaurants" });
            clbExpenses.Location = new Point(0, 0);
            clbExpenses.Margin = new Padding(4, 3, 4, 3);
            clbExpenses.Name = "clbExpenses";
            clbExpenses.Size = new Size(256, 228);
            clbExpenses.TabIndex = 21;
            clbExpenses.ItemCheck += clbExpenses_ItemCheck;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(splitContainer1);
            groupBox4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(801, 271);
            groupBox4.Margin = new Padding(4, 3, 4, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 3, 4, 3);
            groupBox4.Size = new Size(401, 263);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Expenses";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 34);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(clbExpenses);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(numRestaurant);
            splitContainer1.Panel2.Controls.Add(numRent);
            splitContainer1.Panel2.Controls.Add(numMarket);
            splitContainer1.Panel2.Controls.Add(numUtilities);
            splitContainer1.Panel2.Controls.Add(numTransport);
            splitContainer1.Panel2.Controls.Add(numSport);
            splitContainer1.Panel2.Controls.Add(numClothes);
            splitContainer1.Panel2.Controls.Add(lsbExpensesPrices); 
            splitContainer1.Size = new Size(389, 227);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 25;
            // 
            // numRestaurant
            // 
            numRestaurant.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            numRestaurant.Location = new Point(0, 195);
            numRestaurant.Name = "numRestaurant";
            numRestaurant.Size = new Size(123, 26);
            numRestaurant.TabIndex = 34;
            numRestaurant.Visible = false;
            // 
            // numRent
            // 
            numRent.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            numRent.Location = new Point(-1, 163);
            numRent.Name = "numRent";
            numRent.Size = new Size(124, 26);
            numRent.TabIndex = 33;
            numRent.Visible = false;
            // 
            // numMarket
            // 
            numMarket.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            numMarket.Location = new Point(0, 99);
            numMarket.Name = "numMarket";
            numMarket.Size = new Size(123, 26);
            numMarket.TabIndex = 30;
            numMarket.Visible = false;
            // 
            // numUtilities
            // 
            numUtilities.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            numUtilities.Location = new Point(-1, 131);
            numUtilities.Name = "numUtilities";
            numUtilities.Size = new Size(124, 26);
            numUtilities.TabIndex = 25;
            numUtilities.Visible = false;
            // 
            // numTransport
            // 
            numTransport.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            numTransport.Location = new Point(0, 3);
            numTransport.Name = "numTransport";
            numTransport.Size = new Size(124, 26);
            numTransport.TabIndex = 27;
            numTransport.Visible = false;
            // 
            // numSport
            // 
            numSport.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            numSport.Location = new Point(-1, 67);
            numSport.Name = "numSport";
            numSport.Size = new Size(124, 26);
            numSport.TabIndex = 31;
            numSport.Visible = false;
            // 
            // numClothes
            // 
            numClothes.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            numClothes.Location = new Point(-1, 35);
            numClothes.Name = "numClothes";
            numClothes.Size = new Size(123, 26);
            numClothes.TabIndex = 26;
            numClothes.Visible = false;
            // 
            // lsbExpensesPrices
            // 
            lsbExpensesPrices.BackColor = SystemColors.AppWorkspace;
            lsbExpensesPrices.Dock = DockStyle.Fill;
            lsbExpensesPrices.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lsbExpensesPrices.FormattingEnabled = true;
            lsbExpensesPrices.ItemHeight = 20;
            lsbExpensesPrices.Location = new Point(0, 0);
            lsbExpensesPrices.Name = "lsbExpensesPrices";
            lsbExpensesPrices.Size = new Size(135, 227);
            lsbExpensesPrices.TabIndex = 0;
            lsbExpensesPrices.SelectedIndexChanged += lsbExpensesPrices_SelectedIndexChanged;
            // 
            // Add_Member
            // 
            AutoScaleDimensions = new SizeF(13F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1215, 633);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_Member";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Member";
            ((System.ComponentModel.ISupportInitialize)numMonthlySalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            pnlvalidateGender.ResumeLayout(false);
            pnlvalidateGender.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlValidateAge.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pnlValidateJob.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numRestaurant).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRent).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMarket).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUtilities).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTransport).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSport).EndInit();
            ((System.ComponentModel.ISupportInitialize)numClothes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private NumericUpDown numMonthlySalary;
        private NumericUpDown numExperience;
        private Label label5;
        private RadioButton radMale;
        private RadioButton radFemale;
        private Label label7;
        private Panel pnlvalidateGender;
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
        private GroupBox groupBox3;
        private Panel pnlValidateAge;
        private Panel pnlValidateJob;
        private ComboBox cmbJob;
        private CheckedListBox clbExpenses;
        private GroupBox groupBox4;
        private NumericUpDown numUtilities;
        private SplitContainer splitContainer1;
        private ListBox lsbExpensesPrices;
        private NumericUpDown numTransport;
        private NumericUpDown numClothes;
        private NumericUpDown numMarket;
        private NumericUpDown numRestaurant;
        private NumericUpDown numRent;
        private NumericUpDown numSport;
    }
}