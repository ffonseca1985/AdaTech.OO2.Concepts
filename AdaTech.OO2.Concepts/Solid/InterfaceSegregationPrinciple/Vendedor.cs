using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrinciple
{
    public class Vendedor : ISubordinado
    {
        public string SelecionarSuperior()
        {
            return "Gerente";
        }
    }
}
