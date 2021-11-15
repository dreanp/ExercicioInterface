using System;
using Entities;
using Service;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int contractNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int months = Convert.ToInt32(Console.ReadLine());

Contract myContract = new Contract(contractNumber, contractDate, contractValue);

ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(myContract, months);

Console.WriteLine("Installments: ");
foreach(Installment installment in myContract.Installments)
{
    Console.WriteLine(installment);
}




