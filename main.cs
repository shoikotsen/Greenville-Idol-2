using System;

class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
         // Create an instance of the Calculate class
        Calculate calculate = new Calculate();
        // Display the program's motto
        DisplayMotto();
        // Start an infinite loop to continuously display the menu and process user input
        while (true)
        {
            // Display the main menu
            DisplayMenu();
            // Get the user's choice from the menu
            string choice = Console.ReadLine();
            // Process the user's choice
            if (choice == "1")
            {
                // Get the number of contestants from the previous year
                int previousYearContestants = GetValidContestantNumber("Enter the number of contestants from the previous year: ");
                // Get the number of contestants for the current year
                int currentYearContestants = GetValidContestantNumber("Enter the number of contestants for the current year: ");

                // Calculate and display the revenue based on the contestant numbers
                calculate.CalculateRevenue(previousYearContestants, currentYearContestants);
                // Display the program's motto again
                DisplayMotto();
            }
            else if (choice == "2")
            {
                // Exit the program with a goodbye message
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                break;   // Exit the loop, thus ending the program
            }
            else
            {
                // Inform the user of an invalid choice and prompt them to try again
                Console.WriteLine("Invalid choice, please select again.");
            }
        }
    }

    // Method to display the program's motto
    static void DisplayMotto()
    {
        Console.WriteLine("*********************************");
        Console.WriteLine("* The stars shine in Greenville. *");
        Console.WriteLine("*********************************");
    }

    // Method to display the main menu
    static void DisplayMenu()
    {
        Console.WriteLine("\nPlease Enter the following number below from the following menu:");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }

    // Method to get a valid contestant number from the user
    static int GetValidContestantNumber(string prompt)
    {
        int number;
        while (true)
        {
            // Prompt the user for input
            Console.Write(prompt);
            // Try to parse the input as an integer and check if it is within the valid range
            if (int.TryParse(Console.ReadLine(), out number) && number >= 0 && number <= 30)
            {
                break;  // Exit the loop if the input is valid
            }
            // Inform the user of invalid input and prompt them to try again
            Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
        }
        // Return the valid contestant number
        return number;
    }
}

//2024/07/21_SenShoikot_GreenvilleRevenue v0.3 