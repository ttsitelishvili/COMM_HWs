public class HW8
{
    public static void Main(string[] args)
    {

        Console.WriteLine($"The number of numbers in between 5 and 100 which are squares is {Task1(5, 100, 2)}");
        Console.WriteLine($"The amunt of pairs is {Task2("ABCABBBACQ")}");





    }



public static int Task1(int a, int b, int n)
    { /*დაწერეთ ფუნქცია რომელიც პარამეტრად მიიღებს   a, b, n 
a. a - მინიმალური რიცხვი
b. b - მაქსიმალური რიცხვი
c. n - ხარისხი რომელშიც უნდა ავიყვანოთ რიცხვები
იპოვეთ ყველა რიცხვი a - &gt; b შუალედში რომლის n ხარისხი
მოთავსებულია ამ ინტერვალში */

        int amount = 0; 
        for (int i = 2; i <= b; i++)
        if (Math.Pow(i, n) < b && Math.Pow(i, n) > a) amount++;

      

        return amount;

    }

    public static int Task2(string socks)
    {
        /* დაეხმარეთ პატარა ნიკუშას წინდების წყვილების პოვნაში. წყვილები
აღნიშნულია ორი ერთნაირი სიმბოლოთი. */
        {
          return socks
                .GroupBy(c => c)
                .Sum(g => g.Count() / 2);
        }
    }

    public static string Task3(string[] words)
    {
        /* დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა გრძელ საერთო
ბოლოსართს ორ სტრინგს შორის AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA*/

        if (words == null || words.Length == 0)
            return string.Empty;

        // Find the minimum word length to avoid index out of range
        int minLen = words.Min(w => w.Length);

        // Check each suffix length from 1 to minLen
        var longestSuffix = Enumerable.Range(1, minLen)
            .Reverse()
            .Select(len => words[0][^len..]) // Take suffix of length 'len' from the first word
            .FirstOrDefault(suffix => words.All(w => w.EndsWith(suffix)));

        return longestSuffix ?? string.Empty;
    }


    

}

