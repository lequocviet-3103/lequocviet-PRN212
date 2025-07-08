using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountID)
        {
            using var context = new MyStoreContext();
            return context.AccountMembers.FirstOrDefault(a => a.MemberId.Equals(accountID));
        }

        
    }
}
