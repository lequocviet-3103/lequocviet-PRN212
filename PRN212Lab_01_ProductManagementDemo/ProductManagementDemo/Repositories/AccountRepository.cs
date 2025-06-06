namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountMember(string accountID) => AccountDAO.GetAccountById(accountID);

    }
}
