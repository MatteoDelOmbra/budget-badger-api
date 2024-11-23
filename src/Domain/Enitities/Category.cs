namespace Domain.Enitities;

public class Category
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }

    //relationships
    public virtual required ICollection<DefaultShare> DefaultShares { get; set; }
    public virtual required Budget Budget { get; set; }
    public virtual ICollection<Cashflow> Cashflows { get; set; } = [];
}
