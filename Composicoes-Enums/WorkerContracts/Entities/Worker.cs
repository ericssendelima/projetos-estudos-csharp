using WorkerContracts.Enums;

namespace WorkerContracts.Entities
{
  public class Worker(string name, WorkLevel level, double salary)
  {
    private readonly string _name = name;
    private readonly WorkLevel _level = level;
    private readonly double _salary = salary;
  }
}