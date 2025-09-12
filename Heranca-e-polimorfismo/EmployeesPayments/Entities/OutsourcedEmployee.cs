namespace EmployeesPayments.Entities
{
  public class OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : Employee(name, hours, valuePerHour)
  {
    private readonly double _additionalCharge = additionalCharge;
    private double AdditionalCharge => _additionalCharge;

    public override double Payment()
    {
      PaymentEmployee = base.Payment();
      PaymentEmployee += AdditionalCharge * 1.10;

      return PaymentEmployee;      
    }
  }
}