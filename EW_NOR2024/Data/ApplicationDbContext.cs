using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EW_NOR2024.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<EW_NOR2024.Models.Event> Events { get; set; } = default!;
        public DbSet<EW_NOR2024.Models.Priority> Priorities { get; set; } = default!;
    }
}
