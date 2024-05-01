namespace Domain.Enitities;

public class User
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
    public required bool IsAnonym { get; set; }

    //relationships
    public virtual ICollection<DefaultShare> DefaultShares { get; set; } = [];
    public virtual ICollection<Share> Shares { get; set; } = [];
    public virtual ICollection<Account> Accounts { get; set; } = [];
    public virtual ICollection<Budget> Budgets { get; set; } = [];
    public virtual ICollection<Budget> OwnedBudgets { get; set; } = [];
}
