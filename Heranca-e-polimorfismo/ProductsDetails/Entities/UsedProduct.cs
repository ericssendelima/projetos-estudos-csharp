namespace ProductsDetails.Entities
{
  public class UsedProduct(string name, double price, DateTime date) : Product(name, price)
  {
    private readonly DateTime _date = date;
    public DateTime Date => _date;
    public override string PriceTag()
    {
      return $"{Name} (used) $ {Price} (Manufacture date: {Date.ToString("dd/MM/yy")})";
    }
  }
}