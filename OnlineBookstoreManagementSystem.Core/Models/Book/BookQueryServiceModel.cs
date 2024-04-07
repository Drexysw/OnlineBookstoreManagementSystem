using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstoreManagementSystem.Core.Models.Book
{
    public class BookQueryServiceModel
    {
        public int TotalBooksCount { get; set; }

        public IEnumerable<BooksAllServiceModel> Books { get; set; }
        = new List<BooksAllServiceModel>();
    }
}
