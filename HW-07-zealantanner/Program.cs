using System;

interface IPoint
{
    int X {get; set;}
    int Y {get; set;}
}

class Point : IPoint
{
    public Point(int newX, int newY)
    {
        X = newX;
        Y = newY;
    }
    public int X {get; set;}
    public int Y {get; set;}
}

class MainClass
{
    static void Main()
    {
        IPoint aPoint = new Point(10,10);
        Console.WriteLine($"The Point: ({aPoint.X},{aPoint.Y})");
    }
}