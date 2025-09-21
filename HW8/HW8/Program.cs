public class HW8
{
    public static void Main(string[] args)
    {

        Console.WriteLine($"The number of numbers in between 5 and 100 which are squares is {Task1(5, 100, 2)}");
        Console.WriteLine($"The amunt of pairs is {Task2("ABCABBBACQ")}");
        Console.WriteLine($"The longest suffix is {Task3("Tekla", "bluekla")}");
;



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

    public static string Task3(string word1, string word2)
    {
        /* დაწერეთ ფუნქცია რომელიც დააბრუნებს ყველა გრძელ საერთო
ბოლოსართს ორ სტრინგს შორის AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA*/
        string suffix = "";
       

        for(int i = word1.Length -1; i == 0; i--)
        {
            for (int j = word2.Length - 1; j == 0; j--)
            {
                if (word1[i] == word2[j])
                {
                    suffix.Append(word1[i]);
                    continue;

                }
                else break;

            }
        }


        return suffix;
    }




}

