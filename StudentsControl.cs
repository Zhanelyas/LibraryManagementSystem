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
    public partial class StudentsControl : UserControl
    {
        public StudentsControl()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void StudentsControl_Load(object sender, EventArgs e)
        {

        }
        private void LoadStudents()
        {
            using var context = new ZhanelDbContext();

            var students = context.Students
                .Select(s => new
                {
                    s.StudentId,
                    s.Name,
                    s.Email,
                    s.NeptunCode
                })
                .ToList();

            dgvStudents.DataSource = students;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using var context = new ZhanelDbContext();

            var students = context.Students
                .Where(s => s.Name.Contains(txtSearch.Text))
                .Select(s => new
                {
                    s.StudentId,
                    s.Name,
                    s.Email,
                    s.NeptunCode
                })
                .ToList();

            dgvStudents.DataSource = students;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadStudents();
        }
    }
}
