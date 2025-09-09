using WorkerContracts.Enums;

namespace WorkerContracts.Entities
{
  public class Worker(string name, WorkLevel level, double salary, Departament departament, List<HourContract> hourContracts)
  {
    private readonly string _name = name;
    private readonly WorkLevel _level = level;
    private readonly double _salary = salary;
    private readonly Departament _departament = departament;
    private readonly List<HourContract> _hourContracts = hourContracts;

    private double Salary => _salary;
    public Departament Departament => _departament;

    public List<HourContract> HourContracts => _hourContracts;
    public void AddContract(HourContract contract)
    { }
    public void RemoveContract(HourContract contract)
    { }
    public double Income(int year, int month)
    {
      return Salary;
    }
  }
}