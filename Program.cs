using System;
using System.Collections.Generic;
using System.Drawing;

class Program
{
    const int MinRandomDistance = 300;
    const int MaxRandomDistance = 3000;
    const int MinRandomCoordinate = 1;
    const int MaxRandomCoordinate = 1000;
    const int MaxRandomPrice = 1000;
    const int MinRandomPrice = 100;
    static void Main(string[] args)
    {
        List<Courier> couriers = GenerateCouriers(10); 

       List<Order> orders = GenerateOrders(15); 

        foreach (Order order in orders)
        {
            Courier nearestCourier = null;
            double minDistance = double.MaxValue;

            foreach (Courier courier in couriers)
            {
                double DistanceToA = courier.CourierLocation.DistanceTo(order.PointA);

                if (DistanceToA < minDistance)
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

    // Метод для создания списка курьеров
    static List<Courier> GenerateCouriers(int countCouriers)
    {
        List<Courier> couriers = new List<Courier>();
        for (int i = 0; i < countCouriers; i++)
        {
            Courier courier = new Courier($"Courier{i + 1}");
            courier.Distance = new Random().Next(MinRandomDistance, MaxRandomDistance);
            couriers.Add(courier);
        }
        return couriers;
    }
    
    static List<Order> GenerateOrders(int countOrders)
    { 
        List<Order> orders = new List<Order>();
        for (int i = 0; i < countOrders; i++)
        {
            Order order = new Order($"Order{i + 1}");
            order.List = i; 
            order.RandomPrice = new Random().Next(MinRandomPrice, MaxRandomPrice);  
            orders.Add(order);
        }
        return orders;
    }
}