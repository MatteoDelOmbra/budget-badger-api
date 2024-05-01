namespace Domain.Enitities;

public class DefaultShare
{
    public required string Id { get; set; }
    public required int Percentage { get; set; }

    //relationships
    public virtual required User User { get; set; }
    public virtual required Category Category { get; set; }
}
