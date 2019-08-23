using Microsoft.EntityFrameworkCore;

namespace Animal_API.Models
{
    public class Animal_APIContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=" + EnvironmentVariables.MySQLKey + ";port=3306;database=animal_shelter;");

        public Animal_APIContext(DbContextOptions options) : base(options)
        {

        }
        public Animal_APIContext()
        {

        }
    }
}