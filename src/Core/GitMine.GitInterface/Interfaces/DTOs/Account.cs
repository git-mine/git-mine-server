using GitMine.GitInterface.Interfaces.Types;

namespace GitMine.GitInterface.Interfaces.DTOs
{
    public class Account
    {
        /// <summary>
        /// A unique ID is assigned by the system upon account creation.
        /// Once the account is created, the ID cannot be changed.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Name that is unique amongst different users.
        /// </summary>
        public string UniqueName { get; }
        /// <summary>
        /// Any name that the user wants to use on profile.
        /// </summary>
        public string DisplayName { get; }
        /// <summary>
        /// Details provided by the user to display on profile.
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Type of the account.
        /// </summary>
        public AccountType Type { get; }

        public Account(
            string id,
            string uniqueName,
            string displayName,
            string description,
            AccountType accountType)
        {
            Id = id;
            UniqueName = uniqueName;
            DisplayName = displayName;
            Description = description;
            Type = accountType;
        }
    }
}
