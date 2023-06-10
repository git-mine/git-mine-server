using GitMine.GitInterface.Interfaces.DTOs;

namespace GitMine.GitInterface.Interfaces
{
    /// <summary>
    /// Interface for handling user accounts.
    /// </summary>
    public interface IAccounts
    {
        /// <summary>
        /// Checks if an account exists against the given ID or not.
        /// </summary>
        /// <param name="accountId">An account's ID.</param>
        /// <returns>TRUE => Account by given ID exists. FALSE => Account doesn't exist.</returns>
        bool AccountIdExists(string accountId);

        Account GetAccountById(string accountId);

        void CreateAccount(Account account, string passwordHash);
        
        void UpdateAccount(Account account);
        void UpdateAccountPassword(string accountId, string passwordHash);
        
        void DeleteAccount(string accountId);
    }
}
