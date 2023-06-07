using GitMine.GitInterface.Interfaces.Types;

namespace GitMine.GitInterface.Interfaces.DTOs
{
    public class Account
    {
        public string AccountId { get; }
        public string AccountName { get; }
        public AccountType AccountType { get; }

        public Account(
            string id,
            string name,
            AccountType accountType)
        {
            AccountId = id;
            AccountName = name;
            AccountType = accountType;
        }
    }
}
