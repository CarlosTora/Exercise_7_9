/*Carlos Torá Giner
 *This program calculates the average of a set of marks
 * until the user types "finish"*/

using System;
public class Average
{
    public static void Main()
    {
        double sum = 0, number, divider = 0, average;
        string userNumber;
        Console.WriteLine("Insert one mark ( Insert \"finish\" to exit)");
        Console.WriteLine(); 
        Console.Write("Insert a mark: ");
        userNumber = Console.ReadLine();
        while (userNumber != "finish")
        {  
            number = Convert.ToDouble(userNumber);
            divider++;   
            sum += number;  
            Console.Write("Insert a mark: ");
            userNumber = Console.ReadLine();
        }
        if (divider != 0)
        {
            average = sum / divider;  
            Console.WriteLine("The average is {0}.", average);
        }
    }
}
