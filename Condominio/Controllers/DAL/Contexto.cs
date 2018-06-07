using Modelos;
using System;
using System.Runtime.Remoting.Contexts;

namespace Controllers.DAL
{
    class Contexto : Context
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Visitante> Visitantes { get; set; }

        public DbSet<Morador> Moradores { get ; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}