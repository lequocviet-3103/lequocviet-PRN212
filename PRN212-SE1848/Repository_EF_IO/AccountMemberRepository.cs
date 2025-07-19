using BusinessObjects_EF_IO;
using DataAccessLayer_EF_IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_EF_IO
{
    public class AccountMemberRepository : IAccountMemberRepository
    {
        private readonly AccountMemberDAO memberDAO = new AccountMemberDAO();

        public AccountMember Login(string email, string password)
        {
            return memberDAO.Login(email, password);
        }
    }
}
