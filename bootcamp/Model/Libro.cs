using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp.Model;

public class Libro
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public int AutorId { get; set; }
    public Autor Autor { get; set; }
}
