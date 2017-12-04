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
    public class PersonalInfoBLL
    {
        PersonalInfoDAL personalInfoDal = new PersonalInfoDAL();
        public DataTable GetById(int id)
        {
            return personalInfoDal.GetById(id);
        }
        public int Insert(PersonalInfo personalInfo)
        {
            return personalInfoDal.Insert(personalInfo);
        }
        public int Update(PersonalInfo personalInfo)
        {
            return personalInfoDal.Update(personalInfo);
        }
        public int Delete(int id)
        {
            return personalInfoDal.Delete(id);
        }
    }
}
