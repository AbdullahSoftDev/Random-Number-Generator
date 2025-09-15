using System;

public class RandomNumberGenerator
{
    public int GenerateNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Random Number Generator ---");
        Console.WriteLine("This program will generate a random number within a range you define.");

        RandomNumberGenerator generator = new RandomNumberGenerator();

        bool runAgain;
        do
        {
            Console.Write("\nEnter the minimum number: ");
            string minInput = Console.ReadLine();

            Console.Write("Enter the maximum number: ");
            string maxInput = Console.ReadLine();

            try
            {
                int minNumber = int.Parse(minInput);
                int maxNumber = int.Parse(maxInput);

                if (minNumber > maxNumber)
                {
                    Console.WriteLine("\nError: The minimum number cannot be greater than the maximum number.");
                }
                else
                {
                    int randomNumber = generator.GenerateNumber(minNumber, maxNumber);
                    Console.WriteLine($"\nYour random number is: {randomNumber}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nError: Invalid input. Please enter valid numbers.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nError: The number is too large or too small for this application.");
            }

            Console.Write("\nGenerate another number? (y/n): ");
            string choice = Console.ReadLine().ToLower();
            runAgain = (choice == "y");

        } while (runAgain);

        Console.WriteLine("\nThank you for using the Random Number Generator. Goodbye!");
    }
}