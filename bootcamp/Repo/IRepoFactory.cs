using bootcamp.Interface;
using bootcamp.Model;
namespace bootcamp.Repo;
public interface IRepoFactory
{
    IRepository<Libro> CreateLibroRepository();
    IRepository<Autor> CreateAutorRepository();
}

