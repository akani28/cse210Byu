using System;

class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();
        Order order = new Order(customer);
        Product keyboard = new Product("Mechanic logitech", "001", 60.00f);
        Product mouse = new Product("mouse logitech", "002", 20.00f);
        Product laptop = new Product("Asus vivobook", "003", 1500.00f);
        Console.WriteLine("Hello, welcome, we are Akani Dragons company.");
        Console.WriteLine($"{Environment.NewLine}");
        string input = "";
        while (input != "5")
        {

            Console.WriteLine("Avalible products:");
            Console.WriteLine("  1. keyboard");
            Console.WriteLine("  2. Mouse");
            Console.WriteLine("  3. Laptop");
            Console.WriteLine("  4. generate shipping label");
            Console.WriteLine("  5.Quit");
            Console.Write("What product do you want to carry? ");
            input = Console.ReadLine();
            if (input == "1")
            {
                keyboard.DetailsProduct();
                Console.Write($"How many {keyboard.GetName()} do you want to carry? ");
                input = Console.ReadLine();
                keyboard.SetAmount(int.Parse(input));
                keyboard.TotalCost();
                order.SetProducts(keyboard);

            }
            else if (input == "2")
            {
                mouse.DetailsProduct();
                Console.Write($"How many {mouse.GetName()} do you want to carry? ");
                input = Console.ReadLine();
                mouse.SetAmount(int.Parse(input));
                mouse.TotalCost();
                order.SetProducts(mouse);

            }
            else if (input == "3")
            {
                laptop.DetailsProduct();
                Console.Write($"How many {laptop.GetName()} do you want to carry? ");
                input = Console.ReadLine();
                laptop.SetAmount(int.Parse(input));
                laptop.TotalCost();
                order.SetProducts(laptop);

            }
            //Console.WriteLine("Help me with the following information for the order: ");
            //Console.Write("you name is: ");
            //string nameCustomer = Console.ReadLine();
            //customer.SetName(nameCustomer);
            //customer.SetAddress();

            else if (input == "4")
            {
                Console.WriteLine("Help me with the following information for the order: ");
                Console.Write("you name is: ");
                string nameCustomer = Console.ReadLine();
                customer.SetName(nameCustomer);
                customer.SetAddress();
                Console.Clear();
                Console.WriteLine("----------Shipping label--------");
                Console.WriteLine($"name: {customer.GetName()}");
                Console.WriteLine($"address: {customer.GetAddress().ShowAddress()}");
                float cost = 0;
                foreach (Product product in order.GetProducts())
                {
                    product.DetailsProduct();
                    cost = cost + product.TotalCost();

                }
                if (customer.GetAddress().LocationUE())
                {
                    Console.WriteLine($"Shipping Cost: 5.00$");
                    Console.WriteLine($"you must pay: {cost+5.00f}$");
                }else
                {
                    Console.WriteLine($"Shipping Cost: 35.00$");
                    Console.WriteLine($"you must pay: {cost+35.00f}$");

                }
                input = "5";
            }


        }

    }
}