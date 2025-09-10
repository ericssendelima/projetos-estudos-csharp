using OrderSystem.Enums;

namespace OrderSystem.Entities
{
  public class Order(Client client, OrderStatus orderStatus)
  {
    private readonly Client _client = client;
    private readonly OrderStatus _orderStatus = orderStatus;

    private readonly List<OrderItem> _items = [];

    public Client Client => _client;
    public OrderStatus OrderStatus => _orderStatus;
    private List<OrderItem> OrderItems => _items;

    public void AddItem(OrderItem orderItem)
    {
      OrderItems.Add(orderItem);
    }
    public void RemoveItem(OrderItem orderItem)
    {
      OrderItems.Remove(orderItem);
    }
    public double Total()
    {
      double total = 0;

      foreach (OrderItem orderItem in OrderItems)
      {
        total += orderItem.Price * orderItem.Quantity;
      }
      return total;
    }

  }
}