using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;

public class HW7
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"The difference of areaa is {Task1(5)}");
        Console.WriteLine($"The jackpot status : {Task2("@@@@@", "@@@@@")}");
        Console.WriteLine($"The final points for football team is {Task3(3, 1, 1)}");
        int[] hours = { 5, 8, 8, 8, 8, 8, 8 };
        Console.WriteLine($"The income of the week is {Task4(hours)}");
        int[] days = { 1, 2, 3, 4, 5};
        Console.WriteLine($"The days of progress for George were {Task5(days)}");
        Console.WriteLine($"The words are");  Task6(5);
    }

    public static int Task1(int r)
    {

        /* მოცემულია კვადრატი და კვადრატში ჩახატული წრე . ამ წრეში
        ჩახატულია კიდევ ერთი სხვა კვადრატი .
        დაწერეთ პროგრამა რომელიც იპოვის სხვაობას დიდი და პატარა კვადრატის
        ფართობებს შორის .*/

        int difference = 0;
        int areaOfBigSquare = (int)Math.Pow(r * 2, 2);
        double lengthOfSmallSquare = r * Math.Sqrt(2);
        double areaOfSmallSquare = Math.Pow(lengthOfSmallSquare, 2);
        difference = areaOfBigSquare - (int)areaOfSmallSquare;

        return difference;
    }

    public static bool Task2(string jackpot, string input)
    {
        /* დაწერეთ პროგრამა რომელიც შეამოწმებს ამოუვიდა თუ არა იუზერს
ჯეკპოტი */

        bool result = jackpot.Equals(input);

        return result;
    }

    public static int Task3(int win, int lose, int draw)
    {
        int points = 0;
        /*  დაწერეთ პროგრამა რომელიც დათვლის ჯამში რამდენი ქულა დააგროვა
  საფეხბურთო გუნდმა
  a.მოგება - 3
  b.ფრე = 1
  c.წაგება = 0 */

        points = points + (win * 3) + (draw * 1);


        return points;
    }

    public static int Task4(int[] hours)
    {
        /* დაწერეთ პროგრამა რომელიც დათვლის თანამშრომლის შემოსავალს 1 კვირის განმავლობაში.
a. დღეში თანამშრომელი მუშაობს 8 საათს და საათში იღებს 10 $
b. ოვერთაიმის შემთხვევაში საათში იღებს დამატებით 5$
c. შაბათ/კვირას მუშაობის შემთხვევაში იღებს გაორმაგებულ ხელფასს
         */
        int income = 0;
        for (int i = 0; i < 5; i++)
        {
            if (hours[i] <= 8) income += hours[i] * 10;
            else income = income + (hours[i] * 10) + ((hours[i] - 8) * 5);
        }

        for (int i = 5; i < 7; i++)
        {
            if (hours[i] != 0) income += hours[i] * 20;
        }

        return income;
    }


    public static int Task5(int[] hours)
    {
        /* გიორგი მარათონისთვის ემზადება ის ყოველ დღიურად ვარჯიშობს
.შეამოწმეთ აქვს თუ არა გიორგის პროგრესი ყოველ დღიურად და გამოიტანეთ იმ
დღეების რაოდენობა როდესაც მან შედეგი გააუმჯობესა. */
        int progress = 0;
        for (int i = 1; i < hours.Length; i++)
        {
            if (hours[i] > hours[i - 1]) progress++;

        }

        return progress;

    }

    public static void Task6(int n)
    {
        string[] words = { "tekla", "temuk", "shota", "programming", "C#" };
        var finalWords = words.Where(word => word.Length == n);
        Console.Write(string.Join(", ", finalWords));
     
    }
}

