using Greenie.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Greenie.Data
{
    public class ChallengeDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<ChallengeDbContext> Challenges { get; set; }
    }
}