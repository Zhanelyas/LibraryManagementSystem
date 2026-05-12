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
    }
}
