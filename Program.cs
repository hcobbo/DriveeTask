using System;
using System.Collections.Generic;
using System.Drawing;


public class CoordinateSystem
{
    public int Width {get;}
    public int Height{get;}
    public CoordinateSystem(int width, int height)
    {
        Width = width;
        Height = height;
    }
}
class Order
{
        public Point PointA {get; set;} //точка где забирают посылку
        public Point PointB {get; set;} //точка куда надо доставить посылку
        public int List {get;set;}
        public int RandomPrice {get;set;}
        public List<int>[] Distance {get; set;}
    
}
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
        return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2)); //евлидово расстояние(формула)
    }
}

class Courier
{
    public int Distance {get; set;}
}

class Program
{
   
        static void Main(string[] args)
        {
        Random random = new Random();

        Point pointA = new Point(random.Next(1, 1000), random.Next(1, 1000)); 
        Point pointB = new Point(random.Next(1, 1000), random.Next(1, 1000));
        Point courierLocation = new Point(random.Next(1, 1000), random.Next(1, 1000));


        Console.WriteLine($"Координаты точки А: ({pointA.X}, {pointA.Y})");
        Console.WriteLine($"Координаты точки Б: ({pointB.X}, {pointB.Y})");
        Console.WriteLine($"местоположение курьера: ({courierLocation.X}, {courierLocation.Y})");

        Random RandomNumber = new Random();

        Order obj = new Order();
        obj.List = 10;
        obj. RandomPrice = RandomNumber.Next(100,500);

        Courier courier = new Courier();
        courier.Distance = (int)courierLocation.DistanceTo(pointA);

        Console.WriteLine($"Цена заказа: {obj.RandomPrice}");
        Console.WriteLine($"Расстояние до заказа: {courier.Distance} метров"); // 
        }
}

