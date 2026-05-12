namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnBooks_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            BooksControl booksControl = new BooksControl();
            booksControl.Dock = DockStyle.Fill;

            panelMain.Controls.Add(booksControl);
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            StudentsControl studentsControl = new StudentsControl();
            studentsControl.Dock = DockStyle.Fill;

            panelMain.Controls.Add(studentsControl);
        }
        private void btnBorrows_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            BorrowControl borrowControl = new BorrowControl();
            borrowControl.Dock = DockStyle.Fill;

            panelMain.Controls.Add(borrowControl);
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
