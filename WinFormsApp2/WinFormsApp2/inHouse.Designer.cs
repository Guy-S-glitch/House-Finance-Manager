namespace House_Finance_management
{
    partial class inHouse
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
            splitContainer1 = new SplitContainer();
            lstMembersList = new ListBox();
            btnInspectMember = new Button();
            btnmemberRemove = new Button();
            btnmemberAdd = new Button();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtExperience = new Label();
            txtJobTitle = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            txtMonthlySalary = new Label();
            label6 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            lblUserGender = new Label();
            lblUserName = new Label();
            lblUserAge = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lstMembersList);
            splitContainer1.Panel1.Controls.Add(btnInspectMember);
            splitContainer1.Panel1.Controls.Add(btnmemberRemove);
            splitContainer1.Panel1.Controls.Add(btnmemberAdd);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            splitContainer1.Size = new Size(1271, 556);
            splitContainer1.SplitterDistance = 488;
            splitContainer1.TabIndex = 0;
            // 
            // lstMembersList
            // 
            lstMembersList.Dock = DockStyle.Fill;
            lstMembersList.Font = new Font("David", 22F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lstMembersList.FormattingEnabled = true;
            lstMembersList.ItemHeight = 43;
            lstMembersList.Location = new Point(0, 57);
            lstMembersList.Name = "lstMembersList";
            lstMembersList.Size = new Size(488, 397);
            lstMembersList.TabIndex = 3;
            lstMembersList.SelectedIndexChanged += memberAdd_Select;
            // 
            // btnInspectMember
            // 
            btnInspectMember.Dock = DockStyle.Bottom;
            btnInspectMember.Location = new Point(0, 454);
            btnInspectMember.Name = "btnInspectMember";
            btnInspectMember.Size = new Size(488, 34);
            btnInspectMember.TabIndex = 3;
            btnInspectMember.Text = "Inspect member";
            btnInspectMember.UseVisualStyleBackColor = true;
            btnInspectMember.Click += btnInspectMember_Click;
            // 
            // btnmemberRemove
            // 
            btnmemberRemove.Dock = DockStyle.Bottom;
            btnmemberRemove.Location = new Point(0, 488);
            btnmemberRemove.Name = "btnmemberRemove";
            btnmemberRemove.Size = new Size(488, 34);
            btnmemberRemove.TabIndex = 0;
            btnmemberRemove.Text = "Remove member";
            btnmemberRemove.UseVisualStyleBackColor = true;
            btnmemberRemove.Click += btnmemberRemove_Click;
            // 
            // btnmemberAdd
            // 
            btnmemberAdd.Dock = DockStyle.Bottom;
            btnmemberAdd.Location = new Point(0, 522);
            btnmemberAdd.Name = "btnmemberAdd";
            btnmemberAdd.Size = new Size(488, 34);
            btnmemberAdd.TabIndex = 2;
            btnmemberAdd.Text = "Add member";
            btnmemberAdd.UseVisualStyleBackColor = true;
            btnmemberAdd.Click += btnmemberAdd_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Stencil", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(488, 57);
            label1.TabIndex = 0;
            label1.Text = "people";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(txtExperience, 1, 1);
            tableLayoutPanel2.Controls.Add(txtJobTitle, 1, 0);
            tableLayoutPanel2.Controls.Add(label8, 0, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 0);
            tableLayoutPanel2.Controls.Add(label9, 3, 1);
            tableLayoutPanel2.Controls.Add(txtMonthlySalary, 4, 1);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Font = new Font("David", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel2.Location = new Point(0, 231);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(779, 74);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // txtExperience
            // 
            txtExperience.AutoSize = true;
            txtExperience.Location = new Point(332, 35);
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(42, 35);
            txtExperience.TabIndex = 15;
            txtExperience.Text = "...";
            // 
            // txtJobTitle
            // 
            txtJobTitle.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(txtJobTitle, 4);
            txtJobTitle.Dock = DockStyle.Fill;
            txtJobTitle.Location = new Point(332, 0);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(444, 35);
            txtJobTitle.TabIndex = 14;
            txtJobTitle.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Right;
            label8.Location = new Point(3, 35);
            label8.Name = "label8";
            label8.Size = new Size(323, 39);
            label8.TabIndex = 13;
            label8.Text = "Years of experience: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Location = new Point(183, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 35);
            label7.TabIndex = 13;
            label7.Text = "Job title:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Right;
            label9.Location = new Point(400, 35);
            label9.Name = "label9";
            label9.Size = new Size(253, 39);
            label9.TabIndex = 16;
            label9.Text = "Monthly Salary:";
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.AutoSize = true;
            txtMonthlySalary.Location = new Point(659, 35);
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.Size = new Size(42, 35);
            txtMonthlySalary.TabIndex = 17;
            txtMonthlySalary.Text = "...";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("David", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 199);
            label6.Name = "label6";
            label6.Size = new Size(779, 32);
            label6.TabIndex = 11;
            label6.Text = "Job Information";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.Controls.Add(iconPictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(lblUserGender, 2, 2);
            tableLayoutPanel1.Controls.Add(lblUserName, 2, 0);
            tableLayoutPanel1.Controls.Add(lblUserAge, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("David", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 32);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(779, 167);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 161;
            iconPictureBox1.Location = new Point(3, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            tableLayoutPanel1.SetRowSpan(iconPictureBox1, 3);
            iconPictureBox1.Size = new Size(165, 161);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(174, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 55);
            label2.TabIndex = 2;
            label2.Text = "Name: ";
            // 
            // lblUserGender
            // 
            lblUserGender.AutoSize = true;
            lblUserGender.Location = new Point(376, 110);
            lblUserGender.Name = "lblUserGender";
            lblUserGender.Size = new Size(42, 35);
            lblUserGender.TabIndex = 6;
            lblUserGender.Text = "...";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(376, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(42, 35);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "...";
            // 
            // lblUserAge
            // 
            lblUserAge.AutoSize = true;
            lblUserAge.Location = new Point(376, 55);
            lblUserAge.Name = "lblUserAge";
            lblUserAge.Size = new Size(42, 35);
            lblUserAge.TabIndex = 7;
            lblUserAge.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(174, 110);
            label5.Name = "label5";
            label5.Size = new Size(196, 57);
            label5.TabIndex = 8;
            label5.Text = "Gender: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(174, 55);
            label4.Name = "label4";
            label4.Size = new Size(196, 55);
            label4.TabIndex = 5;
            label4.Text = "Age: ";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(779, 32);
            label3.TabIndex = 9;
            label3.Text = "Personal Info";
            // 
            // inHouse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 556);
            Controls.Add(splitContainer1);
            Name = "inHouse";
            Text = "inHouse";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button btnmemberAdd;
        private Button btnmemberRemove;
        private ListBox lstMembersList;
        private Label lblUserName;
        private Label label2;
        private Label label4;
        private Label lblUserGender;
        private Label label5;
        private Label lblUserAge;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button btnInspectMember;
        private Label label6;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel2;
        private Label txtExperience;
        private Label txtJobTitle;
        private Label label8;
        private Label label7;
        private Label txtMonthlySalary;
    }
}