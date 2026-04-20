public class Test()
{
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
}