namespace LibraryManagementSystem
{
    partial class AddBookForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            numYear = new NumericUpDown();
            numPages = new NumericUpDown();
            cmbCategory = new ComboBox();
            btnOkay = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 43);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 112);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 1;
            label2.Text = "Publication Year";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 43);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Page Count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 112);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "Category Id";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(58, 71);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(110, 23);
            txtTitle.TabIndex = 4;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // numYear
            // 
            numYear.Location = new Point(58, 141);
            numYear.Margin = new Padding(3, 2, 3, 2);
            numYear.Name = "numYear";
            numYear.Size = new Size(131, 23);
            numYear.TabIndex = 5;
            // 
            // numPages
            // 
            numPages.Location = new Point(304, 71);
            numPages.Margin = new Padding(3, 2, 3, 2);
            numPages.Name = "numPages";
            numPages.Size = new Size(131, 23);
            numPages.TabIndex = 6;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(304, 140);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(133, 23);
            cmbCategory.TabIndex = 7;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(128, 205);
            btnOkay.Margin = new Padding(3, 2, 3, 2);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(82, 22);
            btnOkay.TabIndex = 8;
            btnOkay.Text = "Add";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(251, 205);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(82, 22);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 11);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 10;
            label5.Text = "Add book:";
            label5.Click += label5_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 394);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnOkay);
            Controls.Add(cmbCategory);
            Controls.Add(numPages);
            Controls.Add(numYear);
            Controls.Add(txtTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddBookForm";
            Text = "AddBookForm";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPages).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtTitle;
        private NumericUpDown numYear;
        private NumericUpDown numPages;
        private ComboBox cmbCategory;
        private Button btnOkay;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
        private Label label5;
    }
}