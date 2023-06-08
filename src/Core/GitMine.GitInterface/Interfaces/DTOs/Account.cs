using GitMine.GitInterface.Interfaces.Types;

namespace GitMine.GitInterface.Interfaces.DTOs
{
    public class Account
    {
        public string Id { get; }
        public string Name { get; }
        public AccountType Type { get; }

        public Account(
            string id,
            string name,
            AccountType accountType)
        {
            Id = id;
            Name = name;
            Type = accountType;
        }
    }
}
