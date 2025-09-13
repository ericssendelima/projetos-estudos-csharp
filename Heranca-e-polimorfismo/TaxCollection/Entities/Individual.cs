namespace TaxCollection.Entities
{
  public class Individual(string name, double anualIncome, double healthExpenditures) : TaxPayer(name, anualIncome)
  {
    private const double LESS_TAX = 0.15;
    private const double MORE_TAX = 0.25;
    private const double HEALTH_EXPENDITURE_TAX = 0.5;
    private readonly double _healthExpenditures = healthExpenditures;

    private double HealthExpenditures => _healthExpenditures;

    public override sealed double Tax()
    {
      double tax = 0.0;
      if (AnualIncome >= 20000)
      {
        tax = AnualIncome * MORE_TAX - (HealthExpenditures * HEALTH_EXPENDITURE_TAX);
      }
      else
      {
        tax = AnualIncome * LESS_TAX - (HealthExpenditures * HEALTH_EXPENDITURE_TAX);
      }
      return tax;
    }
  }
}