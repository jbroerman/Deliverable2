/* Jacob Broerman
  1/23/23
  ISM4300
  Description: Condittional statements and try/catch grade example
 */

using System;

class Program
{
    static void Main()
    {
        

        try
        {
            // Ask the user for their numeric grade
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            int Grade = Convert.ToInt32(Console.ReadLine());


            // Check the numeric grade and assign a letter grade
            if (Grade >= 90)
            {
                Console.WriteLine("Your letter grade is: A");
            }
            else if (Grade >= 80)
            {
                Console.WriteLine("Your letter grade is: B");
            }
            else if (Grade >= 70)
            {
                Console.WriteLine("Your letter grade is: C");
            }
            else if (Grade >= 60)
            {
                Console.WriteLine("Your letter grade is: D");
            }
            else
            {
                Console.WriteLine("Your letter grade is: F");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}