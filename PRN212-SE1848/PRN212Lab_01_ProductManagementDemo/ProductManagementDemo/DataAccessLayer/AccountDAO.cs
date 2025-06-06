using BusinessObjects;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(String accountId)
        {
            AccountMember
                accountMember = new AccountMember();
            if (accountId.Equals("PS0001"))
            {
                accountMember.MemberID = accountId;
                accountMember.MemberPassword = "@1";
                accountMember.MemberRole = 1;
            }
            return accountMember;
        }
    }
}
