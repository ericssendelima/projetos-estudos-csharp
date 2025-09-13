namespace TaxCollection.Entities
{
  public abstract class TaxPayer(string name, double anualIncome)
  {
    private readonly string _name = name;
    private readonly double _anualIncome = anualIncome;

    protected string Name => _name;
    protected double AnualIncome => _anualIncome;

    public abstract double Tax();

    public override string ToString()
    {
      return $"{Name}: $ {Tax():0.00}";
    }
    }
}