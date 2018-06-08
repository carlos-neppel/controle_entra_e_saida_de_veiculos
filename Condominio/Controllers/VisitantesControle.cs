using System;
using System.Collections.Generic;
using Controllers.Base;
using Modelos;
using System.Linq;
using Controllers.DAL;

namespace Controllers
{
    public class VisitantesControle : IBaseController<Visitante>
    {
        private Contexto contexto = new Contexto();
        
            public void Adicionar(Visitante entity)
            {
            contexto.Visitates.Add(entity);
            contexto.SaveChanges();
            
            }

            public void Atualizar(Visitante entity)
            {
            contexto.Entry(entity).State =
            System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
            }

            public Visitante BuscarPorID(int id)
            {
            return contexto.Visitates.Find(id);
            }
        
        public void Excluir(int id)
            {
            Visitante v = BuscarPorID(id);
            if(v != null)
            {
                contexto.Visitates.Remove(v);
                contexto.SaveChanges();
            }
            }

        public IList<Visitante> ListarPorNome(string nome)
            {
            return contexto.Visitates.
            Where(v => v.Nome.ToLower() == nome.ToLower()).ToList();
            }

            public IList<Visitante> ListarTodos()
            {
            return contexto.Visitates.ToList();
            }
 }}

