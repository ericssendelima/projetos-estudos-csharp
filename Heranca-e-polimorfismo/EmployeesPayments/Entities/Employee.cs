namespace EmployeesPayments.Entities
{
  public class Employee(string name, int hours, double valuePerHour)
  {
    private readonly string _name = name;
    private readonly int _hours = hours;
    private readonly double _valuePerHour = valuePerHour;
    private double _paymentEmployee;

    private int Hours => _hours;
    private double ValuePerHour => _valuePerHour;

    protected double PaymentEmployee
    {
      get => _paymentEmployee;
      set
      {
        _paymentEmployee = value;
      }
    }
    public string Name => _name;

    public virtual double Payment()
    {
      PaymentEmployee = ValuePerHour * Hours;
      return PaymentEmployee;
    }
  }
}