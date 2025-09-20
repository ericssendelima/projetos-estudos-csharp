namespace ContractSlicer.Core.Entities
{
  public class Contract(int number, DateTime date, double totalValue)
  {
    private readonly List<Installment> _installments = [];
    public int Number { get; } = number;
    public DateTime Date { get; } = date;
    public double TotalValue { get; } = totalValue;
    public IReadOnlyList<Installment> Installments => _installments;

    public void AddInstallment(Installment installment)
    {
      _installments.Add(installment);
    }
  }
}