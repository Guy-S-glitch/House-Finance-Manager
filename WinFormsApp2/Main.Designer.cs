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
            tableLayoutPanel1 = new TableLayoutPanel();
            House1 = new FontAwesome.Sharp.IconButton();
            AddHouse = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1129, 591);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(House1, 0, 0);
            tableLayoutPanel1.Controls.Add(AddHouse, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1129, 591);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // House1
            // 
            House1.Dock = DockStyle.Fill;
            House1.Font = new Font("David", 8F, FontStyle.Regular, GraphicsUnit.Point);
            House1.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            House1.IconColor = Color.Black;
            House1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            House1.ImageAlign = ContentAlignment.TopRight;
            House1.Location = new Point(3, 3);
            House1.Name = "House1";
            House1.Size = new Size(219, 112);
            House1.TabIndex = 1;
            House1.Text = "house 1";
            House1.TextAlign = ContentAlignment.TopLeft;
            House1.UseVisualStyleBackColor = true;
            House1.Click += House1_Click;
            // 
            // AddHouse
            // 
            AddHouse.Dock = DockStyle.Fill;
            AddHouse.Location = new Point(228, 3);
            AddHouse.Name = "AddHouse";
            AddHouse.Size = new Size(219, 112);
            AddHouse.TabIndex = 2;
            AddHouse.Text = "Add house";
            AddHouse.UseVisualStyleBackColor = true;
            AddHouse.Click += AddHouse_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 591);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton House1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AddHouse;
    }
}
