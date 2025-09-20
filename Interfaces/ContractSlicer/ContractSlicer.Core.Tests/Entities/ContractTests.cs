using ContractSlicer.Core.Entities;

namespace ContractSlicer.Core.Tests.Entities
{
  public class ContractTests
  {
    [Fact]
    public void Test1()
    {
      Contract contract = new(1234, new DateTime(2023, 1, 20), 600.00);
      contract.AddInstallment(new Installment(new DateTime(2023, 2, 20), 200.00));
      contract.AddInstallment(new Installment(new DateTime(2023, 3, 20), 200.00));
      contract.AddInstallment(new Installment(new DateTime(2023, 4, 20), 200.00));

      Assert.Equal(3, contract.Installments.Count);
      Assert.Equal(200.00, contract.Installments[0].Amount);
      Assert.Equal(new DateTime(2023, 4, 20), contract.Installments[2].Duedate);

      Assert.Equal(1234, contract.Number);
      Assert.Equal(new DateTime(2023, 1, 20), contract.Date);
      Assert.Equal(600.00, contract.TotalValue);
    }

    [Fact]
    public void Test2()
    {
      Contract contract = new(4321, new DateTime(2023, 5, 15), 1500.00);
      contract.AddInstallment(new Installment(new DateTime(2023, 6, 15), 500.00));
      contract.AddInstallment(new Installment(new DateTime(2023, 7, 15), 500.00));
      contract.AddInstallment(new Installment(new DateTime(2023, 8, 15), 500.00));

      Assert.Equal(3, contract.Installments.Count);
      Assert.Equal(500.00, contract.Installments[1].Amount);
      Assert.Equal(new DateTime(2023, 8, 15), contract.Installments[2].Duedate);

      Assert.Equal(4321, contract.Number);
      Assert.Equal(new DateTime(2023, 5, 15), contract.Date);
      Assert.Equal(1500.00, contract.TotalValue);
    }
  }
}