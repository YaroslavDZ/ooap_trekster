using BusinessLogic.Services.ServiceImplementation;
using BusinessLogic.Services.ServiceInterfaces;
using Infrastructure;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Trekster_web;
using Trekster_web.ControllerServices.Implementation;
using Trekster_web.ControllerServices.Interfaces;
using Program = Trekster_web.Program;

namespace TreksterIntegrationTests.Factories
{
    public class TreksterWebAppFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(DbContextOptions<AppDbContext>));

                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }

                services.AddDbContext<AppDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryTreksterDb");
                });

                // Ensure controllers are registered
                services.AddMvc()
                    .AddApplicationPart(typeof(Trekster_web.Controllers.AccountsController).Assembly);
                services.AddMvc()
                    .AddApplicationPart(typeof(Trekster_web.Controllers.ExpensesController).Assembly);
                services.AddMvc()
                    .AddApplicationPart(typeof(Trekster_web.Controllers.HistoryController).Assembly);
                services.AddMvc()
                    .AddApplicationPart(typeof(Trekster_web.Controllers.HomeController).Assembly);
                services.AddMvc()
                    .AddApplicationPart(typeof(Trekster_web.Controllers.ProfitsController).Assembly);
                services.AddMvc()
                    .AddApplicationPart(typeof(Trekster_web.Controllers.SettingsController).Assembly);
                services.AddMvc()
                    .AddApplicationPart(typeof(Trekster_web.Controllers.UserController).Assembly);

                // Register all the services needed by the controllers
                services.AddAutoMapper(typeof(Trekster_web.Mapping.AccountVMProfile).Assembly);
                services.AddScoped<ICurrencyService, CurrencyService>();
                services.AddScoped<IAccountControllerService, AccountControllerService>();
                services.AddScoped<IExpensesControllerService, ExpensesControllerService>();
                services.AddScoped<IHistoryControllerService, HistoryControllerService>();
                services.AddScoped<IHomeControllerService, HomeControllerService>();
                services.AddScoped<IProfitsControllerService, ProfitsControllerService>();

                var sp = services.BuildServiceProvider();

                using var scope = sp.CreateScope();
                var scopedServices = scope.ServiceProvider;
                var db = scopedServices.GetRequiredService<AppDbContext>();
                var userManager = scopedServices.GetRequiredService<UserManager<User>>();

                db.Database.EnsureCreated();
                SeedTestData(db, userManager).Wait();
            });
        }

        private async Task SeedTestData(AppDbContext dbContext, UserManager<User> userManager)
        {
            if (!dbContext.Users.Any())
            {
                var testUser = new User
                {
                    UserName = "testuser@example.com",
                    Email = "testuser@example.com",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(testUser, "Test@123");

                // Create test data
                var account = new Account
                {
                    Name = "Test Account",
                    UserId = testUser.Id
                };
                dbContext.Accounts.Add(account);

                var currency = new Currency { Name = "USD" };
                dbContext.Currencies.Add(currency);

                var category = new Category { Name = "Test Category", Type = 1 };
                dbContext.Categories.Add(category);

                await dbContext.SaveChangesAsync();

                var startBalance = new StartBalance
                {
                    Sum = 1000,
                    AccountId = account.Id,
                    CurrencyId = currency.Id
                };
                dbContext.StartBalances.Add(startBalance);

                var transaction = new Transaction
                {
                    Date = DateTime.Now,
                    Sum = 100,
                    AccountId = account.Id,
                    CurrencyId = currency.Id,
                    CategoryId = category.Id
                };
                dbContext.Transactions.Add(transaction);

                await dbContext.SaveChangesAsync();
            }
        }
    }
}
