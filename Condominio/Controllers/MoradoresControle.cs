using System;
using System.Collections.Generic;
using System.Linq;
using Controllers.Base;
using Controllers.DAL;
using Modelos;

namespace Controllers
{
    public class MoradoresControle : IBaseController<Morador>
    {
        private Contexto contexto = new Contexto();

        public void Adicionar(Morador entity)
        {
            contexto.Moradores.Add(entity);
            contexto.SaveChanges();
        }

        public void Atualizar(Morador entity)
        {
            contexto.Entry(entity).State =
                System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public Morador BuscarPorID(int id)
        {
            return contexto.Moradores.Find(id);
        }

        public void Excluir(int id)
        {
            Morador m = BuscarPorID(id);
            if (m != null)
            {
                contexto.Moradores.Remove(m);
                contexto.SaveChanges();

            }
        }

        public IList<Morador> ListarPorNome(string nomem)
        { 
            return contexto.Moradores.Where(m => m.NomeM.ToLower() == nomem.ToLower()).ToList();
                
        }

        public IList<Morador> ListarTodos()
        {
            return contexto.Moradores.ToList();

        }
    }}
