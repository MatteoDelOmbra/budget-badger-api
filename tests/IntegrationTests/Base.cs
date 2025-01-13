using Application.Interfaces;
using Domain.Enitities;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace IntegrationTests;

public abstract class Base : IClassFixture<WebApplicationFactory<Program>>
{
    protected readonly HttpClient _client;
    public Base(WebApplicationFactory<Program> factory)
    {

        var mockDbContext = new Mock<IAppDbContext>();
        var mockDbSet = new Mock<DbSet<User>>();
        _ = mockDbContext.Setup(db => db.Users).Returns(mockDbSet.Object);

        _client = factory.WithWebHostBuilder(builder =>
        {
            _ = builder.ConfigureTestServices(services =>
            {
                _ = services.AddSingleton(mockDbContext.Object);
            });
        }).CreateClient();
    }
}