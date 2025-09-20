using ContractSlicer.Core.Services.Interfaces;

namespace ContractSlicer.Core.Tests.Services
{
  // --- MOCK (OU FAKE) ---
  // Criamos uma implementação "fake" do serviço de pagamento.
  // Ela não fala com o PayPal, só simula o comportamento para o teste.
  // Podemos até colocar isso em um arquivo separado depois!
  public class FakePaymentService : IOnlinePaymentService
  {
    private const double FeeRate = 0.02;      // 2% de taxa de pagamento
    private const double InterestRate = 0.01; // 1% de juros simples ao mês

    public double PaymentFee(double amount)
    {
      // Corrigido: A taxa deve ser somada ao valor base para obter o total.
      // Ex: 100 + (100 * 0.02) = 102
      return amount * (1 + FeeRate);
    }

    public double Interest(double amount, int month)
    {
      return amount * (1 + (InterestRate * month));
    }
  }
}