namespace LibraryManagementSystem
{
    partial class BorrowControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbStudents = new ComboBox();
            cmbBooks = new ComboBox();
            dtpBorrowDate = new DateTimePicker();
            btnAddBorrow = new Button();
            dgvBorrows = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(34, 51);
            cmbStudents.Margin = new Padding(3, 2, 3, 2);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(133, 23);
            cmbStudents.TabIndex = 0;
            cmbStudents.Text = "Student";
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(34, 88);
            cmbBooks.Margin = new Padding(3, 2, 3, 2);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(133, 23);
            cmbBooks.TabIndex = 1;
            cmbBooks.Text = "Book";
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Location = new Point(34, 129);
            dtpBorrowDate.Margin = new Padding(3, 2, 3, 2);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(219, 23);
            dtpBorrowDate.TabIndex = 2;
            // 
            // btnAddBorrow
            // 
            btnAddBorrow.Location = new Point(34, 169);
            btnAddBorrow.Margin = new Padding(3, 2, 3, 2);
            btnAddBorrow.Name = "btnAddBorrow";
            btnAddBorrow.Size = new Size(187, 22);
            btnAddBorrow.TabIndex = 3;
            btnAddBorrow.Text = "Add Borrow";
            btnAddBorrow.UseVisualStyleBackColor = true;
            btnAddBorrow.Click += btnAddBorrow_Click;
            // 
            // dgvBorrows
            // 
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrows.Dock = DockStyle.Fill;
            dgvBorrows.Location = new Point(287, 0);
            dgvBorrows.Margin = new Padding(3, 2, 3, 2);
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.RowHeadersWidth = 51;
            dgvBorrows.Size = new Size(579, 488);
            dgvBorrows.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbStudents);
            panel1.Controls.Add(btnAddBorrow);
            panel1.Controls.Add(cmbBooks);
            panel1.Controls.Add(dtpBorrowDate);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 488);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(866, 488);
            panel2.TabIndex = 6;
            // 
            // BorrowControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBorrows);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BorrowControl";
            Size = new Size(866, 488);
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbStudents;
        private ComboBox cmbBooks;
        private DateTimePicker dtpBorrowDate;
        private Button btnAddBorrow;
        private DataGridView dgvBorrows;
        private Panel panel1;
        private Panel panel2;
    }
}
