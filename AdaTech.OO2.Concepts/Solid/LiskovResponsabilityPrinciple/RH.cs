using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovResponsabilityPrinciple
{
    public class RelatorioRH
    {
        public void ListarSuperior(List<Funcionario> funcionario)
        {
            foreach (Funcionario func in funcionario)
            {
                func.SelecionarSuperior();
            }
        }
    }
}
