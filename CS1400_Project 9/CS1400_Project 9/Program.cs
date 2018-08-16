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
using System.IO;
class Program
{
    static void Main()
    {
        const int NUMBERS = 50;

        string input;

        string[] farenVelocityThree = new string[NUMBERS];
        string[] farenVelocityOne = new string[NUMBERS];
        string[] farenVelocityTwo = new string[NUMBERS];
        string fiveFourty = null;
        double tThree = 0.0;
        int vThree = 0;
        string fiveTwenty;
        double t = 0;
        double v = 0;
        string fiveThirty;
        int vTwo;
        double tTwo = 0.0;
        Console.WriteLine("Wind Chill Calculator\nJordan Olson\nCS 1400 - Project #9\n----------------------");

        Console.WriteLine("Enter a file name in My Documents: ");

        string environment = System.Environment.GetFolderPath
        (System.Environment.SpecialFolder.Personal) + "\\";
        input = Console.ReadLine();
        string path = environment + input;

        // now we can use the full path to get the document
        StreamReader myFile = new StreamReader(path);

        do
        {
            //fiveTwenty = first string
            fiveTwenty = myFile.ReadLine();

            // fiveThirty = second string
            fiveThirty = myFile.ReadLine();

            //fiveFourty = third string
            fiveFourty = myFile.ReadLine();

            // if fiveFourty does not equal null, then go through the loop
            if (fiveFourty != null)
            {
                //splitting
                farenVelocityOne = fiveTwenty.Split();



                //here is the value of temperature, which is five.
                t = double.Parse(farenVelocityOne[0]);

                //here is the value of velocity, which is twenty.
                v = double.Parse(farenVelocityOne[1]);

                //Equation for the wind chill factor.
                double W = (35.74 + (0.6215 * t)) + (-35.75 * (Math.Pow(v, 0.16)) + (0.4275 * t) * ((Math.Pow(v, 0.16))));

                //here is where the values are represented.
                Console.WriteLine("Temp in degrees = {0}\nwind velocity = {1}\nwind chill factor = {2:f2}", t, v, W);

                //splitting
                farenVelocityTwo = fiveThirty.Split();
                //giving first value in string
                tTwo = double.Parse(farenVelocityTwo[0]);
                //giving second value in string
                vTwo = int.Parse(farenVelocityTwo[1]);

                double wTwo = (35.74 + (0.6215 * tTwo)) + (-35.75 * (Math.Pow(vTwo, 0.16)) + (0.4275 * tTwo) * ((Math.Pow(vTwo, 0.16))));
                Console.WriteLine("Temp in degrees = {0}\nwind velocity = {1}\nwind chill factor = {2:f2}", tTwo, vTwo, wTwo);
                // splitting
                farenVelocityThree = fiveFourty.Split();
                //tThree = the double since it is being first read, stored in the zeroth of the array.
                tThree = double.Parse(farenVelocityThree[0]);

                //vThree  = integer stored in the first of the array
                vThree = int.Parse(farenVelocityThree[1]);
                double wThree = (35.74 + (0.6215 * tThree)) + (-35.75 * (Math.Pow(vThree, 0.16)) + (0.4275 * tThree) * ((Math.Pow(vThree, 0.16))));
                Console.WriteLine("Temp in degrees = {0}\nwind velocity = {1}\nwind chill factor = {2:f2}", tThree, vThree, wThree);
                //formula multiplying the vThree and the tThree together

            }
            // if there's a name but no values for the name then print out 
            // the name and 0 for the tThree

            // Parse each element of the array into the correct data type
        } while (fiveTwenty != null || fiveFourty != null);

        Console.ReadLine();
    }//end main

}//end class program