using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLLesson2.Model
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public DateTime Date { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return Title;
        }

    }
}
