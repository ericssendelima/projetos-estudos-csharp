using EmployeesPayments.Entities;

Console.Write("Enter the number of employees: ");
int numberOfEmployees = int.Parse(Console.ReadLine());

List<Employee> employees = [];

for (int employee = 1; employee <= numberOfEmployees; employee++)
{
  Console.WriteLine($"Employee #{employee} data:");
  Console.Write("Outsourced (y/n)? ");
  bool isOutsourced = string.Equals(Console.ReadLine(), "y");

  Console.Write("Name: ");
  string name = Console.ReadLine();
  Console.Write("Hours: ");
  int hours = int.Parse(Console.ReadLine());
  Console.Write("Value per hour: ");
  double valuePerHour = double.Parse(Console.ReadLine());

  Employee worker;

  if (isOutsourced)
  {
    Console.Write("Additional charge: ");
    double additionalCharge = double.Parse(Console.ReadLine());

    worker = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
  }
  else
  {
    worker = new(name, hours, valuePerHour);
  }


  employees.Add(worker);
}
Console.WriteLine();
Console.WriteLine("PAYMENTS:");
foreach (Employee employee in employees)
{
  Console.WriteLine($"{employee.Name} - $ {employee.Payment():0.00}");
}