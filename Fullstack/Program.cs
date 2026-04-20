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

string DNAPair (string ma)
{
    string pair = "";
    for (int i = 0; i < ma.Length; i++)
    {
        switch (ma[i])
        {
            case 'A':
            {
                pair += 'T';
                continue;
            }
            case 'T':
            {
                pair += 'A';
                continue;
            }
            case 'G':
            {
                pair += 'C';
                continue;
            }
            case 'C':
            {
                pair += 'G';
                continue;
            }
        }
    }

    return pair;
}

string IsEven (int x)
{
    if (x % 2 == 0)
    {
        return "Even";
    }
    return "Odd";
}

int GetLargest (int[] numbers)
{
    int currentLargest = -1;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > currentLargest)
        {
            currentLargest = numbers[i];
        }
    }
    return currentLargest;
}

bool IsPangram (string text)
{
    char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
    for (int i = 0; i < alphabet.Length; i++)
    {
        if (!text.Contains(alphabet[i]))
        {
            return false;
        }
    }
    return true;
}