using Microsoft.EntityFrameworkCore;
using OzdamarDepoAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzdamarDepoAPI.Persistence.Contexts
{
    public class OzdamarDepoAPIDbContext : DbContext
    {
        public OzdamarDepoAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ArtistOrActor> ArtistOrActors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CDOrDVD> CDOrDVDs { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
