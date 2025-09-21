using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class HW8
{
    public static void Main(string[] args)
    {

        Console.WriteLine($"The number of numbers in between 5 and 100 which are squares is {Task1(5, 100, 2)}");
        Console.WriteLine($"The amunt of pairs is {Task2("ABCABBBACQ")}");
        Console.WriteLine($"The longest suffix is {Task3("Tekla", "bluekla")}");
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine($"The int list manipulations give us");
        Task4<int>(list);
        List<string> listOfStrings = new List<string> { "tekla", "luka", "mariami" };
        Console.WriteLine($"The string list manipulations give us");
        Task4<string>(listOfStrings);
        List<bool> listOfbools = new List<bool> { true, false, false, true, true, false, true };
        Console.WriteLine($"The boolean list manipulations give us");
        Task4<bool>(listOfbools);
        Console.WriteLine($"The string of number 12345 is ");
        Task5(12345);
        int[] arr = { 1, 2, 3, 4, 5, 6, 1 };
        Console.WriteLine($"the duplicates are in the arrays : {Task6(arr)}");
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
        int i = word1.Length - 1;
        int j = word2.Length - 1;
        string suffix = "";

        while (i >= 0 && j >= 0 && word1[i] == word2[j])
        {
            suffix = word1[i] + suffix;
            i--;
            j--;
        }

        return suffix.Length > 0 ? suffix : "No suffix found";
    }

    public static void Task4<T>(List<T> list)
    { /* დაწერეთ ფუნქცია რომელიც მიიღებს Generic ტიპის ლისტს , შეამოწმებს
გადაცემული ლისტის ტიპს და შემოწმების შემდეგ ჩაატარებს შემდეგ
ოპერაციებს .
თუ გადაეცემა სტრინგების ლისტი - დაბეჭდავს ყველა სტრინგს UpperCase-ში
თუ გადაეცემა ნებისმიერი რიცხვითი ტიპის მასივი ( int) - დაითვლის მათ ჯამს
თუ გადაეცემა Bool - გამოიტანს ლისტის პირველ, ბოლო და შუაში მყოფ
ელემენტს .
       */

        if (list[0] is string)
        {
            foreach (var word in list)
                Console.WriteLine(word.ToString().ToUpper());

            return;


        }
        else if (list[0] is int)
        {
            var sum = 0;
            foreach (var num in list) sum += (int)(object)num;
            Console.WriteLine($"Sum of integers: {sum}");

        }
        else if (list[0] is bool)
        {
            Console.WriteLine($"Fist boolean is {list[0]}");
            Console.WriteLine($"Middle boolean is {list[list.Count / 2]}");
            Console.WriteLine($"Last boolean is {list[list.Count - 1]}");

        }
    }


    public static void Task5(int number)
    {
        aux(number);
    }

    private static void aux(int number)
    {
        if (number < 10)
        {
            Console.Write(number + " - ");
            return;
        }
        aux(number / 10);
        Console.Write(number % 10 + " - ");
    }

    public static bool Task6(int[] arr)
    {
        // Return true if any element appears more than once
        return arr.GroupBy(x => x).Any(g => g.Count() > 1);
    }
}

