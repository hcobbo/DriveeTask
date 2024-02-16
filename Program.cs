using System;
using System.Collections.Generic;
class Order
{
    
        public int List {get;set;}
        public int RandomPrice {get;set;}
        public List<int>[] Distance {get; set;}
    
}

class Courier
{
    public int RandomDistance {get; set;}
}
class Program
{
   
        static void Main(string[] args)
        {

        Random Random = new Random();

        Order obj = new Order();
        obj.List = 10;
        obj. RandomPrice = Random.Next(100,500);

        Courier courier = new Courier();
        courier.RandomDistance = Random.Next(100,3000);

        Console.WriteLine($"Цена заказа: {obj.RandomPrice}");
        Console.WriteLine($"Расстояние до заказа: {courier.RandomDistance} метров");
        }
}

