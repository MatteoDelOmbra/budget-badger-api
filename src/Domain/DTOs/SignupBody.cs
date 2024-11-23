namespace Domain.DTOs;

public class SignupBody
{
    public required string Name { get; set; }
    public required string HashedPassword { get; set; }
    public required string Email { get; set; }
}
