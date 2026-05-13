using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
        public class BookDisplay
        {
            public int BookId { get; set; }

            public string Title { get; set; }

            public int CategoryId { get; set; }

            public string CategoryName { get; set; }

            public int PublicationYear { get; set; }

            public int PageCount { get; set; }
        }
   
}

