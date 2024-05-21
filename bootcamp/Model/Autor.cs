using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp.Model;
public class Autor
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public List<Libro> Libros { get; set; }
}
