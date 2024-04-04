namespace WinFormsApp2
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            close = new FontAwesome.Sharp.IconButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            addHouse = new FontAwesome.Sharp.IconButton();
            HouseT1 = new TableLayoutPanel();
            HouseC1 = new Button();
            House1 = new FontAwesome.Sharp.IconButton();
            CompareView = new TableLayoutPanel();
            dataGridViewComparison = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            HouseT1.SuspendLayout();
            CompareView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComparison).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(240, 240, 240);
            panel1.Controls.Add(CompareView);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 591);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1129, 591);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(close);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1129, 50);
            panel2.TabIndex = 5;
            // 
            // close
            // 
            close.BackColor = Color.IndianRed;
            close.Cursor = Cursors.Hand;
            close.Dock = DockStyle.Right;
            close.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            close.IconColor = Color.WhiteSmoke;
            close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            close.Location = new Point(1029, 0);
            close.MaximumSize = new Size(100, 50);
            close.MinimumSize = new Size(100, 50);
            close.Name = "close";
            close.Size = new Size(100, 50);
            close.TabIndex = 0;
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(245, 245, 245);
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(addHouse, 1, 0);
            tableLayoutPanel1.Controls.Add(HouseT1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1123, 535);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // addHouse
            // 
            addHouse.BackColor = Color.FromArgb(220, 220, 220);
            addHouse.Cursor = Cursors.Hand;
            addHouse.Dock = DockStyle.Fill;
            addHouse.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            addHouse.IconColor = Color.Black;
            addHouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addHouse.IconSize = 78;
            addHouse.Location = new Point(227, 3);
            addHouse.Name = "addHouse";
            addHouse.Size = new Size(218, 101);
            addHouse.TabIndex = 2;
            addHouse.UseVisualStyleBackColor = false;
            addHouse.Click += AddHouse_Click;
            // 
            // HouseT1
            // 
            HouseT1.ColumnCount = 1;
            HouseT1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            HouseT1.Controls.Add(HouseC1, 0, 1);
            HouseT1.Controls.Add(House1, 0, 0);
            HouseT1.Dock = DockStyle.Fill;
            HouseT1.Location = new Point(3, 3);
            HouseT1.Name = "HouseT1";
            HouseT1.RowCount = 2;
            HouseT1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            HouseT1.RowStyles.Add(new RowStyle());
            HouseT1.Size = new Size(218, 101);
            HouseT1.TabIndex = 3;
            // 
            // HouseC1
            // 
            HouseC1.AutoSize = true;
            HouseC1.Dock = DockStyle.Fill;
            HouseC1.Location = new Point(3, 63);
            HouseC1.Name = "HouseC1";
            HouseC1.Size = new Size(212, 35);
            HouseC1.TabIndex = 2;
            HouseC1.Text = "Compare house";
            HouseC1.UseVisualStyleBackColor = true;
            HouseC1.Click += HouseCompare_Click;
            // 
            // House1
            // 
            House1.BackColor = Color.FromArgb(52, 152, 219);
            House1.Cursor = Cursors.Hand;
            House1.Dock = DockStyle.Fill;
            House1.FlatAppearance.BorderSize = 0;
            House1.FlatStyle = FlatStyle.Flat;
            House1.Font = new Font("David", 8F, FontStyle.Regular, GraphicsUnit.Point);
            House1.ForeColor = Color.White;
            House1.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            House1.IconColor = Color.Black;
            House1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            House1.ImageAlign = ContentAlignment.TopRight;
            House1.Location = new Point(3, 3);
            House1.Name = "House1";
            House1.Size = new Size(212, 54);
            House1.TabIndex = 1;
            House1.Text = "house 1";
            House1.TextAlign = ContentAlignment.TopLeft;
            House1.UseVisualStyleBackColor = false;
            House1.Click += House1_Click;
            // 
            // CompareView
            // 
            CompareView.AutoSize = true;
            CompareView.BackColor = Color.Transparent;
            CompareView.ColumnCount = 1;
            CompareView.ColumnStyles.Add(new ColumnStyle());
            CompareView.Controls.Add(dataGridViewComparison, 0, 0);
            CompareView.Controls.Add(button1, 0, 1);
            CompareView.Location = new Point(250, 169);
            CompareView.Name = "CompareView";
            CompareView.RowCount = 2;
            CompareView.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CompareView.RowStyles.Add(new RowStyle());
            CompareView.Size = new Size(669, 406);
            CompareView.TabIndex = 8;
            CompareView.Visible = false;
            // 
            // dataGridViewComparison
            // 
            dataGridViewComparison.AllowUserToAddRows = false;
            dataGridViewComparison.AllowUserToDeleteRows = false;
            dataGridViewComparison.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComparison.Dock = DockStyle.Fill;
            dataGridViewComparison.Location = new Point(3, 3);
            dataGridViewComparison.Name = "dataGridViewComparison";
            dataGridViewComparison.ReadOnly = true;
            dataGridViewComparison.RowHeadersWidth = 62;
            dataGridViewComparison.RowTemplate.Height = 33;
            dataGridViewComparison.Size = new Size(663, 360);
            dataGridViewComparison.TabIndex = 7;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 369);
            button1.Name = "button1";
            button1.Size = new Size(663, 34);
            button1.TabIndex = 8;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 591);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosing += Main_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            HouseT1.ResumeLayout(false);
            HouseT1.PerformLayout();
            CompareView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewComparison).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton House1;
        private TableLayoutPanel house_1;
        private Button AddHouse;
        private FontAwesome.Sharp.IconButton close;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton addHouse;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel HouseT1;
        private Button HouseC1;
        private TableLayoutPanel CompareView;
        private Button button1;
        private DataGridView dataGridViewComparison;
        private TableLayoutPanel MainPanel;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
