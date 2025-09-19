using ContractSlicer.Entities;
using ContractSlicer.Services;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.Parse(Console.ReadLine());
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine());
Console.Write("Enter number of installments: ");
int installmentNumber = int.Parse(Console.ReadLine());
Console.WriteLine();

Contract contract = new(number: contractNumber, date: contractDate, totalValue: contractValue);

ContractService contractService = new(new PaypalService());
contractService.ProcessContract(contract, installmentNumber);

Console.WriteLine("Installments:");
foreach (Installment installment in contract.Installments)
{
  Console.WriteLine(installment);
}


