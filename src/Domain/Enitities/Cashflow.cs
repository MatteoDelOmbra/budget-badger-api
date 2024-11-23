namespace Domain.Enitities;

public class Cashflow
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int Value { get; set; }

    //relationships
    public virtual required Category Category { get; set; }
    public virtual required Transaction Transaction { get; set; }
    public virtual required ICollection<Share> Shares { get; set; }
}
