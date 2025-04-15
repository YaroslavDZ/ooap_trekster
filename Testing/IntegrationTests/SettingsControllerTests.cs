using Infrastructure;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using TreksterIntegrationTests.Factories;
using TreksterIntegrationTests.Helpers;

namespace TreksterIntegrationTests.Settings
{
    public class SettingsControllerTests : IClassFixture<TreksterWebAppFactory>
    {
        private readonly HttpClient _client;
        private readonly TreksterWebAppFactory _factory;

        public SettingsControllerTests(TreksterWebAppFactory factory)
        {
            _factory = factory;
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }

        [Fact]
        public async Task Index_ReturnsNotFoundToLogin_WhenUserIsNotAuthenticated()
        {
            // Act
            var response = await _client.GetAsync("/Settings");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task Accounts_ReturnsRedirect_WhenUserIsAuthenticated()
        {
            // Arrange
            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddAuthentication("Test")
                        .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(
                            "Test", options => { });

                    // Override the default authorization policy
                    services.AddAuthorization(options =>
                    {
                        options.DefaultPolicy = new Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder()
                            .AddAuthenticationSchemes("Test")
                            .RequireAuthenticatedUser()
                            .Build();
                    });
                });
            })
            .CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });

            client.DefaultRequestHeaders.Add("X-Integration-Test", "true");

            // Act
            var response = await client.GetAsync("/Settings/Accounts");

            // Assert
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }

        [Fact]
        public async Task DeleteAccount_ReturnsRedirect_WhenUserIsAuthenticated()
        {
            // Arrange
            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddAuthentication("Test")
                        .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(
                            "Test", options => { });

                    services.AddAuthorization(options =>
                    {
                        options.DefaultPolicy = new Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder()
                            .AddAuthenticationSchemes("Test")
                            .RequireAuthenticatedUser()
                            .Build();
                    });
                });
            })
            .CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });

            client.DefaultRequestHeaders.Add("X-Integration-Test", "true");

            using var scope = _factory.Services.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            var account = dbContext.Accounts.First();

            // Act
            var response = await client.GetAsync($"/Settings/DeleteAccount/{account.Id}");

            // Assert
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }
    }
}
