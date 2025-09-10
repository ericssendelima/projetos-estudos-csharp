namespace OrderSystem.Entities
{
  public class Product(string name, double price)
  {
    private readonly string _name = name;
    private readonly double _price = price;
    public string Name => _name;
    public double Price => _price;
  }
}