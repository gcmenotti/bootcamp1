using bootcamp.Model;

namespace bootcamp.Interface;
public interface IRepoFactory
{
    IRepository<Libro> CreateLibroRepository();
    IRepository<Autor> CreateAutorRepository();
}

