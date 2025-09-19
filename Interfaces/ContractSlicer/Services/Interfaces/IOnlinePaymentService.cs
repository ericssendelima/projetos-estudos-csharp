namespace ContractSlicer.Services.Interfaces
{
  public interface IOnlinePaymentService
  {
    double PaymentFee(double amount);
    double Interest(double amount, int month);
  }
}