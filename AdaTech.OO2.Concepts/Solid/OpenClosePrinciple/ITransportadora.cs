namespace Solid.OpenClosePrinciple
{
    public interface ITransportadora {

        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal CalcularFrete(Pedido pedido);
    }
}
