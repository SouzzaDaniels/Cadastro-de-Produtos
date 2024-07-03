using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Estágio
{
    public class Produto
    {
        public Produto(string nome, string descricao, float valor, bool disponivel)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            Disponivel = disponivel;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; }
        public bool Disponivel { get; set; }
    }

}
