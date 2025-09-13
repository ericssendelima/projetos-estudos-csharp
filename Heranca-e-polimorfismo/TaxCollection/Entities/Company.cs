namespace TaxCollection.Entities
{
  public class Company(string name, double anualIncome, int numberOfEmployees) : TaxPayer(name, anualIncome)
  {
    private const double UNTIL_TEN_EMPLOYEES_TAX = 0.16;
    private const double ABOVE_TEN_EMPLOYEES_TAX = 0.14;
    private readonly int _numberOfEmployees = numberOfEmployees;

    private int NumberOfEmployees => _numberOfEmployees;
    public override sealed double Tax()
    {
      double tax = 0.0;

      if (NumberOfEmployees <= 10)
      {
        tax = AnualIncome * UNTIL_TEN_EMPLOYEES_TAX;
      }
      else
      {
        tax = AnualIncome * ABOVE_TEN_EMPLOYEES_TAX;
      }

      return tax;
    }
  }
}