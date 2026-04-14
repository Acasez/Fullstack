Console.WriteLine("Hello, World!");

Console.WriteLine("FizBuzz 2, 3, 7");
FizzBuzz(2, 3, 7);
Console.WriteLine("FizBuzz 2, 4, 7");
FizzBuzz(2, 4, 7);
Console.WriteLine("FizBuzz 3, 5, 7");
FizzBuzz(3, 5, 7);
void FizzBuzz(int x, int y, int n) {
    for (int i = 1; i <= n; i++) {
        bool fizz = false;
        bool buzz = false;

        if (i % x == 0) {
            fizz = true;
        }
        if (i % y == 0) {
            buzz = true;
        }
        if (fizz && buzz)
        {
            Console.WriteLine("FizzBuzz");
        }   
        else if (fizz) {
            Console.WriteLine("Fizz");
        }
        else if (buzz) {
            Console.WriteLine("Buzz");
        }
        else if (!fizz && !buzz) {
            Console.WriteLine(i);
        }
    }
}