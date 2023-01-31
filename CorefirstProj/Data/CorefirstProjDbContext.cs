using CorefirstProj.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CorefirstProj.Data
{
    public class CorefirstProjDbContext:DbContext
    {
        public CorefirstProjDbContext(DbContextOptions<CorefirstProjDbContext> options) : base(options)
            {
            }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }
    public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    
    }
}
