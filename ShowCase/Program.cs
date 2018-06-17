using System;
using UtilityLibraries;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;
        DisplayUsage();

        do
        {
            if (row == 0 || row >= 3)
                ResetConsole();
                

            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) break;
            Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
                              $"{(input.StartsWithUpper() ? "Yes" : "No")}\n");
            row += 3;
        } while (true);
        return;

        //Display program usage
        void DisplayUsage()
        {
            Console.WriteLine("\nThe program prompts the user to enter a string.It indicates whether the string starts with an uppercase character. \nIf the user presses the Enter key without entering a string, the application terminates, and the console window closes.");
            Console.WriteLine("\nWhenever it is greater than or equal to 3, the code clears the console window and displays a message to the user.");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        // Declare a ResetConsole local method
        void ResetConsole()
        {
            if (row > 0)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("\nPress <Enter> only to exit; otherwise, enter a string and press <Enter>:\n");
            row = 3;
        }
    }
}