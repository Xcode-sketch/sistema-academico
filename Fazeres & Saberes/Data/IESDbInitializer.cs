using Fazeres___Saberes.Models;

namespace Fazeres___Saberes.Data
{
    public static class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Departamentos.Any())
            {
                return;
            }
            var departamentos = new Departamento[]
            {
                new Departamento{ NomeDepartamento="Secretaria da Educação"},
                new Departamento{ NomeDepartamento="Coordenação Pedagógica"},
                new Departamento{ NomeDepartamento="Direção"},
                new Departamento{ NomeDepartamento="Professores"}
            };
            foreach (Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }
        }
    }
}
