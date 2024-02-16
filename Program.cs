using System;
using System.Collections.Generic;
using System.Drawing;

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
                                order.RandomPrice = new Random().Next(100, 500); //здесь генерация случайной цены не привязанной к расстоянию и тд

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

