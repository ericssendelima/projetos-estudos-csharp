using WorkerContracts.Enums;

Console.Write("Enter department's name: ");
string departamentName = Console.ReadLine();
Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string workerName = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkLevel workLevel = Enum.Parse<WorkLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine());
Console.Write("How many contracts to this worker? ");
int contractsNumber = int.Parse(Console.ReadLine());

for (int contract = 0; contract < contractsNumber; contract++)
{
  Console.WriteLine($"Enter contract #{contract} data: ");
}
