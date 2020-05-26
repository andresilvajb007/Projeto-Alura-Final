using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public IList<Categoria> GetCategorias()
        {
            return dbSet.ToList();
        }

        public Categoria GetCategoria(string nome)
        {
            return dbSet.Where(x => x.Nome.ToLower() == nome.ToLower()).SingleOrDefault();
        }

        public async Task<Categoria> SaveCategoria(string nome)
        {
            var categoria = new Categoria(nome);

            if (!dbSet.Where(p => p.Nome == nome).Any())
            {                
                dbSet.Add(categoria);
                await contexto.SaveChangesAsync();
            }

            return categoria;
        }
    }

  
}
