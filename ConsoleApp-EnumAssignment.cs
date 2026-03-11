using System;

namespace ParsingEnumsAssignment
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {
            bool isvalid = false;
            while (!isvalid)
            {
                string dayInput = "";
                try
                {
                    Console.WriteLine("Enter the current day of the week (Name or Number 1-7):");
                    dayInput = Console.ReadLine();

                    // 1. Check if the input is a NUMBER
                    if (int.TryParse(dayInput, out int dayNumber))
                    {
                        // Validate if the number is in the 1-7 range
                        if (Enum.IsDefined(typeof(DaysOfTheWeek), dayNumber))
                        {
                            DaysOfTheWeek day = (DaysOfTheWeek)dayNumber;
                            Console.WriteLine("Have a nice " + day);
                            isvalid = true;
                        }
                        else
                        {
                            // Throw exception for numbers like 0 or 99
                            throw new ArgumentException();
                        }
                    }
                    // 2. Check if the input is a STRING NAME
                    else
                    {
                        // Use true for case-insensitivity (handles "monday" or "Monday")
                        DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayInput, true);
                        Console.WriteLine("Have a nice " + day);
                        isvalid = true;
                    }
                }
                catch (Exception) // Catches ArgumentException from Parse or our manual throw
                {
                    Console.WriteLine($"Error: '{dayInput}' is not a valid day. Please use Monday-Sunday or 1-7.");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
