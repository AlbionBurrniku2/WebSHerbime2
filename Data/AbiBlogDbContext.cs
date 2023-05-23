using AbiBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace AbiBlog.Data
{
    public class AbiBlogDbContext: DbContext
    {
       
            public AbiBlogDbContext(DbContextOptions options) : base(options)
            { }

            public DbSet<Author> Authors { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<Image> Images { get; set; }

        }
    }

