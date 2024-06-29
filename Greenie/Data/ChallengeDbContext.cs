using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Greenie
{
    public class ChallengeDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<Challenge> Challenges { get; set; }
        public ChallengeDbContext(DbContextOptions<ChallengeDbContext> options)
        : base(options) { }
    }
}