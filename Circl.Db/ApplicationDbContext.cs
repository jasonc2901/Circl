using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Circl.Db;

public class ApplicationDbContext : IdentityDbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<TestDbModel> TestModels { get; set; }
    
    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        // commit changes to the db
        await base.SaveChangesAsync(cancellationToken);
    }
}