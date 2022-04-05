using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLLesson2.Model
{
    class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Organization { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
