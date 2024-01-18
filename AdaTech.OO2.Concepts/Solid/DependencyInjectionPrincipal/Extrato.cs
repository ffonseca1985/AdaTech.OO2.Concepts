
namespace Solid.DependencyInjectionPrincipal
{
    //Modulos de Alto nivel não devem depender de módulos de baixo nível
    public class Extrato
    //Classe de Alto nivel
    //Classe de baixo nível Seriam as classes concretas
    {
        public List<IInvestmento> Investimentos { get; set; }

        public void Add(IInvestmento investmento)
        {
            Investimentos.Add(investmento);
        }
    }

    //Modulos de Alto nivel não devem depender de módulos de baixo nível
    //public class Extrato
    ////Classe de Alto nivel
    ////Classe de baixo nível Seriam as classes concretas
    //{

    //    //Esta abordagem feri o OCP
    //    public List<RendaFixa> InvestimentosRF { get; set; }
    //    public List<RendaVariavel> InvestimentosRV { get; set; }

    //    public void Add(RendaFixa investmento)
    //    {
    //        InvestimentosRF.Add(investmento);
    //    }

    //    public void Add(RendaVariavel investmento)
    //    {
    //        InvestimentosRV.Add(investmento);
    //    }
    //}
}
