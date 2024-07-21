using System;

class Program
{
    static void Main(string[] args)
    {
        Calculate calculate = new Calculate();

        DisplayMotto();
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                int previousYearContestants = GetValidContestantNumber("Enter the number of contestants from the previous year: ");
                int currentYearContestants = GetValidContestantNumber("Enter the number of contestants for the current year: ");

                calculate.CalculateRevenue(previousYearContestants, currentYearContestants);
                DisplayMotto();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice, please select again.");
            }
        }
    }

    static void DisplayMotto()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("* The stars shine in Greenville. *");
        Console.WriteLine("*********************************");
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease Enter the following number below from the following menu:");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }

    static int GetValidContestantNumber(string prompt)
    {
        int number;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 30)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
        }
        return number;
    }
}

2024/07/21_SenShoikot_GreenvilleRevenue v0.3 