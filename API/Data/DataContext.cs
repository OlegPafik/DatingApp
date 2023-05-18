using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    /// <summary>
    /// Service to query and save instances of entities to the database.
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Represents table Users that have as columns the properties of AppUser.
        /// </summary>
        public DbSet<AppUser> Users { get; set; }
    }
}