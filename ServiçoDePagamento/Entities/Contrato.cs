using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Insira os dados do contrato
Número: 8028
Data (dd/MM/aaaa): 25/06/2018
Valor do contrato: 600,00
Insira o número de parcelas: 3
Parcelas:
25/07/2018 - 206.04
25/08/2018 - 208.08
25/09/2018 - 210.12
*/
namespace ServiçoDePagamento.Entities
{
    //ler os dados de um contrato (número do contrato, data do contrato,
  //  e valor total do contrato).
    internal class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public List<Parcelas> _Parcelas { get; set; }

        public Contrato(int numero, DateTime data, double valor)
        {
            Numero = numero;
            Data = data;
            Valor = valor;
            _Parcelas = new List<Parcelas>();
        }

        public void addParcelas(Parcelas parcelas)
        {
            _Parcelas.Add(parcelas);
        }
    }
}
