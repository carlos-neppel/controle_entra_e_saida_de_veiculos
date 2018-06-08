using System.Data.Entity;
using Modelos;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Visitante> Visitates { get; set; }

        public DbSet<Morador> Moradores { get; set; }
    }
}
