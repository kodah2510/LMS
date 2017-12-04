using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PenaltyInfoDAL
    {
        dbConnect db = new dbConnect();
        public DataTable GetAll()
        {
            return db.GetData("sp_PenaltyInfo_SelectAll");
        }
        public DataTable GetByMemberId(int memberId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("memberId", memberId)
            };
            return db.GetData("sp_PenaltyInfo_SelectById", parameters);
        }
    }
}
