using Estudiantes.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace  Zacaria20181285.Data.Context;


public class EstudianteDbContext:DbContext
{

    public EstudianteDbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<P> Pe {get; set;} = null!;
    public virtual DbSet<Estudiante> Estudiante {get; set;} = null!;



}  

