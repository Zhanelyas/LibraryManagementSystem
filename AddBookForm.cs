using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            LoadCategories();
            ValidateInput();
        }
        private void LoadCategories()
        {
            using var context = new ZhanelDbContext();

            cmbCategory.DataSource = context.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //validation:
        private bool ValidateInput()
        {
            bool valid = true;

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Title required");
                valid = false;
            }

            Regex regex = new Regex(@"^[A-Za-z0-9\s]+$");

            if (!regex.IsMatch(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Invalid characters");
                valid = false;
            }

            btnOkay.Enabled = valid;

            return valid;
        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            ValidateInput();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            using var context = new ZhanelDbContext();

            Book book = new Book()
            {
                Title = txtTitle.Text,
                PublicationYear = (int)numYear.Value,
                PageCount = (int)numPages.Value,
                CategoryId = (int)cmbCategory.SelectedValue
            };

            context.Books.Add(book);
            context.SaveChanges();

            MessageBox.Show("Book added!");

            DialogResult = DialogResult.OK;
            Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
