using Microsoft.EntityFrameworkCore;
using MudBlazor.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudBlazor.Server
{
  public class ApplicationDBContext : DbContext
  {
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<GeneroPelicula>().HasKey(x => new { x.GeneroId, x.PeliculaId });
      modelBuilder.Entity<PeliculaActor>().HasKey(x => new {x.PeliculaId,x.PersonaId });
      base.OnModelCreating(modelBuilder);

    }

    public DbSet<GeneroPelicula> GenerosPeliculas { get; set; }
    public DbSet<Pelicula> Peliculas { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<PeliculaActor> PeliculasActores { get; set; }

  }
}
