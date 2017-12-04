using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
namespace DAL
{
    public class BookDAL
    {
        dbConnect db = new dbConnect();
        public DataTable GetAll()
        {
            return db.GetData("sp_Book_Select", null);
        }
        public DataTable GetByName(string name)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("name", name)
            };
            return db.GetData("sp_Book_SelectByName", parameters);
        }
        public DataTable GetById(int id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("bookId", id)
            };
            return db.GetData("sp_Book_SelectById", parameters);
        }
        public int Insert(Book book)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("name", book.name),
                new SqlParameter("author", book.author),
                new SqlParameter("type", book.type),
                new SqlParameter("amount", book.amount),
                new SqlParameter("cost", book.cost)
            };
            return db.ExecuteSql("sp_Book_Insert", parameters);
        }

        public DataTable GetByAuthor(string input)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("author", input)
            };
            return db.GetData("sp_Book_SelectByAuthor", parameters);
        }

        public DataTable GetByType(string input)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("type", input)
            };
            return db.GetData("sp_Book_SelectByType", parameters);
        }
        public int Update(Book book)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", book.id),
                new SqlParameter("name", book.name),
                new SqlParameter("author", book.author),
                new SqlParameter("type", book.type),
                new SqlParameter("amount", book.amount),
                new SqlParameter("cost", book.cost)
            };
            return db.ExecuteSql("sp_Book_Update", parameters);
        }
        public int Delete(int bookId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", bookId)
            };
            return db.ExecuteSql("sp_Book_Delete", parameters);
        }
    }
}
