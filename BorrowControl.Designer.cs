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
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).BeginInit();
            SuspendLayout();
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(77, 94);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(151, 28);
            cmbStudents.TabIndex = 0;
            cmbStudents.Text = "Student";
            // 
            // cmbBooks
            // 
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(77, 149);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(151, 28);
            cmbBooks.TabIndex = 1;
            cmbBooks.Text = "Book";
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Location = new Point(78, 200);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(250, 27);
            dtpBorrowDate.TabIndex = 2;
            // 
            // btnAddBorrow
            // 
            btnAddBorrow.Location = new Point(78, 244);
            btnAddBorrow.Name = "btnAddBorrow";
            btnAddBorrow.Size = new Size(214, 29);
            btnAddBorrow.TabIndex = 3;
            btnAddBorrow.Text = "Add Borrow";
            btnAddBorrow.UseVisualStyleBackColor = true;
            btnAddBorrow.Click += btnAddBorrow_Click;
            // 
            // dgvBorrows
            // 
            dgvBorrows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrows.Location = new Point(82, 298);
            dgvBorrows.Name = "dgvBorrows";
            dgvBorrows.RowHeadersWidth = 51;
            dgvBorrows.Size = new Size(300, 188);
            dgvBorrows.TabIndex = 4;
            // 
            // BorrowControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBorrows);
            Controls.Add(btnAddBorrow);
            Controls.Add(dtpBorrowDate);
            Controls.Add(cmbBooks);
            Controls.Add(cmbStudents);
            Name = "BorrowControl";
            Size = new Size(686, 511);
            ((System.ComponentModel.ISupportInitialize)dgvBorrows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbStudents;
        private ComboBox cmbBooks;
        private DateTimePicker dtpBorrowDate;
        private Button btnAddBorrow;
        private DataGridView dgvBorrows;
    }
}
