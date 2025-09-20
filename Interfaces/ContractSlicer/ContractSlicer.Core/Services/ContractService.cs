using ContractSlicer.Core.Entities;
using ContractSlicer.Core.Services.Interfaces;

namespace ContractSlicer.Core.Services
{
  public class ContractService(IOnlinePaymentService onlinePaymentService)
  {
    private readonly IOnlinePaymentService _onlinePaymentService = onlinePaymentService;
    public void ProcessContract(Contract contract, int months)
    {
      double baseInterestAmount = contract.TotalValue / months;

      for (int month = 1; month <= months; month++)
      {
        double interest = _onlinePaymentService.Interest(amount: baseInterestAmount, month);
        double installmentValue = _onlinePaymentService.PaymentFee(interest);

        Installment installment = new(duedate: contract.Date.AddMonths(month), installmentValue);

        contract.AddInstallment(installment);
      }
    }
  }
}