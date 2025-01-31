using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagement.Models;

namespace UserManagement.Infrastructure;
internal class UserManagementDbContext : IdentityDbContext<User>
{
    public UserManagementDbContext(DbContextOptions<UserManagementDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>();
        builder.HasDefaultSchema("identity");
    }
}
