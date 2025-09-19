namespace ContractSlicer.Entities
{
  public class Installment(DateTime duedate, double amount)
  {
    private DateTime Duedate { get; } = duedate;
    private double Amount { get; } = amount;

    public override string ToString()
    {
      return $"{Duedate.ToString("dd/MM/yyyy")} - {Amount:0.00}";
    }
  }
}