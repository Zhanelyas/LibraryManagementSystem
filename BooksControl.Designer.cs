namespace LibraryManagementSystem
{
    partial class BooksControl
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
            components = new System.ComponentModel.Container();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnAddBook = new Button();
            btnDelete = new Button();
            btnExportCsv = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbBookCategory = new ComboBox();
            numBookPages = new NumericUpDown();
            numBookYear = new NumericUpDown();
            txtBookTitle = new TextBox();
            dgvBooks = new DataGridView();
            panel2 = new Panel();
            bindingSourceBooks = new BindingSource(components);
            btnImportCsv = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBookPages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBookYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceBooks).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(18, 39);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(129, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(34, 82);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 22);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(34, 120);
            btnAddBook.Margin = new Padding(3, 2, 3, 2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(82, 22);
            btnAddBook.TabIndex = 3;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(34, 158);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(34, 198);
            btnExportCsv.Margin = new Padding(3, 2, 3, 2);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(82, 22);
            btnExportCsv.TabIndex = 5;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnImportCsv);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbBookCategory);
            panel1.Controls.Add(numBookPages);
            panel1.Controls.Add(numBookYear);
            panel1.Controls.Add(txtBookTitle);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btnExportCsv);
            panel1.Controls.Add(btnRefresh);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnAddBook);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 570);
            panel1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 425);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 13;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 364);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 12;
            label3.Text = "Pages";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 303);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 11;
            label2.Text = "Year";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 259);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 10;
            label1.Text = "Book title:";
            // 
            // cmbBookCategory
            // 
            cmbBookCategory.FormattingEnabled = true;
            cmbBookCategory.Location = new Point(22, 443);
            cmbBookCategory.Name = "cmbBookCategory";
            cmbBookCategory.Size = new Size(121, 23);
            cmbBookCategory.TabIndex = 9;
            // 
            // numBookPages
            // 
            numBookPages.Location = new Point(22, 382);
            numBookPages.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numBookPages.Name = "numBookPages";
            numBookPages.Size = new Size(120, 23);
            numBookPages.TabIndex = 8;
            // 
            // numBookYear
            // 
            numBookYear.Location = new Point(23, 331);
            numBookYear.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numBookYear.Name = "numBookYear";
            numBookYear.Size = new Size(120, 23);
            numBookYear.TabIndex = 7;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(22, 277);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(129, 23);
            txtBookTitle.TabIndex = 6;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Dock = DockStyle.Right;
            dgvBooks.Location = new Point(0, 0);
            dgvBooks.Margin = new Padding(3, 2, 3, 2);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(842, 570);
            dgvBooks.TabIndex = 0;
            dgvBooks.CellContentClick += dgvBooks_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvBooks);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 570);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // btnImportCsv
            // 
            btnImportCsv.Location = new Point(39, 232);
            btnImportCsv.Name = "btnImportCsv";
            btnImportCsv.Size = new Size(75, 23);
            btnImportCsv.TabIndex = 14;
            btnImportCsv.Text = "Import CSV";
            btnImportCsv.UseVisualStyleBackColor = true;
            btnImportCsv.Click += btnImportCsv_Click;
            // 
            // BooksControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BooksControl";
            Size = new Size(842, 570);
            Load += BooksControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBookPages).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBookYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnAddBook;
        private Button btnDelete;
        private Button btnExportCsv;
        private Panel panel1;
        private DataGridView dgvBooks;
        private Panel panel2;
        private TextBox txtBookTitle;
        private BindingSource bindingSourceBooks;
        private ComboBox cmbBookCategory;
        private NumericUpDown numBookPages;
        private NumericUpDown numBookYear;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnImportCsv;
    }
}
