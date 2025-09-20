using ContractSlicer.Core.Services.Interfaces;

namespace ContractSlicer.Core.Services
{
  public class PaypalService : IOnlinePaymentService
  {

    private readonly double _feePercentage = 0.02;
    private readonly double _monthlyInterest = 0.01;
    public double Interest(double amount, int month)
    {
      return amount * (1 + (_monthlyInterest * month));
    }

    public double PaymentFee(double amount)
    {
      return amount * (1 + _feePercentage);
    }
  }
}