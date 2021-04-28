using Microsoft.AspNetCore.Mvc;
using MudBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudBlazor.Server.Controllers
{

  [ApiController]
  [Route("api/[controller]")]
  public class GenerosController:ControllerBase
  {
    private readonly ApplicationDBContext context;

    public GenerosController(ApplicationDBContext context)
    {
      this.context = context;
    }
    [HttpPost]
    public async Task<ActionResult<int>> Post(Genero genero)
    {
      context.Add(genero);
      await context.SaveChangesAsync();
      return genero.Id;
    }
  }
}
