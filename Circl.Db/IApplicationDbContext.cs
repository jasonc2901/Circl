using Microsoft.EntityFrameworkCore;

namespace Circl.Db;

public interface IApplicationDbContext
{
    DbSet<TestDbModel> TestModels { get; set; }

    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}