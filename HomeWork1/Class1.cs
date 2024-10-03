//class Vehicle
//{
//    public required string Make { get; set; }
//    public required string Model { get; set; }
//    public int Year { get; set; }

//    public virtual void DisplayInfo()
//    {
//        Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
//    }
//}

//class Car : Vehicle
//{
//    public int NumberOfDoors { get; set; }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"number of doors: {NumberOfDoors}");
//    }
//}

//class Truck : Vehicle {
//    public int PayloadCapacity { get; set; }

//    public override void DisplayInfo()
//    {
//        base.DisplayInfo();
//        Console.WriteLine($"payload Capacity: {PayloadCapacity} kg");
//    }
//}

//class Car1 {
//    static void Main()
//    {
//        Car myCar = new Car {
//            Make = "hyundai",
//            Model = "sonata",
//            Year = 2012,
//            NumberOfDoors = 4
//        };

//        Truck myTruck = new Truck {
//            Make = "ford",
//            Model = "f-150",
//            Year = 2019,
//            PayloadCapacity = 1500
//        };

//        Console.WriteLine("car Info:");
//        myCar.DisplayInfo();

//        Console.WriteLine("\n truck nfo:");
//        myTruck.DisplayInfo();
//    }
//}
