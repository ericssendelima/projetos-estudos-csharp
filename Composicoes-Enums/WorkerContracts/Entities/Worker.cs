using WorkerContracts.Enums;

namespace WorkerContracts.Entities
{
  public class Worker(string name, WorkLevel level, double salary, Departament departament)
  {
    private readonly string _name = name;
    private readonly WorkLevel _level = level;
    private readonly double _salary = salary;
    private readonly Departament _departament = departament;
    private readonly List<HourContract> _hourContracts = [];

    private double Salary => _salary;
    public Departament Departament => _departament;
    public string Name => _name;

    private List<HourContract> HourContracts => _hourContracts;

    public void AddContract(HourContract contract)
    {
      HourContracts.Add(contract);
    }
    public void RemoveContract(HourContract contract)
    {
      HourContracts.Remove(contract);
    }
    public double Income(int year, int month)
    {
      double income = Salary;

      foreach (HourContract contract in HourContracts)
      {
        if (contract.Date.Year == year && contract.Date.Month == month)
        {
          var contractValue = contract.TotalValue();

          income += contractValue;
        }
      }

      return income;
    }
  }
}