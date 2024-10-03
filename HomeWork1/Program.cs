//function 1    (sum number)

//class Sum {
//    static int Add(int a, int b) {
//        return a + b;
//    }
//    static void Main() {

//        int num1 = 10;
//        int num2 = 10;
//        int sum = Add(num1, num2);

//        Console.WriteLine("the sum of {0} and {1} is: {2}", num1, num2, sum);
//    }
//}







//function 2   (calcuata area)

//class Dob {
//    static double CalculateArea(double width, double height = 1) {
//        return width * height;
//    }

//    static void Main() {
//        double width = 5;
//        double area = CalculateArea(width);
//        Console.WriteLine("the area of the rectangle (or square) is: " + area);
//    }
//}








//function 3  (print message)

//class Mesg {
//    static void PrintMessage(string message) {
//        Console.WriteLine("Message: " + message);
//    }
//    static void PrintMessage(string message, int number) {
//        Console.WriteLine("Message: " + message + ", Number: " + number);
//    }

//    static void Main() {
//        PrintMessage("hello guys :)");
//        PrintMessage("the answer is", 56);
//    }
//}









//function 4  (product)

//class Product {
//    static void CalculateSumAndProduct(int a, int b, out int sum, out int product) {
//        sum = a + b;
//        product = a * b;
//    }

//    static void Main() {
//        int num1 = 10;
//        int num2 = 10;
//        int sum, product;
//        CalculateSumAndProduct(num1, num2, out sum, out product);
//        Console.WriteLine("sum: " + sum);
//        Console.WriteLine("product: " + product);
//    }
//}










//function 5  (factorial)

//class Factor {
//    static int Factorial(int n) {
//        if (n <= 1)
//            return 1;
//        return n * Factorial(n - 1);
//    }

//    static void Main() {
//        int number = 5;
//        int result = Factorial(number);

//        Console.WriteLine("factorial of " + number + " is: " + result);
//    }
//}









//function 6 (square)

//class Squr {
//    static void Main() {
//        Func<int, int> square = x => x * x;
//        int number = 5;
//        int result = square(number);

//        Console.WriteLine("the square of " + number + " is: " + result);
//    }
//}




