namespace OrderSystem.Entities
{
  public class OrderItem(int quantity, Product product, double price)
  {
    private readonly int _quantity = quantity;
    private readonly Product _product = product;

    private readonly double _price = price;

    public int Quantity => _quantity;
    public Product Product => _product;
    public double Price => _price;

    public override string ToString()
    {
      return $"{Product.Name}, ${Price:0.00}, Quantity: {Quantity}, Subtotal: ${(Price*Quantity):0.00}";
    }
  }
}