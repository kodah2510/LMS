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
    public class PersonalInfoDAL
    {
        dbConnect db = new dbConnect();


        public DataTable GetById(int id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", id)
            };
            return db.GetData("sp_PersonalInfo_SelectById", parameters);
        }
        public int Insert(PersonalInfo personalInfo)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", personalInfo.id),
                new SqlParameter("fullname", personalInfo.fullname),
                new SqlParameter("age", personalInfo.age),
                new SqlParameter("occupation", personalInfo.occupation)
            };
            return db.ExecuteSql("sp_PersonalInfo_Insert", parameters);
        }
        public int Update(PersonalInfo personalInfo)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", personalInfo.id),
                new SqlParameter("fullname", personalInfo.fullname),
                new SqlParameter("age", personalInfo.age),
                new SqlParameter("occupation", personalInfo.occupation)
            };
            return db.ExecuteSql("sp_PersonalInfo_Update", parameters);
        }
        public int Delete(int id)
        {
            SqlParameter[] parameters =
           {
                new SqlParameter("memberId", id),
            };
            return db.ExecuteSql("sp_PersonalInfo_Delete", parameters);
        }
    }
}
