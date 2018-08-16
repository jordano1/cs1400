// File Prologue
// Name: Jordan Olson
// CS 1400 Section xxx
// Lab: 25
// Date: 6/8/2012 8:17:51 AM
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
        
       
            const int SIZE = 5;
            Integer[] numbers = new Integer[SIZE];
            Integer myInt = new Integer();
            numbers[0] = new Integer(1);
            numbers[1] = new Integer(2);
            numbers[2]= new Integer(3);
            numbers[3] = new Integer(4);
            numbers[4] = new Integer(5);

            do
            {
                for (int i = 1; i < SIZE; i++)
                {
                    Console.WriteLine("{0}",numbers[i].GetValue());
                }
            } while (SIZE <= 4);
            Console.ReadLine();
        }
    }


    class Integer
    {
        // the data member is just the value of the integer
        private int value;

        // Default Constructor
        // Purpose: Initialize the value of the integer to zero
        // Parameters: none
        // Returns: none
        public Integer()
        {
            value = 0;
        }

        // Parameterized Constructor
        // Purpose: Initialize the value of the integer to the parameter
        // Parameters: an integer
        // Returns: none
        public Integer(int n)
        {
            value = n;
        }

        // GetValue method
        // Purpose: to get the value of the integer object
        // Parameters: None
        // Returns: the value
        public int GetValue()
        {
            return value;
        }
    }
