﻿// class Shape {
//    public virtual double GetArea() {
//        return 0;
//    }
//}

//class Rectangle : Shape {
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height) {
//        Width = width;
//        Height = height;
//    }

//    public override double GetArea()
//    {
//        return Width * Height;
//    }
//}

//class Circle : Shape {

//    public double Radius { get; set; }
//    public Circle(double radius) {
//        Radius = radius;
//    }

//    public override double GetArea() {
//        return Math.PI * Radius * Radius;
//    }
//}

//class Program
//{
//    static void Main() {

//        Shape rectangle = new Rectangle(5, 10);
//        Shape circle = new Circle(7);  

//        Console.WriteLine("area of the rectangle: " + rectangle.GetArea());
//        Console.WriteLine("area of the circle: " + circle.GetArea());
//    }
//}
