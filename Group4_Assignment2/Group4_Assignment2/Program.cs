using System;

namespace Group4_Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1000, "Mouse", 80, 100);
            bool continueProgram = true;

            while (continueProgram)
            {
                DisplayMenu();

                string userChoice = GetUserInput("Enter your option:");

                switch (userChoice)
                {
                    case "1":
                        IncreaseStock(product);
                        break;
                    case "2":
                        DecreaseStock(product);
                        break;
                    case "3":
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Stock Increase");
            Console.WriteLine("2. Stock Decrease");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
        }

        static void IncreaseStock(Product product)
        {
            int increment = GetIntegerFromConsole("Enter the amount to increase the stock: ");
            product.StockIncrease(increment);
            Console.WriteLine($"Stock increased by {increment}. New stock: {product.Stock}\n");
        }

        static void DecreaseStock(Product product)
        {
            int decrement = GetIntegerFromConsole("Enter the amount to decrease the stock: ");
            if (product.Stock >= decrement)
            {
                product.StockDecrease(decrement);
                Console.WriteLine($"Stock decreased by {decrement}. New stock: {product.Stock}\n");
            }
            else
            {
                Console.WriteLine($"Insufficient stock. Current stock: {product.Stock}\n");
            }
        }

        static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine().Trim();
        }

        static int GetIntegerFromConsole(string message)
        {
            Console.Write(message);
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please provide a valid integer input.");
                Console.Write(message);
            }
            return userInput;
        }
    }
}