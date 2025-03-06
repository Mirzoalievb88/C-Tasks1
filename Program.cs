using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        double deposit = Convert.ToDouble(input);

        double interestRate = 0;

        if (deposit < 100)
        {
            interestRate = 0.05;
        }
        else if (deposit <= 200)
        {
            interestRate = 0.07;
        }
        else
        {
            interestRate = 0.10;
        }

        double interest = deposit * interestRate;
        double totalAmount = deposit + interest;
 
        Console.WriteLine(totalAmount);
    }
}