using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public string type { get; set; }
        public int amount { get; set; }
        public int cost { get; set; }
        public Book() { }
        public Book(int id, string name, string author, string type, int amount, int cost)
        {
            this.id = id;
            this.name = name;
            this.author = author;
            this.type = type;
            this.amount = amount;
            this.cost = cost;
        }
        public Book(string name, string author, string type, int amount, int cost)
        {
            this.name = name;
            this.author = author;
            this.type = type;
            this.amount = amount;
            this.cost = cost;
        }

    }
}
