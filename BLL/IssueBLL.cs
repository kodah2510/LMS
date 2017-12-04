using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;
using DAL;
using System.Data;

namespace BLL
{
    public class IssueBLL
    {
        IssueDAL issueDal = new IssueDAL();
        public DataTable GetAll()
        {
            return issueDal.GetAll();
        }
        public DataTable GetByMemberId(int memberId)
        {
            return issueDal.GetByMemberId(memberId);
        }
        public DataTable GetByBookId(int bookId)
        {
            return issueDal.GetByBookId(bookId);
        }
        public DataTable SearchForBook(string name)
        {
            return issueDal.SearchForBook(name);
        }
        public DataTable SearchForMember(string name)
        {
            return issueDal.SearchForMember(name);
        }
        public int Insert(Issue issue)
        {
            return issueDal.Insert(issue);
        }
        public int Delete(int memberId)
        {
            return issueDal.Delete(memberId);
        }
    }
}
