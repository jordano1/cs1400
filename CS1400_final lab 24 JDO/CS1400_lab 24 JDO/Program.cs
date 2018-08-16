// File Prologue
// Name: Jordan Olson
// CS 1400 Section xxx
// Lab: 24
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
        //giving CoinPurse a reference
        CoinPurse myCoinPurse = new CoinPurse();
        //showing that we have nothing in the coin purse
        Console.WriteLine("we have nothing in the coin purse: {0:f2}", myCoinPurse.totalCoins());
        //adding 3 pennies into the coin purse
        myCoinPurse.addPennies(3);
        //showing the resulting amount of money in the coin purse
        Console.WriteLine("here we added three pennies; {0:f2}", myCoinPurse.totalCoins());
        //adding 4 nickles into the coin purse
        myCoinPurse.addNickles(4);
        //showing that we added 4 nickles into the coin purse
        Console.WriteLine("here we add four nickles on top of the three pennies: {0:f2}", myCoinPurse.totalCoins());
        //adding 2 dimes into the coin purse
        myCoinPurse.addDimes(2);
        //showing that we added 2 coins into the purse
        Console.WriteLine("here are the two added dimes: {0:f2}", myCoinPurse.totalCoins());
        //adding a quarter
        myCoinPurse.addQuarters(1);
        //showing that we added the quarter
        Console.WriteLine("here we add a quarter: {0:f2}", myCoinPurse.totalCoins());
        //taking 20 cents out of the total in the coin purse
        myCoinPurse.takeDimes(2);
        //showing that we took 20 cents out of the coin purse
        Console.WriteLine("here we take two dimes out, or twenty cents. {0:f2}", myCoinPurse.totalCoins());
        myCoinPurse.emptyCoins(0);
        Console.WriteLine("here we empty the coin purse into something less \nfeminine like a satchel or a batman piggy bank: {0}",myCoinPurse.totalCoins());
        myCoinPurse.addQuarters(5);
        Console.WriteLine("{0}",myCoinPurse.totalCoins());
        Console.ReadLine();
    }//end main
}//end class


//the CoinPurse class
//purse that holds change
class CoinPurse
{
    //private variables we don't want to change or be affected.
    private double numPennies = .01;
    private double numNickles = .05;
    private double numDimes = .10;
    private double numQuarters = .25;
    private double totalCoinPurse = 0.0;

    //public CoinPurse default constructor
    //purpose: set value as zero
    //no parameters
    //no returns
    public CoinPurse()
    {
        totalCoinPurse = 0.0;
    }
    // parameterized constructor
    //purpose: stores values in a, initializing them
    //paramaters: int, a
    //returns: none
    public CoinPurse(int a)
    {
        totalCoinPurse = a;
    }
    //addPennies method
    //purpose: adds a penny
    // parameters int, p
    //returns: 0
    public void addPennies(int p)
    {
        totalCoinPurse += p * numPennies;
    }
    //addNickles method
    //purpose: adds a nickle
    //paramaters: int, n
    // returns: 0
    public void addNickles(int n)
    {
        totalCoinPurse += n * numNickles;

    }
    //addDimes method
    //purpose: adds a dime
    //parameters: int, d
    //returns: none
    public void addDimes(int d)
    {
        totalCoinPurse += d * numDimes;
    }
    //addQuarters method
    //purpose: adds a quarter
    //parameters: int, q
    //returns: none
    public void addQuarters(int q)
    {
        totalCoinPurse += q * numQuarters;
    }
    /// emptyCoins method
    /// purpose: empties the coins accumulated (returns value to 0)
    /// parameters: int, e
    /// returns: none
    public void emptyCoins(int e)
    {
        totalCoinPurse = 0;
    }
    //takePennies method
    //purpose: subtracts a penny
    //parameters: int, minusP
    //returns: none
    public void takePennies(int minusP)
    {
        totalCoinPurse -= minusP * numPennies;
    }

    //takeNickles method
    //purpose: subtracts a Nickle
    //parameters: int, minusN
    //returns: none
    public void takeNickles(int minusN)
    {
        totalCoinPurse -= minusN * numNickles;
    }

    //takeDimes method
    //purpose: subtracts a dime
    //parameters: int, minusD
    //returns: none
    public void takeDimes(int minusD)
    {
        totalCoinPurse -= minusD * numDimes;
    }
    //takeQuarters method
    //purpose: subtracts a quarter
    //parameters: int, minusQ
    //returns: none
    public void takeQuarters(int minusQ)
    {
        totalCoinPurse -= minusQ * numQuarters;
    }
    //totalCoins method
    //purpose: shows the total coins
    //parameters: none
    //returns: totalCoinPurse;
    public double totalCoins()
    {
        return totalCoinPurse;
    }
}
