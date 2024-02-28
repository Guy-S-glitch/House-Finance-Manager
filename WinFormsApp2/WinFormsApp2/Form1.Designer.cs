namespace WinFormsApp2
{
    partial class Form1
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
            splitContainer3 = new SplitContainer();
            House3 = new FontAwesome.Sharp.IconButton();
            House4 = new FontAwesome.Sharp.IconButton();
            splitContainer2 = new SplitContainer();
            House5 = new FontAwesome.Sharp.IconButton();
            House6 = new FontAwesome.Sharp.IconButton();
            splitContainer1 = new SplitContainer();
            House1 = new FontAwesome.Sharp.IconButton();
            House2 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer3);
            panel1.Controls.Add(splitContainer2);
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1377, 591);
            panel1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 165);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(House3);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(House4);
            splitContainer3.Size = new Size(1377, 221);
            splitContainer3.SplitterDistance = 691;
            splitContainer3.TabIndex = 2;
            // 
            // House3
            // 
            House3.Dock = DockStyle.Fill;
            House3.IconChar = FontAwesome.Sharp.IconChar.HouseFloodWater;
            House3.IconColor = Color.Black;
            House3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            House3.Location = new Point(0, 0);
            House3.Name = "House3";
            House3.Size = new Size(691, 221);
            House3.TabIndex = 0;
            House3.Text = "House 3";
            House3.TextAlign = ContentAlignment.BottomCenter;
            House3.UseVisualStyleBackColor = true;
            // 
            // House4
            // 
            House4.Dock = DockStyle.Fill;
            House4.IconChar = FontAwesome.Sharp.IconChar.HouseMedical;
            House4.IconColor = Color.Black;
            House4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            House4.Location = new Point(0, 0);
            House4.Name = "House4";
            House4.Size = new Size(682, 221);
            House4.TabIndex = 1;
            House4.Text = "House 4";
            House4.TextAlign = ContentAlignment.BottomCenter;
            House4.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Bottom;
            splitContainer2.Location = new Point(0, 386);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(House5);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(House6);
            splitContainer2.Size = new Size(1377, 205);
            splitContainer2.SplitterDistance = 470;
            splitContainer2.TabIndex = 1;
            // 
            // House5
            // 
            House5.Dock = DockStyle.Fill;
            House5.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            House5.IconColor = Color.Black;
            House5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            House5.Location = new Point(0, 0);
            House5.Name = "House5";
            House5.Size = new Size(470, 205);
            House5.TabIndex = 1;
            House5.Text = "House 5";
            House5.TextAlign = ContentAlignment.BottomCenter;
            House5.UseVisualStyleBackColor = true;
            // 
            // House6
            // 
            House6.Dock = DockStyle.Fill;
            House6.IconChar = FontAwesome.Sharp.IconChar.HouseFloodWater;
            House6.IconColor = Color.Black;
            House6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            House6.Location = new Point(0, 0);
            House6.Name = "House6";
            House6.Size = new Size(903, 205);
            House6.TabIndex = 1;
            House6.Text = "House 6";
            House6.TextAlign = ContentAlignment.BottomCenter;
            House6.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Top;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(House1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(House2);
            splitContainer1.Size = new Size(1377, 165);
            splitContainer1.SplitterDistance = 514;
            splitContainer1.TabIndex = 0;
            // 
            // House1
            // 
            House1.Dock = DockStyle.Fill;
            House1.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            House1.IconColor = Color.Black;
            House1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            House1.Location = new Point(0, 0);
            House1.Name = "House1";
            House1.Size = new Size(514, 165);
            House1.TabIndex = 1;
            House1.Text = "House 1";
            House1.TextAlign = ContentAlignment.BottomCenter;
            House1.UseVisualStyleBackColor = true;
            House1.Click += House1_Click;
            // 
            // House2
            // 
            House2.Dock = DockStyle.Fill;
            House2.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            House2.IconColor = Color.Black;
            House2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            House2.Location = new Point(0, 0);
            House2.Name = "House2";
            House2.Size = new Size(859, 165);
            House2.TabIndex = 0;
            House2.Text = "House 2";
            House2.TextAlign = ContentAlignment.BottomCenter;
            House2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1377, 591);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer1;
        private FontAwesome.Sharp.IconButton House3;
        private FontAwesome.Sharp.IconButton House2;
        private FontAwesome.Sharp.IconButton House4;
        private FontAwesome.Sharp.IconButton House5;
        private FontAwesome.Sharp.IconButton House6;
        private FontAwesome.Sharp.IconButton House1;
    }
}
