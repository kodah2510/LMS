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
    public class LocationDAL
    {
        dbConnect db = new dbConnect();
        public DataTable GetById(int id)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", id)
            };
            return db.GetData("sp_Location_SelectById",parameters);
        }
        public int Insert(Location location)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", location.id),
                new SqlParameter("row", location.row),
                new SqlParameter("col", location.col),
                new SqlParameter("shelf", location.shelf),
                new SqlParameter("section", location.section)
            };
            return db.ExecuteSql("sp_Location_Insert", parameters);
        }
        public int Update(Location location)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", location.id),
                new SqlParameter("row", location.row),
                new SqlParameter("col", location.col),
                new SqlParameter("shelf", location.shelf),
                new SqlParameter("section", location.section)
            };
            return db.ExecuteSql("sp_Location_Update", parameters);
        }
        public int Delete(int bookId)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", bookId)
            };
            return db.ExecuteSql("sp_Location_Delete", parameters);
        }
    }
}
