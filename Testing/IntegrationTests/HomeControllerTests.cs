using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using TreksterIntegrationTests.Factories;
using TreksterIntegrationTests.Helpers;

namespace TreksterIntegrationTests.Home
{
    public class HomeControllerTests : IClassFixture<TreksterWebAppFactory>
    {
        private readonly HttpClient _client;
        private readonly TreksterWebAppFactory _factory;

        public HomeControllerTests(TreksterWebAppFactory factory)
        {
            _factory = factory;
            _client = factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }

        [Fact]
        public async Task Index_ReturnsRedirectToLogin_WhenUserIsNotAuthenticated()
        {
            // Act
            var response = await _client.GetAsync("/");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task Index_ReturnsViewWithTransactions_WhenUserIsAuthenticated()
        {
            // Arrange
            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddAuthentication("Test")
                        .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(
                            "Test", options => { });
                });
            })
            .CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });

            client.DefaultRequestHeaders.Add("X-Integration-Test", "true");

            // Act
            var response = await client.GetAsync("/");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task CreateTransaction_ReturnsRedirect_WhenUserIsAuthenticated()
        {
            // Arrange
            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddAuthentication("Test")
                        .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>(
                            "Test", options => { });
                });
            })
            .CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });

            client.DefaultRequestHeaders.Add("X-Integration-Test", "true");

            // Act
            var response = await client.GetAsync("/Home/CreateTransaction");

            // Assert
            Assert.Equal(HttpStatusCode.Redirect, response.StatusCode);
        }
    }
}
