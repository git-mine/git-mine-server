using GitMine.GitInterface.Interfaces.DTOs;

namespace GitMine.GitInterface.Interfaces
{
    public interface IAccounts
    {
        bool AccountIdExists(string accountId);

        Account GetAccountById(string accountId);

        void CreateAccount(Account account, string passwordHash);
        
        void UpdateAccount(Account account);
        void UpdateAccountPassword(string accountId, string passwordHash);
        
        void DeleteAccount(string accountId);
    }
}
