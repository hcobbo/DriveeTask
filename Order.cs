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
