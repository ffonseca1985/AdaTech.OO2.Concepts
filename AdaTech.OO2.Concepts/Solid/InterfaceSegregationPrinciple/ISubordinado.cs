using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.InterfaceSegregationPrinciple
{
    public interface ISubordinado: IFuncionario
    {
        string SelecionarSuperior();
    }
}
