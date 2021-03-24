using System;
using System.Collections. Generic;
using System.Collections;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // to keep track of the orders
            Dictionary<string, double> cart = new Dictionary<string, double>();
            //To keep track of the menu
            Dictionary<string, double> fruit = new Dictionary<string, double>();
                fruit.Add("apple", 0.89);
                fruit.Add("orange", 1.89);
                fruit.Add("watermelon", 2.89);
                fruit.Add("honeydew", 1.89);
                fruit.Add("strawberry", 2.99);
                fruit.Add("banana", 0.29);
                fruit.Add("grape", 1.89);
            Console.WriteLine("Welcome to my Fruit Market");
            do
            {
                Console.WriteLine("\nItem\tPrice");
                Console.WriteLine("================");
                foreach (var fruits in fruit)
                {
                    Console.WriteLine($"{fruits.Key} {fruits.Value}");
                }
                    Console.WriteLine("\nWhat item would you like to order?");
                    string userInput = Console.ReadLine();
                //switch statement to compare input
                    switch (userInput)
                    {
                        case "apple":
                            Console.WriteLine($"Adding apples to your cart at " + fruit["apple"]);
                            cart.Add("apple", 0.89);
                            break;
                        case "orange":
                            Console.WriteLine($"Adding oranges to your cart at " + fruit["orange"]);
                            cart.Add("orange", 1.89);
                            break;
                        case "watermelon":
                            Console.WriteLine($"Adding watermelon to your cart at " + fruit["watermelon"]);
                            cart.Add("watermelon", 2.89);
                            break;
                        case "honeydew":
                            Console.WriteLine($"Adding honeydew to your cart at " + fruit["honeydew"]);
                            cart.Add("honeydew", 1.89);
                            break;
                        case "strawberry":
                            Console.WriteLine($"Adding strawberries to your cart at " + fruit["strawberry"]);
                            cart.Add("strawberry", 2.99);
                            break;
                        case "banana":
                            Console.WriteLine($"Adding bananas to your cart at " + fruit["banana"]);
                            cart.Add("banana", .29);
                            break;
                        case "grape":
                            Console.WriteLine($"Adding grapes to your cart at " + fruit["grape"]);
                            cart.Add("grape", 1.89);
                            break;
                        default:
                            Console.WriteLine("That is NOT an option. Please try again.");
                            break;
                }
                
                Console.Write("\nWould you like to order anything else? (y/n): ");
                string choice = Console.ReadLine();
                if (choice == "n")
                {
                    Console.Write("Thanks for your order!\n");
                    Console.Write("Here's what you got: \n");
                    double total = 0;
                    // for every fruit in the cart
                    foreach (var fruits in cart)
                    {
                        // printing to the console
                        Console.WriteLine($"{fruits.Key,-15} ${fruits.Value,-10}");
                        // adding the fruit values
                        total += fruits.Value;
                    }
                    // printing the average
                    Console.WriteLine("Average price per item in order was {0}", (total / cart.Count));

                }
                else if (choice == "y")
                {
                    Console.WriteLine();
                    continue;
                }
                break;
            }
            while (true);
            





        }
    }
}
