using bootcamp.Model;
using Microsoft.EntityFrameworkCore;

namespace bootcamp.Factory;

public class SqlServer(DbContextOptions<SqlServer> options) : DbContext(options)
{
    public DbSet<Libro> Libros { get; set; }
    public DbSet<Autor> Autores { get; set; }
}