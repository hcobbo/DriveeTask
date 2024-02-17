using System;
using System.Collections.Generic;
using System.Drawing;

class Point
{
    public int X {get; set;}
    public int Y {get; set;}

        public Point (int x, int y)
            {
                X=x;
                Y=y;
            }
            
        public double DistanceTo(Point other)
            {
                return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2)); //евклидово расстояние(формула)
            }
}