using WorkerContracts.Entities;
using WorkerContracts.Enums;


Console.Write("Enter department's name: ");
string departamentName = Console.ReadLine();
Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string workerName = Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
string levelAnswer = Console.ReadLine().ToUpper();
while (!Enum.IsDefined(typeof(WorkLevel), levelAnswer))
{
  Console.WriteLine("Level inválid. Try one given format.");
  Console.Write("Level (Junior/MidLevel/Senior): ");
  levelAnswer = Console.ReadLine().ToUpper();
}

WorkLevel workLevel = Enum.Parse<WorkLevel>(levelAnswer);
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine());
Console.Write("How many contracts to this worker? ");
int contractsNumber = int.Parse(Console.ReadLine());
Console.WriteLine();

Departament departament = new(departamentName);
Worker worker = new(name: workerName, level: workLevel, salary: baseSalary, departament: departament);

for (int i = 0; i < contractsNumber; i++)
{
  Console.WriteLine($"Enter contract #{i + 1} data: ");
  Console.Write("Date (DD/MM/YYYY): ");
  DateTime date = DateTime.Parse(Console.ReadLine());
  Console.Write("Value per hour: ");
  double valuePerHour = double.Parse(Console.ReadLine());
  Console.Write("Duration (hours): ");
  int duration = int.Parse(Console.ReadLine());
  Console.WriteLine();

  HourContract contract = new(date, valuePerHour, hours: duration);

  worker.AddContract(contract);
}

Console.Write("Enter month and year to calculate income (MM/YYYY): ");
var searchDate = Console.ReadLine().Split("/");

int month = int.Parse(searchDate[0]);
int year = int.Parse(searchDate[1]);

double income = worker.Income(year, month);

Console.WriteLine($"Name: {worker.Name}");
Console.WriteLine($"Departament: {worker.Departament.Name}");
Console.WriteLine($"Income for {month:00}/{year}: {income:0.00}");
