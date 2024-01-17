
namespace Solid.InterfaceSegregationPrinciple
{
    public class RelatorioRH
    {
        public void ListarSuperior(List<ISubordinado> funcionario)
        {
            foreach (ISubordinado func in funcionario)
            {
                func.SelecionarSuperior();
            }
        }
    }
}
