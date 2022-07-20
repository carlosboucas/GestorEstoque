using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    interface IEstoque
    {
        void Exibir();
        void AdicionarEntrada(); //add novo item ao estoque ou nova vaga.
        void AdicionarSaida(); //Registrar vendas.
    }
}
