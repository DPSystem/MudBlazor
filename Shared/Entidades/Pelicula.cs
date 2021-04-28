using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazor.Shared.Entidades
{
  public class Pelicula
  {
    public int Id { get; set; }
    [Required]
    public string Titulo { get; set; }
    [Required]
    public DateTime? Lanzamiento { get; set; }
    public string Poster { get; set; }
    public List<GeneroPelicula> GeneroPelicula { get; set; } = new List<GeneroPelicula>();
    public List<PeliculaActor> PeliculasActor { get; set; }
    public string TituloCortado
    {
      get
      {
        if (string.IsNullOrWhiteSpace(Titulo))
        {
          return null;
        }
        if (Titulo.Length > 60)
        {
          return Titulo.Substring(0, 60);
        }
        else
        {
          return Titulo;
        }
      }
    }
  }
}
