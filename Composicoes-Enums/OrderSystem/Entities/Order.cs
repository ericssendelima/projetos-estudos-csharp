using System.Text;
using OrderSystem.Enums;

namespace OrderSystem.Entities
{
  public class Order(Client client, OrderStatus orderStatus)
  {
    private readonly DateTime _moment = DateTime.Now;
    private readonly Client _client = client;
    private readonly OrderStatus _orderStatus = orderStatus;

    private readonly List<OrderItem> _items = [];

    public DateTime Moment => _moment;
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

    public override string ToString()
    {
      StringBuilder orderDescription = new();
      orderDescription.AppendLine("\nORDER SUMMARY:");
      orderDescription.Append("Order moment: ");
      orderDescription.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
      orderDescription.Append("Order status: ");
      orderDescription.AppendLine(OrderStatus.ToString());
      orderDescription.Append("Client: ");
      orderDescription.AppendLine(Client.ToString());
      orderDescription.AppendLine("Order items:");

      foreach (OrderItem orderItem in OrderItems)
      {
        orderDescription.AppendLine(orderItem.ToString());
      }

      string total = Total().ToString("0.00");
      orderDescription.Append("Total price: $");
      orderDescription.AppendLine(total);

      return orderDescription.ToString();
    }
  }
}