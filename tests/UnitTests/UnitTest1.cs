using Application.Commands;
using Application.Interfaces;
using Moq;
using Xunit;

namespace UnitTests;

public class UnitTest1
{
    [Fact]
    public async void CreateUserTest()
    {
        var ctx = new Mock<IAppDbContext>();
        var commandHandler = new CreateUserCommandHandler(ctx.Object);

        var command = new CreateUserCommand(
            new Domain.DTOs.Requests.CreateUserRequest()
            {
                Name = "",
                HashedPassword = "",
                Email = "",
            }
        );

        var result = await commandHandler.Handle(command, CancellationToken.None);
        Assert.Equal(System.Net.HttpStatusCode.BadRequest, result.StatusCode);
    }
}
