using ProductsDetails.Entities;

Console.Write("Enter the number of products: ");
int numberOfProducts = int.Parse(Console.ReadLine());

List<Product> products = [];

for (int product = 1; product <= numberOfProducts; product++)
{
  Console.WriteLine($"Product #{product} data:");
  Console.Write("Common, used or imported (c/u/i)? ");
  char option = char.Parse(Console.ReadLine());

  Console.Write("Name: ");
  string name = Console.ReadLine();
  Console.Write("Price: ");
  double price = double.Parse(Console.ReadLine());

  Product prod;

  switch (option)
  {
    case 'c':
      prod = new(name, price);
      products.Add(prod);
      break;
    case 'u':
      Console.Write("Manufacture date (DD/MM/YYYY): ");
      DateTime date = DateTime.Parse(Console.ReadLine());

      prod = new UsedProduct(name, price, date);
      products.Add(prod);
      break;
    case 'i':
      Console.Write("Customs fee: ");
      double fee = double.Parse(Console.ReadLine());

      prod = new ImportedProduct(name, price, fee);
      products.Add(prod);
      break;
    default:
      Console.WriteLine("Wrong option");
      break;
  }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");

foreach (Product product in products)
{
  Console.WriteLine(product.PriceTag());
}