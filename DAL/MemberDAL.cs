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
    public class MemberDAL
    {
        dbConnect db = new dbConnect();
        public DataTable GetAll()
        {
            return db.GetData("sp_Member_SelectAll");
        }
        public DataTable GetMemberById(int id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", id)
            };
            return db.GetData("sp_Member_SelectById", parameters);
        }
        public DataTable GetMemberByUsername(string username)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("username", username)
            };
            return db.GetData("sp_Member_SelectByUsername", parameters);
        }
        public DataTable GetMember(string username, string password)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("username", username),
                new SqlParameter("password", password)
            };
            return db.GetData("sp_Member_SelectByUsernameAndPassword", parameters);
        }
        public int Insert(Member member)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("username", member.username),
                new SqlParameter("password", member.password),
                new SqlParameter("email", member.email),
                new SqlParameter("type", member.isAdmin)
            };
            return db.ExecuteSql("sp_Member_Insert", parameters);
        }
        public int Update(Member member)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", member.id),
                new SqlParameter("username", member.username),
                new SqlParameter("password", member.password),
                new SqlParameter("email", member.email),
                new SqlParameter("type", member.isAdmin),

            };
            return db.ExecuteSql("sp_Member_Update", parameters);
        }
        public int Delete(int memberId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", memberId),
            };
            return db.ExecuteSql("sp_Member_Delete", parameters);
        }
        
    }
}
