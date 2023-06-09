using GitMine.GitInterface.Interfaces.Types;

namespace GitMine.GitInterface.Interfaces.DTOs
{
    public class Account
    {
        public string Id { get; }
        public string DisplayName { get; }
        public string Description { get; }
        public AccountType Type { get; }

        public Account(
            string id,
            string displayName,
            string description,
            AccountType accountType)
        {
            Id = id;
            DisplayName = displayName;
            Description = description;
            Type = accountType;
        }
    }
}
