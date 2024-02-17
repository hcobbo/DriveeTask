using System;
using System.Collections.Generic;
using System.Drawing;

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