namespace WorkerContracts.Entities
{
  public class HourContract(DateTime date, double valuePerHour, int hours)
  {
    private readonly DateTime _date = date;
    private readonly double _valuePerHours = valuePerHour;
    private readonly int _hours = hours;

    private double ValuePerHours => _valuePerHours;
    public double TotalValue()
    {
      return ValuePerHours;
    }
  }
}