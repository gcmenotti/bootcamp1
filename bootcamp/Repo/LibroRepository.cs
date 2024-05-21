using bootcamp.Interface;
using bootcamp.Model;
using Microsoft.EntityFrameworkCore;

namespace bootcamp.Repo;

public class LibroRepository(DbContext context) : Repository<Libro>(context);