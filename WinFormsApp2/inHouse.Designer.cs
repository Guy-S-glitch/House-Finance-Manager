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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            lstMembersList = new ListBox();
            btnInspectMember = new Button();
            btnmemberRemove = new Button();
            btnmemberAdd = new Button();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label17 = new Label();
            label16 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            pbTransportation = new ProgressBar();
            pbClothes = new ProgressBar();
            pbSports = new ProgressBar();
            pbMarkets = new ProgressBar();
            pbUtilities = new ProgressBar();
            pbRent = new ProgressBar();
            pbRestaurants = new ProgressBar();
            pcTransportation = new Label();
            pcClothes = new Label();
            pcSports = new Label();
            pcMarkets = new Label();
            pcUtilities = new Label();
            pcRent = new Label();
            pcRestaurants = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
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
            dataSentHandlerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataSentHandlerBindingSource).BeginInit();
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
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel3);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            splitContainer1.Size = new Size(1271, 706);
            splitContainer1.SplitterDistance = 488;
            splitContainer1.TabIndex = 0;
            // 
            // lstMembersList
            // 
            lstMembersList.Dock = DockStyle.Fill;
            lstMembersList.Font = new Font("David", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lstMembersList.FormattingEnabled = true;
            lstMembersList.ItemHeight = 32;
            lstMembersList.Location = new Point(0, 57);
            lstMembersList.Name = "lstMembersList";
            lstMembersList.Size = new Size(488, 547);
            lstMembersList.TabIndex = 3;
            lstMembersList.SelectedIndexChanged += memberAdd_Select;
            // 
            // btnInspectMember
            // 
            btnInspectMember.Dock = DockStyle.Bottom;
            btnInspectMember.Location = new Point(0, 604);
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
            btnmemberRemove.Location = new Point(0, 638);
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
            btnmemberAdd.Location = new Point(0, 672);
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
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 7;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.6653328F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.669333F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.66533F));
            tableLayoutPanel3.Controls.Add(label17, 0, 7);
            tableLayoutPanel3.Controls.Add(label16, 0, 6);
            tableLayoutPanel3.Controls.Add(label10, 0, 0);
            tableLayoutPanel3.Controls.Add(label11, 0, 1);
            tableLayoutPanel3.Controls.Add(label12, 0, 2);
            tableLayoutPanel3.Controls.Add(label13, 0, 3);
            tableLayoutPanel3.Controls.Add(label14, 0, 4);
            tableLayoutPanel3.Controls.Add(label15, 0, 5);
            tableLayoutPanel3.Controls.Add(pbTransportation, 2, 1);
            tableLayoutPanel3.Controls.Add(pbClothes, 2, 2);
            tableLayoutPanel3.Controls.Add(pbSports, 2, 3);
            tableLayoutPanel3.Controls.Add(pbMarkets, 2, 4);
            tableLayoutPanel3.Controls.Add(pbUtilities, 2, 5);
            tableLayoutPanel3.Controls.Add(pbRent, 2, 6);
            tableLayoutPanel3.Controls.Add(pbRestaurants, 2, 7);
            tableLayoutPanel3.Controls.Add(pcTransportation, 1, 1);
            tableLayoutPanel3.Controls.Add(pcClothes, 1, 2);
            tableLayoutPanel3.Controls.Add(pcSports, 1, 3);
            tableLayoutPanel3.Controls.Add(pcMarkets, 1, 4);
            tableLayoutPanel3.Controls.Add(pcUtilities, 1, 5);
            tableLayoutPanel3.Controls.Add(pcRent, 1, 6);
            tableLayoutPanel3.Controls.Add(pcRestaurants, 1, 7);
            tableLayoutPanel3.Controls.Add(label25, 4, 0);
            tableLayoutPanel3.Controls.Add(label26, 4, 1);
            tableLayoutPanel3.Controls.Add(label27, 5, 1);
            tableLayoutPanel3.Controls.Add(label28, 6, 1);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel3.Location = new Point(0, 305);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(779, 333);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 290);
            label17.Name = "label17";
            label17.Size = new Size(123, 24);
            label17.TabIndex = 21;
            label17.Text = "Restaurants";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 250);
            label16.Name = "label16";
            label16.Size = new Size(162, 24);
            label16.TabIndex = 20;
            label16.Text = "Rent Per Month";
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(152, 179, 207);
            tableLayoutPanel3.SetColumnSpan(label10, 3);
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("David", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 0);
            label10.Name = "label10";
            label10.Size = new Size(407, 42);
            label10.TabIndex = 13;
            label10.Text = "Total expenses";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 42);
            label11.Name = "label11";
            label11.Size = new Size(153, 24);
            label11.TabIndex = 15;
            label11.Text = "Transportation";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 82);
            label12.Name = "label12";
            label12.Size = new Size(203, 48);
            label12.TabIndex = 16;
            label12.Text = "Clothing And Shoes\r\n ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 130);
            label13.Name = "label13";
            label13.Size = new Size(200, 24);
            label13.TabIndex = 17;
            label13.Text = "Sports And Leisure ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 170);
            label14.Name = "label14";
            label14.Size = new Size(89, 24);
            label14.TabIndex = 18;
            label14.Text = "Markets";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 210);
            label15.Name = "label15";
            label15.Size = new Size(89, 24);
            label15.TabIndex = 19;
            label15.Text = "Utilities";
            // 
            // pbTransportation
            // 
            pbTransportation.Dock = DockStyle.Fill;
            pbTransportation.Location = new Point(247, 45);
            pbTransportation.Name = "pbTransportation";
            pbTransportation.Size = new Size(163, 34);
            pbTransportation.Step = 1;
            pbTransportation.TabIndex = 14;
            pbTransportation.Value = 100;
            // 
            // pbClothes
            // 
            pbClothes.Dock = DockStyle.Fill;
            pbClothes.Location = new Point(247, 85);
            pbClothes.Name = "pbClothes";
            pbClothes.Size = new Size(163, 42);
            pbClothes.Step = 1;
            pbClothes.TabIndex = 21;
            pbClothes.Value = 100;
            // 
            // pbSports
            // 
            pbSports.Dock = DockStyle.Fill;
            pbSports.Location = new Point(247, 133);
            pbSports.Name = "pbSports";
            pbSports.Size = new Size(163, 34);
            pbSports.Step = 1;
            pbSports.TabIndex = 15;
            pbSports.Value = 100;
            pbSports.Click += pbSports_Click;
            // 
            // pbMarkets
            // 
            pbMarkets.Dock = DockStyle.Fill;
            pbMarkets.Location = new Point(247, 173);
            pbMarkets.Name = "pbMarkets";
            pbMarkets.Size = new Size(163, 34);
            pbMarkets.Step = 1;
            pbMarkets.TabIndex = 22;
            pbMarkets.Value = 100;
            // 
            // pbUtilities
            // 
            pbUtilities.Dock = DockStyle.Fill;
            pbUtilities.Location = new Point(247, 213);
            pbUtilities.Name = "pbUtilities";
            pbUtilities.Size = new Size(163, 34);
            pbUtilities.Step = 1;
            pbUtilities.TabIndex = 23;
            pbUtilities.Value = 100;
            // 
            // pbRent
            // 
            pbRent.Dock = DockStyle.Fill;
            pbRent.Location = new Point(247, 253);
            pbRent.Name = "pbRent";
            pbRent.Size = new Size(163, 34);
            pbRent.Step = 1;
            pbRent.TabIndex = 24;
            pbRent.Value = 100;
            // 
            // pbRestaurants
            // 
            pbRestaurants.Dock = DockStyle.Fill;
            pbRestaurants.Location = new Point(247, 293);
            pbRestaurants.Name = "pbRestaurants";
            pbRestaurants.Size = new Size(163, 37);
            pbRestaurants.Step = 1;
            pbRestaurants.TabIndex = 25;
            pbRestaurants.Value = 100;
            pbRestaurants.Click += pbRestaurants_Click;
            // 
            // pcTransportation
            // 
            pcTransportation.AutoSize = true;
            pcTransportation.Location = new Point(212, 42);
            pcTransportation.Name = "pcTransportation";
            pcTransportation.Size = new Size(29, 24);
            pcTransportation.TabIndex = 26;
            pcTransportation.Text = "%";
            // 
            // pcClothes
            // 
            pcClothes.AutoSize = true;
            pcClothes.Location = new Point(212, 82);
            pcClothes.Name = "pcClothes";
            pcClothes.Size = new Size(29, 24);
            pcClothes.TabIndex = 27;
            pcClothes.Text = "%";
            // 
            // pcSports
            // 
            pcSports.AutoSize = true;
            pcSports.Location = new Point(212, 130);
            pcSports.Name = "pcSports";
            pcSports.Size = new Size(29, 24);
            pcSports.TabIndex = 28;
            pcSports.Text = "%";
            // 
            // pcMarkets
            // 
            pcMarkets.AutoSize = true;
            pcMarkets.Location = new Point(212, 170);
            pcMarkets.Name = "pcMarkets";
            pcMarkets.Size = new Size(29, 24);
            pcMarkets.TabIndex = 29;
            pcMarkets.Text = "%";
            // 
            // pcUtilities
            // 
            pcUtilities.AutoSize = true;
            pcUtilities.Location = new Point(212, 210);
            pcUtilities.Name = "pcUtilities";
            pcUtilities.Size = new Size(29, 24);
            pcUtilities.TabIndex = 30;
            pcUtilities.Text = "%";
            // 
            // pcRent
            // 
            pcRent.AutoSize = true;
            pcRent.Location = new Point(212, 250);
            pcRent.Name = "pcRent";
            pcRent.Size = new Size(29, 24);
            pcRent.TabIndex = 31;
            pcRent.Text = "%";
            // 
            // pcRestaurants
            // 
            pcRestaurants.AutoSize = true;
            pcRestaurants.Location = new Point(212, 290);
            pcRestaurants.Name = "pcRestaurants";
            pcRestaurants.Size = new Size(29, 24);
            pcRestaurants.TabIndex = 32;
            pcRestaurants.Text = "%";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(152, 179, 207);
            tableLayoutPanel3.SetColumnSpan(label25, 3);
            label25.Dock = DockStyle.Fill;
            label25.Font = new Font("David", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(440, 0);
            label25.Name = "label25";
            label25.Size = new Size(336, 42);
            label25.TabIndex = 33;
            label25.Text = "label25";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(440, 42);
            label26.Name = "label26";
            label26.Size = new Size(80, 24);
            label26.TabIndex = 34;
            label26.Text = "label26";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(526, 42);
            label27.Name = "label27";
            label27.Size = new Size(80, 24);
            label27.TabIndex = 35;
            label27.Text = "label27";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(612, 42);
            label28.Name = "label28";
            label28.Size = new Size(80, 24);
            label28.TabIndex = 36;
            label28.Text = "label28";
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
            tableLayoutPanel2.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtExperience.Location = new Point(225, 24);
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(28, 24);
            txtExperience.TabIndex = 15;
            txtExperience.Text = "...";
            // 
            // txtJobTitle
            // 
            txtJobTitle.AutoSize = true;
            tableLayoutPanel2.SetColumnSpan(txtJobTitle, 4);
            txtJobTitle.Dock = DockStyle.Fill;
            txtJobTitle.Location = new Point(225, 0);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(551, 24);
            txtJobTitle.TabIndex = 14;
            txtJobTitle.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Right;
            label8.Location = new Point(3, 24);
            label8.Name = "label8";
            label8.Size = new Size(216, 50);
            label8.TabIndex = 13;
            label8.Text = "Years of experience: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Right;
            label7.Location = new Point(123, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 24);
            label7.TabIndex = 13;
            label7.Text = "Job title:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Right;
            label9.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(279, 24);
            label9.Name = "label9";
            label9.Size = new Size(169, 50);
            label9.TabIndex = 16;
            label9.Text = "Monthly Salary:";
            // 
            // txtMonthlySalary
            // 
            txtMonthlySalary.AutoSize = true;
            txtMonthlySalary.Location = new Point(454, 24);
            txtMonthlySalary.Name = "txtMonthlySalary";
            txtMonthlySalary.Size = new Size(28, 24);
            txtMonthlySalary.TabIndex = 17;
            txtMonthlySalary.Text = "...";
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("David", 16F, FontStyle.Regular, GraphicsUnit.Point);
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(iconPictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(lblUserGender, 2, 2);
            tableLayoutPanel1.Controls.Add(lblUserName, 2, 0);
            tableLayoutPanel1.Controls.Add(lblUserAge, 2, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Font = new Font("David", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            label2.Size = new Size(95, 55);
            label2.TabIndex = 2;
            label2.Text = "Name: ";
            // 
            // lblUserGender
            // 
            lblUserGender.AutoSize = true;
            lblUserGender.Location = new Point(275, 110);
            lblUserGender.Name = "lblUserGender";
            lblUserGender.Size = new Size(28, 24);
            lblUserGender.TabIndex = 6;
            lblUserGender.Text = "...";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(275, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(28, 24);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "...";
            // 
            // lblUserAge
            // 
            lblUserAge.AutoSize = true;
            lblUserAge.Location = new Point(275, 55);
            lblUserAge.Name = "lblUserAge";
            lblUserAge.Size = new Size(28, 24);
            lblUserAge.TabIndex = 7;
            lblUserAge.Text = "...";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(174, 110);
            label5.Name = "label5";
            label5.Size = new Size(95, 57);
            label5.TabIndex = 8;
            label5.Text = "Gender: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(174, 55);
            label4.Name = "label4";
            label4.Size = new Size(95, 55);
            label4.TabIndex = 5;
            label4.Text = "Age: ";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("David", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(779, 32);
            label3.TabIndex = 9;
            label3.Text = "Personal Info";
            // 
            // dataSentHandlerBindingSource
            // 
            dataSentHandlerBindingSource.DataSource = typeof(DataSentHandler);
            // 
            // inHouse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 706);
            Controls.Add(splitContainer1);
            Name = "inHouse";
            Text = "inHouse";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataSentHandlerBindingSource).EndInit();
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
        private TableLayoutPanel tableLayoutPanel3;
        private Label label10;
        private ProgressBar pbTransportation;
        private Label label11;
        private Label label17;
        private ProgressBar pbSports;
        private Label label16;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private ProgressBar pbClothes;
        private ProgressBar pbMarkets;
        private ProgressBar pbUtilities;
        private ProgressBar pbRent;
        private ProgressBar pbRestaurants;
        private Label pcTransportation;
        private Label pcClothes;
        private Label pcSports;
        private Label pcMarkets;
        private Label pcUtilities;
        private Label pcRent;
        private Label pcRestaurants;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private BindingSource dataSentHandlerBindingSource;
    }
}