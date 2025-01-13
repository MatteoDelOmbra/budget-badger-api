using System.Text;
using Domain.DTOs.Requests;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace IntegrationTests;

public class EndpointTests(WebApplicationFactory<Program> factory) : Base(factory)
{
    [Fact]
    public async Task TestTestAsync()
    {
        // Arrange
        var request = new CreateUserRequest()
        {
            Name = "Foos",
            HashedPassword = "passs",
            Email = "foado@bar.com"
        };
        var payload = JsonConvert.SerializeObject(request);
        var content = new StringContent(payload, Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/User/create", content);

        // Assert
        _ = response.EnsureSuccessStatusCode();
    }
}