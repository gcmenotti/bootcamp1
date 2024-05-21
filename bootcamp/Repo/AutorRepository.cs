using bootcamp.Interface;
using bootcamp.Model;
using Microsoft.EntityFrameworkCore;

namespace bootcamp.Repo;

public class AutorRepository(DbContext context) : Repository<Autor>(context);