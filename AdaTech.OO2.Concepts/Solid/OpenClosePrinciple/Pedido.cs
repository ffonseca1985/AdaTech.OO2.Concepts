namespace Solid.OpenClosePrinciple
{
    //Principio da Aberto e Fechado
    //Uma classe deve estar fechada para modificacao e aberta para extensão
    public class Pedido
    {
        public decimal Total { get; set; }

        public decimal Frete
        {
            get
            {
                return this.Transportadora == null ? 0 : this.Transportadora.CalcularFrete(this);
            }
        }

        //Injeção de Dependecia via construtor
        public Pedido(ITransportadora transportadora)
        {
            this.Transportadora = transportadora;
        }

        public Pedido() { }

        //public decimal ValidarPagamento() { }

        //public Pagamento Pagamento { get; set; }

        //Injeção de Dependecia via propriedade
        public ITransportadora? Transportadora { get; set; }
    }

    //public class Pedido
    //{
    //    public decimal Total { get; set; }

        // 1 - Mais de 1 responsabilidade
        // 2 - Transportadora esta acoplando pedido
    //    // 3 - 
    //    public decimal CalcularFrete() {
            
    //        if (Transportadora == null)
    //        {
    //            return 0;
    //        }

    //        switch (Transportadora.Nome)
    //        {
    //            case "JadLog":
    //                return 100;
    //            case "Correios":
    //                return 150;
    //            case "Rapidão Cometa":
    //                return (5 / 100) * Total;    
    //            default:
    //                throw new Exception("Transportadora não mapeada");
    //        }
    //    }

    //    //public decimal ValidarPagamento() { }

    //    public Transportadora Transportadora { get; set; }
    //}

    //public class Pagamento {
    //    public string Id { get; set; }
    //    public string Nome { get; set; }
    //}

    //public class Transportadora {

    //    public string Id { get; set; }
    //    public string Nome { get; set; }

    //    public decimal CalcularFrete(decimal Km, decimal total)
    //    {
    //        switch (this.Nome)
    //        {
    //            case "JadLog":
    //                return 100;
    //            case "Correios":
    //                return 150;
    //            case "Rapidão Cometa":
    //                return (5 / 100) * total;
    //            default:
    //                throw new Exception("Transportadora não mapeada");
    //        }
    //    }
    //}
}
