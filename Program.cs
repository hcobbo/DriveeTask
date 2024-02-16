using System;
using System.Collections.Generic;
using System.Drawing;

class Order
{
        public string Name { get; set; }
        public Point PointA {get; set;} //точка где забирают посылку
        public Point PointB {get; set;} //точка куда надо доставить посылку
        public int List {get;set;}
        public int RandomPrice {get;set;}
        public List<int>[]? Distance {get; set;}

        public Order(string name)
        {
            Name = name;
            Random random = new Random();
            PointA = new Point(random.Next(1, 1000), random.Next(1, 1000)); 
            PointB = new Point(random.Next(1, 1000), random.Next(1, 1000));
        }
    
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
        return Math.Sqrt(Math.Pow(X - other.X, 2) + Math.Pow(Y - other.Y, 2)); //евклидово расстояние(формула)
    }
}
class Courier
{
    public string Name { get; set; }
    public int Distance {get; set;}
    public Point PointA { get; set; }
    public Point PointB { get; set; }
    public Point CourierLocation { get; set; }
        public Courier (string name)
        {
        Name = name;
        Random random = new Random();
        PointA = new Point(random.Next(1, 1000), random.Next(1, 1000)); 
        PointB = new Point(random.Next(1, 1000), random.Next(1, 1000));
        CourierLocation = new Point(random.Next(1, 1000), random.Next(1, 1000));
        }
   
    
}

class Program
{
   
        static void Main(string[] args)
        {
            List<Courier> couriers = new List<Courier>();
                for(int i = 0; i < 10; i++)
                    {
                        Courier courier = new Courier($"Courier{i +1}");
                        courier.Distance =  new Random().Next(0,3000);
                        couriers.Add(courier);
                    }
            List<Order> orders = new List<Order>();
                for (int i = 0; i < 15; i++)
                {
                        Point pointA = new Point(new Random().Next(1, 1000), new Random().Next(1, 1000));
                        Point pointB = new Point(new Random().Next(1, 1000), new Random().Next(1, 1000));

                        Order order = new Order($"Order{i +1}");
                        order.PointA = pointA;
                        order.PointB = pointB;
                        order.List = i; // 
                        order.RandomPrice = new Random().Next(100, 500); 

                        orders.Add(order);
                }
                 foreach (Order order in orders)
        {
            Courier nearestCourier = null;
            double minDistance = double.MaxValue;

            foreach(Courier courier in couriers)
            {
                double DistanceToA =courier.CourierLocation.DistanceTo(order.PointA);

                if(DistanceToA < minDistance)
            {
                minDistance = DistanceToA;
                nearestCourier = courier;
            }
            }
            Console.WriteLine($"Имя заказа: {order.Name}");
            Console.WriteLine($"Имя курьера: {nearestCourier.Name}");
            Console.WriteLine($"Местоположение курьера: ({nearestCourier.CourierLocation.X}, {nearestCourier.CourierLocation.Y})"); 
            Console.WriteLine($"Точка A: ({order.PointA.X}, {order.PointA.Y})");
            Console.WriteLine($"Точка B: ({order.PointB.X}, {order.PointB.Y})");
            Console.WriteLine($"Стоимость: {order.RandomPrice}");
            Console.WriteLine();
        }
}
}

