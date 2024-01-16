using Duende.IdentityServer.EntityFramework.Options;
using ExpoEperts.Server.Models;
using ExpoEperts.Shared;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ExpoEperts.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Product> products { get; set; }
        public DbSet<User> NewUser { get; set; }
    }
}