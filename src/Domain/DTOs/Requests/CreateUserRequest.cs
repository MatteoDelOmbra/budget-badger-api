namespace Domain.DTOs.Requests;

public class CreateUserRequest
{
    public required string Name { get; set; }
    public required string HashedPassword { get; set; }
    public required string Email { get; set; }
}
