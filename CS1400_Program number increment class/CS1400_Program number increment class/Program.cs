// File Prologue
// Name: Jordan Olson
// CS 1400 Section xxx
// Lab: 10
// Date: 6/8/2012 8:17:51 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;

static class Program
{
    static void Main()
    {
        string userInput;
        do
        {
        Console.WriteLine("input number");
        int usernumput = int.Parse(Console.ReadLine());
        Console.WriteLine("thank you");
        Counting myCounting = new Counting();
        myCounting.increaseNumbers(1);
        Console.WriteLine("{0}", myCounting.returnNumbers());
        Console.WriteLine("again? y/n");
        userInput = Console.ReadLine();
       
        }while(userInput == "y" || userInput == "Y");
        Console.ReadLine();
    }
}

    class Counting
    {
        private int counted = 0;
        private int increase = 0;
        private int decrease = 0;
        private int zero = 0;
        private int countingNumbers = 0;

        public Counting()
        {
            countingNumbers = 0;
        }
        public Counting(int a)
        {
            countingNumbers = a;
        }

        public void increaseNumbers(int j)
        {
            countingNumbers += j + increase++;
        }
        public void decreaseNumbers(int d)
        {
            countingNumbers += d + decrease--;
        }
        public int returnNumbers()
        {
            return countingNumbers;
        }
    }


