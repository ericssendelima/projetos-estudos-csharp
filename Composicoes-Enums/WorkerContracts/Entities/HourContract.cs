namespace WorkerContracts.Entities
{
  public class HourContract(DateTime date, double valuePerHour, int hours)
  {
    private readonly DateTime _date = date;
    private readonly double _valuePerHours = valuePerHour;
    private readonly int _hours = hours;

    private double ValuePerHours => _valuePerHours;

    private int Hours => _hours;

    public DateTime Date => _date;
    public double TotalValue()
    {
      return ValuePerHours * Hours;
    }
  }
}