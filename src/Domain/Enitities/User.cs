namespace Domain.Enitities;

public class User
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
    public required bool IsAnonym { get; set; }
}
