using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etiquetas_Pedidos.Model
{
    internal class Itens
    {
        public int Reduzido { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }


        public Itens(int reduzido, string descricao, string unidade)
        {
            Reduzido = reduzido;
            Descricao = descricao ?? throw new ArgumentNullException(nameof(descricao));
            Unidade = unidade ?? throw new ArgumentNullException(nameof(unidade));
        }

        public Itens()
        {
        }
    }
}
