using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Enitities;

public class Budget
{
    public required string Id { get; set; }
    public required string Name { get; set; }

    //relationships
    public virtual required User Owner { get; set; }
    public virtual required ICollection<User> Users { get; set; }
    public virtual ICollection<Category> Categories { get; set; } = [];
    public virtual ICollection<Account> Accounts { get; set; } = [];
    public virtual ICollection<Transaction> Transactions { get; set; } = [];
}
