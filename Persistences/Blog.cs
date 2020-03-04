using Microsoft.EntityFrameworkCore;
using web_api_testing.Models;

namespace web_api_testing.Persistence
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
        }

        public DbSet<Feed> Feeds { get; set; }
    }
}