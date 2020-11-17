/*Carlos Torá Giner
 *calculates how many numbers of 1, 2, 3 or more digits are
 *entered by the user until he/she types “end” */
using System;

class digits
{
    static void Main()
    {
        int oneDigits = 0, twoDigits = 0, threeDigits = 0, moreDigits = 0;
        Console.WriteLine("Insert a number ( \"end\" to exit): ");
        string userNumber = Console.ReadLine();
        while (userNumber != "end")
        {
            int input = Convert.ToInt32(userNumber);
            if (input != 0)
            {
                if (input / 10 == 0)
                    oneDigits++;
                else
                if (input / 100 == 0)
                    twoDigits++;  // the number has 2 digits
                else
                 if (input / 1000 == 0)
                    threeDigits++;  // the number has 3 digits
                else
                    moreDigits++;  // the number has more than 3 digits
            }
            userNumber = Console.ReadLine();
        }
        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", 
            oneDigits, twoDigits, threeDigits, moreDigits);
    }
}

