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

namespace LibraryManagementSystem
{
    public partial class BorrowControl : UserControl
    {
        public BorrowControl()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using var context = new ZhanelDbContext();

            cmbStudents.DataSource = context.Students.ToList();
            cmbStudents.DisplayMember = "Name";
            cmbStudents.ValueMember = "StudentId";

            cmbBooks.DataSource = context.Books.ToList();
            cmbBooks.DisplayMember = "Title";
            cmbBooks.ValueMember = "BookId";

            var borrows = context.Borrows
                .Select(b => new
                {
                    b.BorrowId,
                    Student = b.Student.Name,
                    Book = b.Book.Title,
                    b.BorrowDate,
                    b.ReturnDate
                })
                .ToList();

            dgvBorrows.DataSource = borrows;
        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            using var context = new ZhanelDbContext();

            Borrow borrow = new Borrow()
            {
                StudentId = (int)cmbStudents.SelectedValue,
                BookId = (int)cmbBooks.SelectedValue,
                BorrowDate = DateOnly.FromDateTime(dtpBorrowDate.Value),
                ReturnDate = null
            };

            context.Borrows.Add(borrow);
            context.SaveChanges();

            MessageBox.Show("Borrow record added!");
            LoadData();
        }
    }

}