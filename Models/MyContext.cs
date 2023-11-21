#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
namespace Tarea_Primera_Conexión_BD.Models;

public class MyContext : DbContext
{ 
    // This line will always be here. It is what constructs our context upon initialization  
    public MyContext(DbContextOptions options) : base(options) { }    
    // We need to create a new DbSet<Model> for every model in our project that is making a table
    // The name of our table in our database will be based on the name we provide here
    // This is where we provide a plural version of our model to fit table naming standards    
    public DbSet<Mascota> Mascotas { get; set; }

    /*protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mascota>()
            .Property(m => m.Nombre)
            .HasMaxLength(250)
            .IsRequired();

        modelBuilder.Entity<Mascota>()
            .Property(m => m.TipoMascota)
            .HasMaxLength(3)
            .IsRequired();

        modelBuilder.Entity<Mascota>()
            .Property(m => m.Edad)
            .HasDefaultValue(0);

        modelBuilder.Entity<Mascota>()
            .Property(m => m.TienePelo)
            .HasDefaultValue(false);
    }*/
}