using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Estágio
{
    public static class ProdutoRepositorio
    {
        private static List<Produto> Produtos = new List<Produto>();

        public static void Add(Produto produto)
        {
            Produtos.Add(produto);
        }
        public static List<Produto> Buscar()
        {
            return Produtos;
        }
    }
}
