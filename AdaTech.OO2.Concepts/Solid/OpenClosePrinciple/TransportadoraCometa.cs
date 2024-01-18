﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.OpenClosePrinciple
{
    public class TransportadoraCometa : ITransportadora
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        //O mais serto seria um objeto mais especifico
        public decimal CalcularFrete(Pedido pedido)
        {
            //Colocar a regra que quisesse....
            return 210;
        }
    }
}
