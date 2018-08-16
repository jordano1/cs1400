      // Sample Program To Illustrate Debugger
// Calculates the gross pay for a Sales
// If a person's sales exceed $40,000 in one month, then their commission will be ten percent 
// of their sales for that month. If their sales is less than $25,000 then their commission
// is three percent of their sales for the month. Otherwise, their commission will be five
// percent of their sales for the month. Their gross pay is equal to a base salary of
// $1,000 each month plus their commission.

using System;

class Program
{
    // declare constants - no magic numbers
    const int BIG = 40000;
    const int SMALL = 25000;
    //changed the bonus to decimals (percentages) and changed the small bonus to a double.
    const double BIG_BONUS = .10;
    //this is to be 3%.
    const double SMALL_BONUS = .03; //5. the assignment calls for less than to be "three percent"
    //added a constant for what is between what qualifies as a big and small bonus
    const double BETWEEN_BONUS = .05;

    static void Main()
    {
        Console.WriteLine("Jordan Olson, CS1400-xo");
        //initialized variables
        double sales = 0;
        double salary = 1000.0;
        double commission = 0;
        //declaring pay as a double to avoid conversions
        double pay = 0;
        char response = 'y';
        
        do
        {
            Console.Write("Please enter the person's Sales: ");
            sales = double.Parse(Console.ReadLine());
            //if the sales is greater than 40,000, then initiate the if statement
            if (sales > BIG)
            {
                //commission was capitalized so it wasn't working. I lowercased it
                commission = sales * BIG_BONUS;
            }
            else if (sales < SMALL) //if sales is less than 25000, then initiate this if statment
            {
                //add semicolon to end statement
                commission = sales * SMALL_BONUS;
            }//if sales is greater than or equal to 25000 and less than or equal to 40000, then initiate this statement
             // (it wouldn't be fair to not give people bonuses that made 25000 or 40000)
            else if (sales >= SMALL && sales <= BIG) 
            {
                commission = sales * BETWEEN_BONUS;
            }

            pay = salary + commission;
            Console.WriteLine("This person's gross pay will be {0}", pay);
            Console.Write("Do you want to do another (y or n)? ");
            response = char.Parse(Console.ReadLine());
            //change the do while from != to == so it repeats after user input is y, else end.
        } while (response == 'y');

        Console.WriteLine("Thanks ... goodbye");
        Console.ReadLine();
    }
}