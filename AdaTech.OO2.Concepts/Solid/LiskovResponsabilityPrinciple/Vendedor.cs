﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LiskovResponsabilityPrinciple
{
    public class Vendedor : Funcionario
    {
        public string SelecionarSuperior()
        {
            return "Gerente";
        }
    }
}
