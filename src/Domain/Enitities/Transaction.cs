using Domain.Enums;

namespace Domain.Enitities;

public class Transaction
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required TransactionType Type { get; set; }
    public required decimal Value { get; set; }
    public required DateTime Date { get; set; }
    public required string AccountId { get; set; }
}
