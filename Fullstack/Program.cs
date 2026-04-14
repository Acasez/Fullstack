Console.WriteLine("Hello, World!");

Console.WriteLine("FizBuzz 2, 3, 7");
FizzBuzz(2, 3, 7);

Abbreviate(3, "Hannes Real Company");

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

void Abbreviate(int words, string name){
    string abbreviation = "";
    string[] split = name.Split(' ');
    //Split string into words
    //Get First letter of each word, check if capitalized
    //Output Abbreviation
    for (int i = 0; i < words; i++)
    {
        char firstLetter = split[i][0];
        if (Char.IsUpper(firstLetter))
        {
            abbreviation += firstLetter;
        }
    }
    Console.WriteLine(abbreviation);
}