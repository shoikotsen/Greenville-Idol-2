using System;

public class Calculate
{
    // Method to get the display message for the menu and the motto
    public string GetDisplayMessage()
    {
        string w1 = "*********************************\n";
        string w2 = "* The stars shine in Greenville. *\n";
        string w3 = "*********************************\n";
        string w4 = "Please Enter the following number below from the following menu:\n\n";
        string w5 = "1. CALCULATE Greenville Revenue Year-Over-Year\n";
        string w6 = "2. Exit\n";

        // Return the concatenated message
        return w1 + w2 + w3 + w4 + w5 + w6;
    }

    // Method to get a sample message about the competition
    public string GetMessage()
    {
        string s1 = "Last year's competition had 122 contestants, and this year's has 426 contestants\n";
        string s2 = "Revenue expected this year is $10,650\n";
        string s3 = "It is true that this year's competition is bigger than last year's.\n";

        // Return the concatenated message
        return s1 + s2 + s3;
    }
    // Method to calculate and display revenue based on the number of contestants and ticket price
    public void CalculateRevenue(int previousYearContestants, int currentYearContestants, int ticketPrice = 25)
    {
        // Calculate expected revenue for the current year
        int expectedRevenue = currentYearContestants * ticketPrice;

        // Display the number of contestants for the previous and current years
        Console.WriteLine($"Last year's competition had {previousYearContestants} contestants, " +
                          $"and this year's has {currentYearContestants} contestants.");

        // Display the expected revenue
        Console.WriteLine($"Revenue expected this year is ${expectedRevenue}");
        // Compare the number of contestants and display appropriate message
        if (currentYearContestants >= previousYearContestants * 2)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (currentYearContestants > previousYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else if (currentYearContestants < previousYearContestants)
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
        else
        {
            Console.WriteLine("The competition is the same size as last year.");
        }
    }
}

//2024/07/21_SenShoikot_GreenvilleRevenue v0.3 