// See https://aka.ms/new-console-template for more information

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
using ServiçoDeContrato.Services;
using ServiçoDePagamento.Entities;
using ServiçoDePagamento.Services;
using System.Data;
using System.Globalization;
Console.WriteLine("Insira os dados do contrato");
Console.WriteLine("Número: ");
int Numero=int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Data (dd/MM/aaaa): ");
DateTime dateTime = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
Console.WriteLine("Valor do contrato: ");
double Valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine("Insira o número de parcelas: ");
int Parcelas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Contrato contrato=new Contrato(Numero, dateTime,Valor);
serviço_de_Contrato Sdcontrato = new(new serviço_PayPal());

Sdcontrato.ContratoDeProcesso(contrato, Parcelas);


Console.WriteLine("Parcelas: ");
foreach (Parcelas parcelas in contrato._Parcelas)
{
    Console.WriteLine(parcelas);
}