using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudBlazor.Shared.Entidades
{
  public class Genero
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo {0} es Obligatorio")]
    public string Nombre { get; set; }
    public List<GeneroPelicula> GeneroPeliculas { get; set; }

  }
}
