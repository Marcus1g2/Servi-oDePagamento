using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiçoDePagamento.Entities
{
    internal class Parcelas
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public Parcelas(DateTime data, double valor)
        {
            Data = data;
            Valor = valor;
        }

        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy")+" --- "+ Valor.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
