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
        /// <summary>
        /// Checks if an account exists against the given Unique Name or not.
        /// </summary>
        /// <param name="uniqueName">An account's Unique Name.</param>
        /// <returns>TRUE => Account exists. FALSE => Account doesn't exist.</returns>
        bool AccountUniqueNameExists(string uniqueName);

        /// <summary>
        /// Gets account details against the given ID.
        /// </summary>
        /// <param name="accountId">Specific account ID.</param>
        /// <returns><c>Account</c> object against the given ID.</returns>
        Account GetAccountById(string accountId);
        /// <summary>
        /// Gets account details against the given Unique Name.
        /// </summary>
        /// <param name="uniqueName">Specific account's Unique Name.</param>
        /// <returns><c>Account</c> object against the given Unique Name.</returns>
        Account GetAccountByUniqueName(string uniqueName);

        /// <summary>
        /// Creates an account, assigns an ID and sets its password hash as given.
        /// </summary>
        /// <param name="account">Account details object.</param>
        /// <param name="passwordHash">Password hash.</param>
        /// <returns><c>Account</c> object with assigned ID.</returns>
        Account CreateAccount(Account account, string passwordHash);
        
        /// <summary>
        /// Updates an account's details against given ID.
        /// </summary>
        /// <param name="accountId">ID for the account that needs to be updated.</param>
        /// <param name="account">Updated details.</param>
        void UpdateAccount(string accountId, Account account);
        /// <summary>
        /// Updates an account's password.
        /// </summary>
        /// <param name="accountId">ID of the account.</param>
        /// <param name="passwordHash">Updated password hash.</param>
        void UpdateAccountPassword(string accountId, string passwordHash);
        
        /// <summary>
        /// Deletes an account and its associated data.
        /// </summary>
        /// <param name="accountId">ID of the account to be deleted.</param>
        void DeleteAccount(string accountId);
    }
}
