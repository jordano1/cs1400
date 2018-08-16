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
        const int TOKENS = 10;
        TokenGiver myTokenGiver = new TokenGiver();//declare the token giver
        myTokenGiver.AddTokens(TOKENS);
        Console.WriteLine("inserted ten tokens: {0}", myTokenGiver.GetNumTokens());
        myTokenGiver.TakeToken();//minus 1 token
        myTokenGiver.TakeToken();//minus 1 token
        Console.WriteLine("taking out two tokens: {0}", myTokenGiver.GetNumTokens());
        Console.ReadLine();
    }
}
        // The TokenGiver class
// Models a machine that dispenses tokens
class TokenGiver
{
   private int numTokens;

   // The Default Constructor
   // Purpose: initialize the number of tokens to zero
   // Parameters: none
   // Returns: none
   public TokenGiver( )
   {
      numTokens = 0;
   }

   // The Parameterized Constructor
   // Purpose: initializes the number of tokens
   // Parameters: an integer, the initial number of tokens
   // Returns: none
   public TokenGiver(int t)
   {
      numTokens = t;
   }

   // The AddTokens method
   // Purpose: add tokens to the tokengiver object
   // Parameters: an integer, the number of tokens to add
   // Returns: none
   public void AddTokens( int n )
   {
      numTokens += n;
   }

   // The TakeToken method
   // Purpose: takes a token from the tokengiver object
   // Parameters: none
   // Returns: none
   public void TakeToken( )
   {
   numTokens--;
   }

   // The GetNumTokens method
   // Purpose: returns the number of tokens in the object
   // Parameters: none
   // Returns: an integer, the number of tokens in the object
   public int GetNumTokens( )
   {
      return numTokens;
   }
}//tokenGiver end

