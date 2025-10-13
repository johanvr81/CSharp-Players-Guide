// See https://aka.ms/new-console-template for more information
Console.Title = "The Point";

Point a = new Point(2, 3);
Point b = new Point(-4, 0);

Console.WriteLine($"({a.X}, {a.Y})");
Console.WriteLine($"({b.X}, {b.Y})");

public class Point
{
    public float X { get; }
    public float Y { get; }

    public Point(float x, float y)
    {
        X = x;
        Y = y;
    }

    public Point() : this(0, 0) { }
}

/* 
Are your X and Y properties immutable? Yes
Why did you choose what you did? After the constructor runs, both X and Y can no longer be changed from outside or inside the class.
*/