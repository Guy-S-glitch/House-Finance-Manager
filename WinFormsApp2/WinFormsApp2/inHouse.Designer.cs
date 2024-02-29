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
            memberRemove = new Button();
            memberAdd = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(memberRemove);
            splitContainer1.Panel1.Controls.Add(memberAdd);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
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
            lstMembersList.Size = new Size(382, 582);
            lstMembersList.TabIndex = 3;
            lstMembersList.SelectedIndexChanged += memberAdd_Select;
            // 
            // memberRemove
            // 
            memberRemove.Dock = DockStyle.Bottom;
            memberRemove.Location = new Point(0, 639);
            memberRemove.Name = "memberRemove";
            memberRemove.Size = new Size(382, 34);
            memberRemove.TabIndex = 0;
            memberRemove.Text = "Remove member";
            memberRemove.UseVisualStyleBackColor = true;
            memberRemove.Click += memberRemove_Click;
            // 
            // memberAdd
            // 
            memberAdd.Dock = DockStyle.Bottom;
            memberAdd.Location = new Point(0, 673);
            memberAdd.Name = "memberAdd";
            memberAdd.Size = new Size(382, 34);
            memberAdd.TabIndex = 2;
            memberAdd.Text = "Add member";
            memberAdd.UseVisualStyleBackColor = true;
            memberAdd.Click += memberAdd_Click;
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
            // inHouse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 707);
            Controls.Add(splitContainer1);
            Name = "inHouse";
            Text = "inHouse";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button memberAdd;
        private Button memberRemove;
        private ListBox lstMembersList;
    }
}