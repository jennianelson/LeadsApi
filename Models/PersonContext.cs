using Microsoft.EntityFrameworkCore;

namespace LeadsApi.Models {
    public class PersonContext : DbContext {
        public PersonContext() { }
        public PersonContext(DbContextOptions<PersonContext> options) : base (options) { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        // }

        public DbSet<Person> Leads { get; set; }
    }
}