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

class Program
{
    static void Main()
    {
        //create box object and use setters
        box mybox = new box();
        mybox.setHeight(4);
        mybox.setLength(3);
        mybox.setWidth(2);
        //use getters
        Console.WriteLine(mybox.getHeight());
        Console.WriteLine(mybox.getLength());
        Console.WriteLine(mybox.getWidth());
        Console.WriteLine(mybox.calcVolume());
        Console.ReadLine();
    }
}
class box
{
    private int length;
    private int width;
    private int height;


    public box()
    {
        length = 0;
        width = 0;
        height = 0;
    }
    public box(int l1, int w1, int h1)
    {
        length = l1;
        width = w1;
        height = h1;
    }
    //get width method
    //purpose: initialize values
    //parameters: none
    //returns: none
    public void setWidth(int p1)
    {
        width = p1;
    }
    public void setHeight(int p1)
    {
        height = p1;
    }
    public void setLength(int p1)
    {
        length = p1;
    }
    public int getWidth()
    {
        return width;
    }
    public int getHeight()
    {
        return height;
    }

    public int getLength()
    {
        return length;
    }

    public int calcVolume()
    {
        return length * width * height;
    }
  }
