namespace LibraryManagementSystem
{
    partial class MainForm
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
            panelMenu = new Panel();
            btnBorrows = new Button();
            btnStudents = new Button();
            btnBooks = new Button();
            panelMain = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(btnBorrows);
            panelMenu.Controls.Add(btnStudents);
            panelMenu.Controls.Add(btnBooks);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(183, 338);
            panelMenu.TabIndex = 0;
            // 
            // btnBorrows
            // 
            btnBorrows.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBorrows.Location = new Point(18, 152);
            btnBorrows.Margin = new Padding(3, 2, 3, 2);
            btnBorrows.Name = "btnBorrows";
            btnBorrows.Size = new Size(90, 22);
            btnBorrows.TabIndex = 2;
            btnBorrows.Text = "Borrows";
            btnBorrows.UseVisualStyleBackColor = true;
            btnBorrows.Click += btnBorrows_Click;
            // 
            // btnStudents
            // 
            btnStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnStudents.Location = new Point(18, 110);
            btnStudents.Margin = new Padding(3, 2, 3, 2);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(90, 22);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnBooks
            // 
            btnBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnBooks.Location = new Point(18, 62);
            btnBooks.Margin = new Padding(3, 2, 3, 2);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(90, 22);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(183, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(517, 338);
            panelMain.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 3;
            label1.Text = "Library Management System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainForm_FormClosing;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnBooks;
        private Panel panelMain;
        private Button btnStudents;
        private Button btnBorrows;
        private Label label1;
    }
}
