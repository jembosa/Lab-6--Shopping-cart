namespace Lab_6__Shopping_cart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>
        {
            { "Banana", 0.99M },
            { "Apple", 1.99M },
            { "Carrot", 2.99M },
            { "Lettuce", 3.99M },
            { "Tomato", 4.99M },
            { "Steak", 5.99M },
            { "Pear", 6.99M },
            { "Avocado", 7.99M }
        };

            List<string> shoppingcart = new List<string>();

            do
            {
                Console.WriteLine("Menu:");
                foreach (var item in menu)
                {
                    Console.WriteLine($"{item.Key} - ${item.Value}");
                }

                Console.WriteLine("Enter an item name or 'quit' to finish: ");
                string userinput = Console.ReadLine();

                if (userinput.ToLower() == "quit")
                {
                    break;
                }
                if (menu.ContainsKey(userinput))
                {
                    shoppingcart.Add(userinput);
                    Console.WriteLine($"{userinput} - ${menu[userinput]} added to your cart!");
                }
                else
                {
                    Console.WriteLine("Sorry, item not found, please try again");
                }

                Console.WriteLine("Do you want to add another item? y/n");
            }

            while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("\nYour Shopping Cart:");
            Console.WriteLine("Item Name\tPrice");
            decimal total = 0;

            foreach (var item in shoppingcart)
            {
                decimal price = menu[item];
                Console.WriteLine($"{item}\t\t${price}");
                total += price;
            }

            Console.WriteLine("\nTotal Price: $" + total.ToString("0.00"));
        }
    }
}








