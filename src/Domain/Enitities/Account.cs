using Domain.Enums;

namespace Domain.Enitities;

public class Account
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required Currency Currency { get; set; }
    public decimal Balance { get; set; }

    //relationships
    public virtual required ICollection<User> Owners { get; set; }
    public virtual Budget? Budget { get; set; }
    public virtual ICollection<Transaction> Transactions { get; set; } = [];
}
