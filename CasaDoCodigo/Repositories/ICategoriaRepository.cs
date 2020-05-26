using CasaDoCodigo.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public interface ICategoriaRepository //: BaseRepository<Categoria>
    {
        Task<Categoria> SaveCategoria(string nome);
        IList<Categoria> GetCategorias();
        Categoria GetCategoria(string nome);
    }
}