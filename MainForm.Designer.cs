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
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(btnBorrows);
            panelMenu.Controls.Add(btnStudents);
            panelMenu.Controls.Add(btnBooks);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 450);
            panelMenu.TabIndex = 0;
            // 
            // btnBorrows
            // 
            btnBorrows.Location = new Point(25, 121);
            btnBorrows.Name = "btnBorrows";
            btnBorrows.Size = new Size(94, 29);
            btnBorrows.TabIndex = 2;
            btnBorrows.Text = "Borrows";
            btnBorrows.UseVisualStyleBackColor = true;
            btnBorrows.Click += btnBorrows_Click;
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(22, 76);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(94, 29);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnBooks
            // 
            btnBooks.Location = new Point(20, 29);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(94, 29);
            btnBooks.TabIndex = 0;
            btnBooks.Text = "Books";
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(600, 450);
            panelMain.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += this.MainForm_FormClosing;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnBooks;
        private Panel panelMain;
        private Button btnStudents;
        private Button btnBorrows;
    }
}
