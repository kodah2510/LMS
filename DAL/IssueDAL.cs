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
    public class IssueDAL
    {
        dbConnect db = new dbConnect();
        public DataTable GetAll()
        {
            return db.GetData("sp_Issue_SelectAll");
        }
        public DataTable GetByMemberId(int memberId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("memberId", memberId)
            };
            return db.GetData("sp_Issue_SelectByMemberId", parameters);
        }
        public DataTable GetByBookId(int bookId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("bookId", bookId)
            };
            return db.GetData("sp_Issue_SelectByBookId", parameters);
        }
        public DataTable SearchForBook(string name)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("bookName", name)
            };
            return db.GetData("sp_Issue_SearchByBook", parameters);
        }
        public DataTable SearchForMember(string name)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("memberName", name)
            };
            return db.GetData("sp_Issue_SearchByMember", parameters);
        }

        public int Insert(Issue issue)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("memberId", issue.memberId),
                new SqlParameter("bookId", issue.bookId),
                new SqlParameter("amount", issue.amount),
                new SqlParameter("issueDate", issue.issueDate),
                new SqlParameter("dueDate", issue.dueDate)
            };
            return db.ExecuteSql("sp_Issue_Insert", parameters);
        }
        //public int Update(Issue issue)
        //{
        //    SqlParameter[] parameters =
        //    {
        //        new SqlParameter("memberId", issue.memberId),
        //        new SqlParameter("bookId", issue.bookId),
        //        new SqlParameter("issueDate", issue.issueDate),
        //        new SqlParameter("dueDate", issue.dueDate)
        //    };
        //    return db.ExecuteSql("sp_Issue_Update", parameters);
        //}
        public int Delete(int memberId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("memberId", memberId)
            };
            return db.ExecuteSql("sp_Issue_Delete", parameters);
        }
    }
}
