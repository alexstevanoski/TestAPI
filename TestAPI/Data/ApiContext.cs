using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public ApiContext(DbContextOptions<ApiContext> options)
        : base (options)
        {

        }
    }
}