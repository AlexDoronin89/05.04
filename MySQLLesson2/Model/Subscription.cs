using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLLesson2.Model
{
    class Subscription
    {
        public int Id { get; set; }
        public int ReaderId { get; set; }
        public string ReaderName { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public DateTime TakingDate { get; set; }
        public DateTime BringDate { get; set; }
        public bool IsReturn { get; set; }
    }
}
