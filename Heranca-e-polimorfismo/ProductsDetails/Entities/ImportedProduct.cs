namespace ProductsDetails.Entities
{
  public class ImportedProduct(string name, double price, double customsFee) : Product(name, price)
  {
    private readonly double _customsFee = customsFee;

    private double CustomsFee => _customsFee;

    public sealed override string PriceTag()
    {
      return $"{Name} $ {TotalPrice():0.00} (Custom fee: $ {CustomsFee:0.00})";
    }

    public double TotalPrice()
    {
      return Price + CustomsFee;
    }
  }
}