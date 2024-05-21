using bootcamp.Model;
using bootcamp.Repo;
using Microsoft.EntityFrameworkCore;

namespace bootcamp.Interface;

public class RepoFactory(DbContext context) : IRepoFactory
{
    public IRepository<Libro> CreateLibroRepository()
    {
        return new LibroRepository(context);
    }
    public IRepository<Autor> CreateAutorRepository()
    {
        return new AutorRepository(context);
    }
}