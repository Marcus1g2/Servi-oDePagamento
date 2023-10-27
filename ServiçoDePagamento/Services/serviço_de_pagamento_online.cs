using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiçoDePagamento.Services
{
    internal interface serviço_de_pagamento_online
    {
        public double Taxa_de_pagamento(double montante);
        public double interesse(double montante, int Meses);
    }
}
