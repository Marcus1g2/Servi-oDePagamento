using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiçoDePagamento.Services
{
    internal class serviço_PayPal : serviço_de_pagamento_online
    {
  
        private const double taxa = 0.02;
        private const double juros_simples  = 0.01;

        public double interesse(double amount, int months)
        {
            return amount * juros_simples * months;
        }

        public double Taxa_de_pagamento(double amount)
        {
            return amount * taxa;
        }
    }
}
