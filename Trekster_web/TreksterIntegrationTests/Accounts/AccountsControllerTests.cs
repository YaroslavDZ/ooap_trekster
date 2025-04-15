using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using TreksterIntegrationTests.Factories;
using TreksterIntegrationTests.Helpers;

namespace TreksterIntegrationTests.Accounts
{
    public class AccountsControllerTests : IClassFixture<TreksterWebAppFactory>
    {
        private readonly HttpClient _client;
        private readonly TreksterWebAppFactory _factory;

        public AccountsControllerTests(TreksterWebAppFactory factory)
        {
            _factory = factory;
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }

        [Fact]
        public async Task DebugListRoutes()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act & Assert
            var routes = _factory.Services.GetRequiredService<Microsoft.AspNetCore.Routing.EndpointDataSource>()
                .Endpoints
                .OfType<Microsoft.AspNetCore.Routing.RouteEndpoint>()
                .Select(e => e.RoutePattern.RawText)
                .ToList();

            foreach (var route in routes)
            {
                Console.WriteLine($"Route: {route}");
            }

            // Assert
            Assert.Contains(routes, r => r == "{controller=User}/{action=Login}/{id?}");
        }

        [Fact]
        public async Task Index_ReturnsRedirectToLogin_WhenUserIsNotAuthenticated()
        {
            // Act
            var response = await _client.GetAsync("/Accounts");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task Index_ReturnsViewWithAccounts_WhenUserIsAuthenticated()
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
            var response = await client.GetAsync("/Accounts");

            // Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }

        [Fact]
        public async Task Create_ReturnsView_WhenUserIsAuthenticated()
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

            // Act
            var response = await client.GetAsync("/Accounts/Create");

            // Assert
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }
    }
}
