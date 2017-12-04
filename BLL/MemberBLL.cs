using DAL;
using System.Data;
using ValueObject;

namespace BLL
{
    public class MemberBLL
    {
        MemberDAL memberDal = new MemberDAL();
        public DataTable GetAll()
        {
            return memberDal.GetAll();
        }
        public DataTable GetMemberById(int id)
        {
            return memberDal.GetMemberById(id);
        }
        public DataTable GetMemberByUsername(string username)
        {
            return memberDal.GetMemberByUsername(username);
        }

        public DataTable GetMember(string username, string password)
        {
            return memberDal.GetMember(username, password);
        }

        public int Insert(Member member)
        {
            return memberDal.Insert(member);
        }
        public int Update(Member member)
        {
            return memberDal.Update(member);
        }
        public int Delete(int memberId)
        {
            return memberDal.Delete(memberId);
        }
    }
}
