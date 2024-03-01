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
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            splitContainer1.Size = new Size(993, 707);
            splitContainer1.SplitterDistance = 382;
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
            lstMembersList.Size = new Size(382, 548);
            lstMembersList.TabIndex = 3;
            lstMembersList.SelectedIndexChanged += memberAdd_Select;
            // 
            // btnInspectMember
            // 
            btnInspectMember.Dock = DockStyle.Bottom;
            btnInspectMember.Location = new Point(0, 605);
            btnInspectMember.Name = "btnInspectMember";
            btnInspectMember.Size = new Size(382, 34);
            btnInspectMember.TabIndex = 3;
            btnInspectMember.Text = "Inspect member";
            btnInspectMember.UseVisualStyleBackColor = true;
            btnInspectMember.Click += btnInspectMember_Click;
            // 
            // btnmemberRemove
            // 
            btnmemberRemove.Dock = DockStyle.Bottom;
            btnmemberRemove.Location = new Point(0, 639);
            btnmemberRemove.Name = "btnmemberRemove";
            btnmemberRemove.Size = new Size(382, 34);
            btnmemberRemove.TabIndex = 0;
            btnmemberRemove.Text = "Remove member";
            btnmemberRemove.UseVisualStyleBackColor = true;
            btnmemberRemove.Click += btnmemberRemove_Click;
            // 
            // btnmemberAdd
            // 
            btnmemberAdd.Dock = DockStyle.Bottom;
            btnmemberAdd.Location = new Point(0, 673);
            btnmemberAdd.Name = "btnmemberAdd";
            btnmemberAdd.Size = new Size(382, 34);
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
            label1.Size = new Size(382, 57);
            label1.TabIndex = 0;
            label1.Text = "people";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Dock = DockStyle.Top;
            label6.Location = new Point(0, 199);
            label6.Name = "label6";
            label6.Size = new Size(607, 32);
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
            tableLayoutPanel1.Location = new Point(0, 32);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(607, 167);
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
            label2.Size = new Size(139, 55);
            label2.TabIndex = 2;
            label2.Text = "Name: ";
            // 
            // lblUserGender
            // 
            lblUserGender.AutoSize = true;
            lblUserGender.Location = new Point(319, 110);
            lblUserGender.Name = "lblUserGender";
            lblUserGender.Size = new Size(0, 32);
            lblUserGender.TabIndex = 6;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(319, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 32);
            lblUserName.TabIndex = 3;
            // 
            // lblUserAge
            // 
            lblUserAge.AutoSize = true;
            lblUserAge.Location = new Point(319, 55);
            lblUserAge.Name = "lblUserAge";
            lblUserAge.Size = new Size(0, 32);
            lblUserAge.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(174, 110);
            label5.Name = "label5";
            label5.Size = new Size(139, 57);
            label5.TabIndex = 8;
            label5.Text = "Gender: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(174, 55);
            label4.Name = "label4";
            label4.Size = new Size(139, 55);
            label4.TabIndex = 5;
            label4.Text = "Age: ";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(607, 32);
            label3.TabIndex = 9;
            label3.Text = "Personal Info";
            // 
            // inHouse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 707);
            Controls.Add(splitContainer1);
            Name = "inHouse";
            Text = "inHouse";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
    }
}