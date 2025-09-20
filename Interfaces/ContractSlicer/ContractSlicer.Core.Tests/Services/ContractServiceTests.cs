using Xunit;
using ContractSlicer.Core.Entities;
using ContractSlicer.Core.Services;
using ContractSlicer.Core.Services.Interfaces;

namespace ContractSlicer.Core.Tests.Services;

public class ContractServiceTests
{
  [Fact]
  public void ProcessContract_ShouldGenerateCorrectInstallments_ForThreeMonths()
  {
    // ARRANGE (Arrumar)
    // -----------------------------------------------------------------
    // Agora usamos nosso serviço FAKE, nos dando total controle!
    IOnlinePaymentService fakePaymentService = new FakePaymentService();
    var contractService = new ContractService(fakePaymentService);

    var contract = new Contract(8028, new DateTime(2018, 6, 25), 600.00);
    int numberOfMonths = 3;

    // ACT (Agir)
    // -----------------------------------------------------------------
    contractService.ProcessContract(contract, numberOfMonths);

    // ASSERT (Afirmar)
    // -----------------------------------------------------------------
    Assert.Equal(3, contract.Installments.Count);

    // Verificando os valores exatos que calculamos no passado!
    // O '2' no final do Assert.Equal é para comparar com 2 casas de precisão decimal.
    Assert.Equal(206.04, double.Parse(contract.Installments[0].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2018, 7, 25), contract.Installments[0].Duedate);

    Assert.Equal(208.08, double.Parse(contract.Installments[1].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2018, 8, 25), contract.Installments[1].Duedate);

    Assert.Equal(210.12, double.Parse(contract.Installments[2].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2018, 9, 25), contract.Installments[2].Duedate);


  }

  [Fact]
  public void ProcessContract_ShouldGenerateCorrectInstallments_ForSevenMonths()
  {
    // ARRANGE
    IOnlinePaymentService fakePaymentService = new FakePaymentService();
    var contractService = new ContractService(fakePaymentService);

    var contract = new Contract(8028, new DateTime(2012, 9, 12), 1387.50);
    int numberOfMonths = 7;

    // ACT
    contractService.ProcessContract(contract, numberOfMonths);
    // ASSERT
    Assert.Equal(7, contract.Installments.Count);

    Assert.Equal(204.20, double.Parse(contract.Installments[0].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2012, 10, 12), contract.Installments[0].Duedate);
    Assert.Equal(206.22, double.Parse(contract.Installments[1].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2012, 11, 12), contract.Installments[1].Duedate);
    Assert.Equal(208.24, double.Parse(contract.Installments[2].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2012, 12, 12), contract.Installments[2].Duedate);
    Assert.Equal(210.27, double.Parse(contract.Installments[3].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2013, 1, 12), contract.Installments[3].Duedate);
    Assert.Equal(212.29, double.Parse(contract.Installments[4].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2013, 2, 12), contract.Installments[4].Duedate);
    Assert.Equal(214.31, double.Parse(contract.Installments[5].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2013, 3, 12), contract.Installments[5].Duedate);
    Assert.Equal(216.33, double.Parse(contract.Installments[6].Amount.ToString("F2")), 2);
    Assert.Equal(new DateTime(2013, 4, 12), contract.Installments[6].Duedate);
  }
}