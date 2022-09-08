using ApiLoginFlutter.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiLoginFlutter.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
    }
}
