// See https://aka.ms/new-console-template for more information
using System.Net.Quic;
using System.Runtime.InteropServices.Marshalling;
using WeaklyMiniProject2;


//List<Product> products = new List<Product>();
ProductList products = new ProductList();

/*
while (true)
{
Console.WriteLine("Add new product? y/n");
string newProduct = Console.ReadLine();
if (newProduct.Trim().ToLower() == "y")
{
    Console.WriteLine("Enter the name of the product:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter the category:");
    string category = Console.ReadLine();
    Console.WriteLine("Enter the price in SEK:");
    string pricestring = Console.ReadLine();
    float price = float.Parse(pricestring);

    Product product = new Product(name, category, price);
    products.Add(product);
} else if (newProduct.Trim().ToLower() == "q") {
    break;
}

}*/

start:
do
{

    Console.WriteLine("Enter the name of the product:");
    string name = Console.ReadLine();
    Console.WriteLine("Enter the category:");
    string category = Console.ReadLine();
    Console.WriteLine("Enter the price in SEK:");
    string pricestring = Console.ReadLine();
    float price = float.Parse(pricestring);

    Product product = new Product(name, category, price);
    products.Add(product);
    if (Console.ReadLine().Trim().ToLower() == "q")
    {
        break;
    }


} while (true);

/*
for(int i = 0; i < products.LastIndex; i++)
{
    Console.WriteLine(products._elements[i].ToString());
}*/


foreach (Product product in products.OrderBy(x=>x.Price)) {
    Console.WriteLine(product.ToString());
}
Console.WriteLine("Total:".PadRight(40) + products.Sum(x => x.Price));

Console.WriteLine("To search enter 's'. Press enter to proceed.");
if (Console.ReadLine().Trim().ToLower() == "s")
{
    string search = Console.ReadLine();

    foreach (Product product in products.OrderBy(x => x.Price))
    {
        if (product.Name == search)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(product);
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine(product);
        }
    }
}

quit:
    Console.WriteLine("Enter more products? y/n");
    string answer = Console.ReadLine().Trim().ToLower();

    if (answer == "y")
    {
        goto start;
    }
    else if (answer == "n")
    {
        System.Environment.Exit(1);
    }
    else
    {
        Console.WriteLine("Only y/n are accepted answers.");
        goto quit;
    }








