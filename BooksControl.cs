using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LibraryManagementSystem
{
    public partial class BooksControl : UserControl
    {
        public BooksControl()
        {
            InitializeComponent();
        }

        private void BooksControl_Load(object sender, EventArgs e)
        {
            LoadBooks();

        }

        private void LoadBooks()
        {
            using var context = new ZhanelDbContext();

            var books = context.Books
                .Select(b => new BookDisplay
                {
                    BookId = b.BookId,
                    Title = b.Title,
                    CategoryId = b.CategoryId,
                    CategoryName = b.Category.CategoryName,
                    PublicationYear = b.PublicationYear,
                    PageCount = b.PageCount
                })
                .ToList();

            bindingSourceBooks.DataSource = books;

            dgvBooks.DataSource = bindingSourceBooks;

            cmbBookCategory.DataSource = context.Categories.ToList();
            cmbBookCategory.DisplayMember = "CategoryName";
            cmbBookCategory.ValueMember = "CategoryId";

            txtBookTitle.DataBindings.Clear();
            numBookYear.DataBindings.Clear();
            numBookPages.DataBindings.Clear();
            cmbBookCategory.DataBindings.Clear();

            txtBookTitle.DataBindings.Add("Text", bindingSourceBooks, "Title");
            numBookYear.DataBindings.Add("Value", bindingSourceBooks, "PublicationYear");
            numBookPages.DataBindings.Add("Value", bindingSourceBooks, "PageCount");
            cmbBookCategory.DataBindings.Add("SelectedValue", bindingSourceBooks, "CategoryId");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using var context = new ZhanelDbContext();

            var books = context.Books
                .Where(b => b.Title.Contains(txtSearch.Text))
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    Category = b.Category.CategoryName,
                    b.PublicationYear,
                    b.PageCount
                })
                .ToList();

            dgvBooks.DataSource = books;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadBooks();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm form = new AddBookForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
                return;

            int bookId = Convert.ToInt32(
                dgvBooks.CurrentRow.Cells["BookId"].Value);

            var result = MessageBox.Show(
                "Delete this book?",
                "Confirm deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            using var context = new ZhanelDbContext();

            var book = context.Books.Find(bookId);

            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();

                MessageBox.Show("Book deleted");

                LoadBooks();
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "CSV files (*.csv)|*.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using StreamWriter sw = new StreamWriter(sfd.FileName);

                sw.WriteLine("BookId,Title,Category,PublicationYear,PageCount");

                foreach (DataGridViewRow row in dgvBooks.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        sw.WriteLine(
                            $"{row.Cells[0].Value}," +
                            $"{row.Cells[1].Value}," +
                            $"{row.Cells[2].Value}," +
                            $"{row.Cells[3].Value}," +
                            $"{row.Cells[4].Value}");
                    }
                }

                MessageBox.Show("CSV exported!");
            }
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImportCsv_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "CSV files (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName);

                using var context = new ZhanelDbContext();

                foreach (string line in lines.Skip(1))
                {
                    string[] parts = line.Split(',');

                    Book book = new Book()
                    {
                        Title = parts[1],
                        CategoryId = int.Parse(parts[2]),
                        PublicationYear = int.Parse(parts[3]),
                        PageCount = int.Parse(parts[4])
                    };

                    context.Books.Add(book);
                }

                context.SaveChanges();

                MessageBox.Show("CSV imported!");

                LoadBooks();
            }
        }
    }
}
