using Microsoft.EntityFrameworkCore;
using williamZZ.Models;

namespace williamZZ.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
}
