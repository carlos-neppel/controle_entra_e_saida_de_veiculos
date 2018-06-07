using System;
using System.Collections.Generic;
using Controllers.Base;
using Modelos;
using Controllers.DAL;
using System.Linq;


namespace Controllers
{
    public class VisitantesControle : IBaseController<Visitante>
    {
        private Contexto contexto = new Contexto();
        
            public void Adicionar(Visitante entity)
            {
            contexto.Visitantes.Add(entity);
            contexto.SaveChanges();

            }

            public void Atualizar(Visitante entity)
            {
                throw new NotImplementedException();
            }

            public Visitante BuscarPorID(int id)
            {
                throw new NotImplementedException();
            }

            public void Excluir(int id)
            {
                throw new NotImplementedException();
            }

            public IList<Visitante> ListarPorNome(string nome)
            {
                throw new NotImplementedException();
            }

            public IList<Visitante> ListarTodos()
            {
                throw new NotImplementedException();
            }
        }

        

    }
}
