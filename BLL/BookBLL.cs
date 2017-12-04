using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ValueObject;
using System.Data;

namespace BLL
{
    public class BookBLL
    {
        BookDAL bookDal = new BookDAL();
        public DataTable GetAll()
        {
            return bookDal.GetAll();
        }
        public DataTable GetById(int id)
        {
            return bookDal.GetById(id);
        }
        public DataTable GetBookByName(string name)
        {
            return bookDal.GetByName(name);
        }
        public int Insert(Book book)
        {
            return bookDal.Insert(book);
        }
        public int Update(Book book)
        {
            return bookDal.Update(book);
        }
        public int Delete(int bookId)
        {
            return bookDal.Delete(bookId);
        }

        public DataTable GetBookByAuthor(string input)
        {
            return bookDal.GetByAuthor(input);
        }

        public DataTable GetBookByType(string input)
        {
            return bookDal.GetByType(input);
        }
    }
}
