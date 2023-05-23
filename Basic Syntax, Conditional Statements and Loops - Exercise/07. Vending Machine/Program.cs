namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double coinsCount = 0;
            double priceProduct = 0;

            
                while (input != "Start")
                {
                    double coins = double.Parse(input);

                    switch (coins)
                    {
                        case 0.1:
                        case 0.2:
                        case 0.5:
                        case 1:
                        case 2:
                            coinsCount += coins;
                            break;
                           
                        default:
                            Console.WriteLine($"Cannot accept {coins}");
                            break;
                    }
                    input = Console.ReadLine();
                }
                string products = Console.ReadLine();

            while (products != "End")
            { 

                switch (products)
                {
                    case "Nuts":
                        priceProduct = 2;

                        if (coinsCount >= priceProduct)
                        {
                            Console.WriteLine($"Purchased nuts");
                            coinsCount -= priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        products = Console.ReadLine();
                        break;
                    case "Water":
                        priceProduct = 0.7;

                        if (coinsCount >= priceProduct)
                        {
                            Console.WriteLine($"Purchased water");
                            coinsCount -= priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        products = Console.ReadLine();
                        break;
                    case "Crisps":
                        priceProduct = 1.5;

                        if (coinsCount >= priceProduct)
                        {
                            Console.WriteLine($"Purchased crisps");
                            coinsCount -= priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        products = Console.ReadLine();
                        break;
                    case "Soda":
                        priceProduct = 0.8;

                        if (coinsCount >= priceProduct)
                        {
                            Console.WriteLine("Purchased soda");
                            coinsCount -= priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        products = Console.ReadLine();
                        break;
                    case "Coke":
                        priceProduct = 1;

                        if (coinsCount >= priceProduct)
                        {
                            Console.WriteLine("Purchased coke");
                            coinsCount -= priceProduct;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }

                        products = Console.ReadLine();
                        continue;
                    default:
                        Console.WriteLine("Invalid product");

                        products = Console.ReadLine();
                        continue;
                }
            }
            Console.WriteLine($"Change: {coinsCount:f2}");
        }
    }
}