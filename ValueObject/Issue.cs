using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Issue
    {
        public int memberId { get; set; }
        public int bookId { get; set; }
        public int amount { get; set; }
        public DateTime issueDate { get; set; }
        public DateTime dueDate { get; set; }
    }
}
