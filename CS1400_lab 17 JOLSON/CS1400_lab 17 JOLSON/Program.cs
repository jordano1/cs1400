// Name: Jordan Olson
// CS 1400 Section x0
// Lab: 17
// Date: 7/3/2012 8:17:51 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

class Program
{
    static void Main()
    {
     //since this is a partially filled array I added another zero to increase the input.
     const int NUMBERS = 100;
     double[]arrayValue = new double[NUMBERS];
     //new variables to be declared, partially filled arrays remove for loops and add 
     //variables which allow us to stop them at a given point or continue until the array ends
     double userInput = 0;
     int arrayNumber = 0;
     //initiate the do loop.
     do
     {
     //showing the value of array before it's given a value from the user   
     Console.WriteLine("input a number {0} to end, type 0.", arrayNumber);
     //saving value as a variable
     userInput = double.Parse(Console.ReadLine());
     //if loop to initiate if user input is not = to 0, then continue with the array, if it does = 0, then we end
         if (userInput != 0)
         {
         arrayValue[arrayNumber] = userInput;
         //incrimentally increasing the count (because that is the array value.)
         arrayNumber++;
         }
     //while user input = 0, show the sum and end the program.
     } while (userInput != 0);
     Console.WriteLine("thank you. the sum of these numbers is {0}", ProductArray(arrayValue,arrayNumber));
     Console.ReadLine();
      
     }//end Main()
    //Multiply Array method
    //Purpose: add the inputs of the user together and shows the sum of those numbers.
    //Parameters:values of double type numbers
    //Returns: the sum of the values
    //Pre conditions: must have numeric values to move onto next input
    //Post conditions: must have met the pre conditions.
    static double ProductArray(double[] NUMBERS, int count)
    {
        double sum = 1;
        for (int i = 0; i < count; i++)
        //variable which stores the numbers multiplied.
        sum = sum * NUMBERS[i];
        //the return.
        return sum;
    }
}//End class Program