using Domain.Enums;

namespace Domain.Enitities;

public class Account
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required Currency Currency { get; set; }
    public required decimal Balance { get; set; }
    public required string BudgetId { get; set; }
}
