using Meridian.Models;
using System.Data.Entity;

namespace Meridian.Services
{
    public class MeridianDBContext : DbContext
    {
        public DbSet<HomeDetails> HomeDetails { get; set; }
        public DbSet<Banner> Banners { get; set; }
    }
}