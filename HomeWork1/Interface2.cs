//interface IShape
//{
//    double Area { get; }
//    void CalculateArea();
//}

//class Rectangle : IShape {
//    public double Width { get; set; }
//    public double Height { get; set; }
//    public double Area { get; private set; } 

//    public Rectangle(double width, double height) {
//        Width = width;
//        Height = height;
//    }


//    public void CalculateArea() {
//        Area = Width * Height;
//    }
//}

//class Circle : IShape {
//    public double Radius { get; set; }
//    public double Area { get; private set; } 

//    public Circle(double radius) {
//        Radius = radius;
//    }


//    public void CalculateArea() {
//        Area = Math.PI * Radius * Radius;
//    }
//}

//class cir_recta {
//    static void Main() {

//        IShape rectangle = new Rectangle(5, 10);
//        IShape circle = new Circle(7);

//        // Calculate and display areas
//        rectangle.CalculateArea();
//        Console.WriteLine($"area of the rectangle: {rectangle.Area}");


//        circle.CalculateArea();
//        Console.WriteLine($"area of the circle: {circle.Area}");
//    }
//}
