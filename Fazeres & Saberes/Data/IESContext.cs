using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

namespace Fazeres___Saberes.Data
{
    public class IESContext : DbContext
    {
        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {
               
        }
        public DbSet<Models.Departamento> Departamentos { get; set; }
        public DbSet<Models.Instituicao> Instituicoes { get; set; }
    }
}
