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
    public class LocationBLL
    {
        LocationDAL locationDal = new LocationDAL();
        public DataTable GetById(int id)
        {
            return locationDal.GetById(id);
        }
        public int Insert(Location location)
        {
            return locationDal.Insert(location);
        }
        public int Update(Location location)
        {
            return locationDal.Update(location);
        }
        public int Delete(int location)
        {
            return locationDal.Delete(location);
        }

    }
}
