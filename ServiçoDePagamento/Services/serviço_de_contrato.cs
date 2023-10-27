using ServiçoDePagamento.Entities;
using ServiçoDePagamento.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiçoDeContrato.Services
{
    internal class serviço_de_Contrato 
    {

        public serviço_de_pagamento_online Sdo { get; set; }

        public serviço_de_Contrato(serviço_de_pagamento_online sdo)
        {
            Sdo = sdo;
        }

        public void ContratoDeProcesso(Contrato contrato, int meses)
        {
            double parcela = contrato.Valor / meses;

            for (int i=1; i<=meses; i++)
            {
                DateTime Data = contrato.Data.AddMonths(i);
                double CotaAtualizada = parcela + Sdo.interesse(parcela, i);
                double CotaCompleta = parcela + Sdo.Taxa_de_pagamento(CotaAtualizada);
                contrato.addParcelas(new Parcelas(Data, CotaCompleta));
            }
            
        }
    }
}
