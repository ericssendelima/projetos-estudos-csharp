namespace ContractSlicer.Core.Entities
{
  public class Installment(DateTime duedate, double amount)
  {
    public DateTime Duedate { get; } = duedate;
    public double Amount { get; } = amount;

    public override string ToString()
    {
      return $"{Duedate:dd/MM/yyyy} - {Amount:0.00}";
    }
  }
}