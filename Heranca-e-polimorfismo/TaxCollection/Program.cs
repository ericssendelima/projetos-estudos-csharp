using TaxCollection.Entities;

Console.Write("Enter the number of tax payers: ");
int numberOfPayers = int.Parse(Console.ReadLine());

List<TaxPayer> taxPayers = [];


for (int payer = 1; payer <= numberOfPayers; payer++)
{
  TaxPayer taxPayer;

  Console.WriteLine($"Tax payer #{payer} data:");
  Console.Write("Individual or company (i/c)? ");
  char typeTaxPayer = char.Parse(Console.ReadLine());

  Console.Write("Name: ");
  string namePayer = Console.ReadLine();
  Console.Write("Anual income: ");
  double anualIncome = double.Parse(Console.ReadLine());

  switch (typeTaxPayer)
  {
    case 'i':
      Console.Write("Health expenditures: ");
      double healthExpenditures = double.Parse(Console.ReadLine());

      taxPayer = new Individual(namePayer, anualIncome, healthExpenditures);

      taxPayers.Add(taxPayer);
      break;

    case 'c':
      Console.Write("Number of employees: ");
      int numberOfEmployees = int.Parse(Console.ReadLine());

      taxPayer = new Company(namePayer, anualIncome, numberOfEmployees);

      taxPayers.Add(taxPayer);
      break;

    default:
      Console.WriteLine("Wrong option");
      break;
  }
}

double totalTaxes = 0.0;

Console.WriteLine();
Console.WriteLine("TAXES PAID:");
foreach (TaxPayer payer in taxPayers)
{
  totalTaxes += payer.Tax();
  Console.WriteLine($"{payer}");
}

Console.WriteLine();
Console.WriteLine($"TOTAL TAXES: $ {totalTaxes:0.00}");
