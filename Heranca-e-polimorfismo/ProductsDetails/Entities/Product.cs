namespace ProductsDetails.Entities
{
  public class Product(string name, double price)
  {
    private readonly string _name = name;
    private readonly double _price = price;

    protected string Name => _name;
    protected double Price => _price;
    public virtual string PriceTag()
    {
      return $"{Name} $ {Price:0.00}";
    }
  }
}