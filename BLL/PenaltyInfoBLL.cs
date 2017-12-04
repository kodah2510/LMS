using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class PenaltyInfoBLL
    {
        PenaltyInfoDAL penaltyInfoDAL = new PenaltyInfoDAL();
        public DataTable GetAll()
        {
            return penaltyInfoDAL.GetAll();
        }
        public DataTable GetByMemberId(int memberId)
        {
            return penaltyInfoDAL.GetByMemberId(memberId);
        } 
    }
}
