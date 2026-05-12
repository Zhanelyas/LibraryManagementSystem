using System;
using System.Collections.Generic;

namespace LibraryManagementSystem.Models;

public partial class Borrow
{
    public int BorrowId { get; set; }

    public int StudentId { get; set; }

    public int BookId { get; set; }

    public DateOnly BorrowDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
