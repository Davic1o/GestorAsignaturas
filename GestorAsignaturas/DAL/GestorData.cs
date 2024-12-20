using System.Data.Entity; 
using GestorAsignaturas.Models;

namespace GestorAsignaturas.DAL
{
    public class GestorData : DbContext
    {
        public DbSet<Asignatura> Asignaturas { get; set; }
    }
}
