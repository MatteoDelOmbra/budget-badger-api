using Domain.Enums;

namespace Domain.Enitities;

public class Share
{
    public required string Id { get; set; }
    public required string Percentage { get; set; }
    public required int Debt { get; set; }

    //relationships
    public virtual required User User { get; set; }
    public virtual required Cashflow Cashflow { get; set; }
}
