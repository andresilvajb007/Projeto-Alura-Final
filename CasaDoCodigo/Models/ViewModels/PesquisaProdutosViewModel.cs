using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class PesquisaProdutosViewModel
    {
        public PesquisaProdutosViewModel(IList<Produto> itens)
        {
            Itens = itens;
        }

        public IList<Produto> Itens { get; }

        public string textoPesquisa { get; set; }
    }
}
