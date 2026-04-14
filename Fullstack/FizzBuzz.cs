public class FIzzBuzz
{
    public void Start()
    {
        FizzBuzz(2, 3, 7);
    }
    public void FizzBuzz(int x, int y, int n) {
        bool fizz = false;
        bool buzz = false;
        for (int i = 0; i < n; i++) {
            if (i % x == 0) {
                fizz = true;
            }
            if (i % y == 0) {
                buzz = true;
            }
            string debug = "";
        if (fizz) {
            debug += "Fizz";
        }
        if (buzz) {
            debug += "Buzz";
        }
        else if (!fizz && !buzz) {
            debug = i.ToString();
        }
        Console.WriteLine(debug);
        }
    }

}

