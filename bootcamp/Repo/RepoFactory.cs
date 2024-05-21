using bootcamp.Interface;
using bootcamp.Model;
using Microsoft.EntityFrameworkCore;

namespace bootcamp.Repo;

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