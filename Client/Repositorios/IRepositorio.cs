using MudBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MudBlazor.Client.Repositorios
{
  public interface IRepositorio
  {
   
    
    List<Pelicula> ObtenerPeliculas();
    Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
  }
}
