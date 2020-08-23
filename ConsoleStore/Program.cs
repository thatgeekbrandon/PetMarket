using System;

namespace ConsoleStore
{
    class Program
    {
        static string Ask(string question)
        {
            Console.WriteLine(question + "");
            return Console.ReadLine();
        }

        static double Price(int quantity)
        {
            double pricePerUnit;
            if (quantity >= 100)
            {
                pricePerUnit = 1.5;
            }
            else if (quantity >= 50)
            {
                pricePerUnit = 1.75;
            }
            else
            {
                pricePerUnit = 2;
            }

            return quantity * pricePerUnit;
        }

        static void Main(string[] args)
        {
            string CatFood = "Cat Food";
            string DogFood = "Dog Food";
            string BirdFood = "Bird Food";
            string LizardFood = "Lizard Food";

            Console.WriteLine("\nWelcome To PetMarket\n\n");

            var foodType = Ask("PRODUCTS:\n" + $"{CatFood}\n" + $"{DogFood}\n" + $"{BirdFood}\n" + $"{LizardFood}\n\n" + "What would you like to buy?  ");

            //Cat Food
            if (foodType == CatFood)
            {
                string quantity = Ask("\nHow many cans of cat food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} cans, your total is ${total}");
            }
            else if (foodType == "cat food")
            {
                string quantity = Ask("\nHow many cans of cat food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} cans, your total is ${total}");
            }
            else if (foodType == "Cat food")
            {
                string quantity = Ask("\nHow many cans of cat food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} cans, your total is ${total}");
            }
            else if (foodType == "cat Food")
            {
                string quantity = Ask("\nHow many cans of cat food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} cans, your total is ${total}");
            }

            //Dog Food
            if (foodType == DogFood)
            {
                string quantity = Ask("\nHow many cans of dog food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} cans, your total is ${total}");
            }
            else if (foodType == "dog food")
            {
                string quantity = Ask("\nHow many cans of dog food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} cans, your total is ${total}");
            }
            else if (foodType == "Dog food")
            {
                string quantity = Ask("\nHow many cans of dog food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} cans, your total is ${total}");
            }
            else if (foodType == "dog Food")
            {
                string quantity = Ask("\nHow many cans of dog food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} cans, your total is ${total}");
            }

            //Bird Food
            if (foodType == BirdFood)
            {
                string quantity = Ask("\nHow many bags of bird food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} bags, your total is ${total}");
            }
            else if (foodType == "bird food")
            {
                string quantity = Ask("\nHow many bags of bird food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} bags, your total is ${total}");
            }
            else if (foodType == "Bird food")
            {
                string quantity = Ask("\nHow many bags of bird food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} bags, your total is ${total}");
            }
            else if (foodType == "bird Food")
            {
                string quantity = Ask("\nHow many bags of bird food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} bags, your total is ${total}");
            }

            //Lizard Food
            if (foodType == LizardFood)
            {
                string quantity = Ask("\nHow many jars of lizard food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} jars, your total is ${total}");
            }
            else if (foodType == "lizard food")
            {
                string quantity = Ask("\nHow many jars of lizard food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} jars, your total is ${total}");
            }
            else if (foodType == "Lizard food")
            {
                string quantity = Ask("\nHow many jars of lizard food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} jars, your total is ${total}");
            }
            else if (foodType == "lizard Food")
            {
                string quantity = Ask("\nHow many jars of lizard food would you like to buy?\n");
                int number = int.Parse(quantity);
                double total = Price(number);
                Console.WriteLine($"\nFor {quantity} jars, your total is ${total}");
            }
        }
    }
}
