﻿
namespace Solid.OpenClosePrinciple
{
    public class TransportadoraJadLog : ITransportadora
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        //O mais serto seria um objeto mais especifico
        public decimal CalcularFrete(Pedido pedido)
        {
            //Colocar a regra que quisesse....
            return 20;
        }
    }
}
