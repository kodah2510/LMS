using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Location
    {
        public int id { get; set; }
        public int row { get; set; }
        public int col { get; set; }
        public int shelf { get; set; }
        public int section { get; set; }
        public Location(int id, int row, int col, int shelf, int section)
        {
            this.id = id;
            this.row = row;
            this.col = col;
            this.shelf = shelf;
            this.section = section;
        }
    }
}
