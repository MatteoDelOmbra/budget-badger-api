namespace Domain.DTOs;

public class CreateUserBody
{
    public required string Name { get; set; }
    public required string HashedPassword { get; set; }
    public required string Email { get; set; }
}
