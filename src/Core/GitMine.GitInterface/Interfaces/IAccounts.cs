using GitMine.GitInterface.Interfaces.DTOs;

namespace GitMine.GitInterface.Interfaces
{
    public interface IAccounts
    {
        Account GetAccountById(string accountId);
        Account CreateAccount(Account account);
        void UpdateAccount(Account account);
        void DeleteAccount(Account account);
    }
}
