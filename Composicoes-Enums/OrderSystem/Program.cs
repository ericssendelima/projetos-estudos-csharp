using OrderSystem.Entities;
using OrderSystem.Enums;

Console.WriteLine("Enter client data:");
Console.Write("Name: ");
string clientName = Console.ReadLine();

Console.Write("Email: ");
string clientEmail = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDateClient = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter order data:");
Console.Write("Status: ");
OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());

Client client = new(name: clientName, email: clientEmail, birthDate: birthDateClient);
Order order = new(client: client, orderStatus: orderStatus);

Console.Write("How many items to this order? ");
int quantityItems = int.Parse(Console.ReadLine());

for (int item = 1; item <= quantityItems; item++)
{
  Console.WriteLine($"Enter #{item} item data:");
  Console.Write("Product name: ");
  string productName = Console.ReadLine();
  Console.Write("Product price: ");
  double productPrice = double.Parse(Console.ReadLine());
  Console.Write("Quantity: ");
  int productQuantity = int.Parse(Console.ReadLine());

  Product product = new(name: productName, price: productPrice);
  OrderItem orderItem = new(quantity: productQuantity, product: product, price: product.Price);

  order.AddItem(orderItem);
}

Console.WriteLine(order);


