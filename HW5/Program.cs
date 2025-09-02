
Console.WriteLine("WELCOME BACK, For the first task, to check if number is divisible by 5, please enter your number: ");
var input = Console.ReadLine();

int num = int.TryParse(input, out num) ? num : 0;

if (num % 5 == 0){
    Console.WriteLine($"YES, The number {num} is divisible by 5."); }
else{
    Console.WriteLine($"NOPE, The number {num} is not divisible by 5.");
}

Console.WriteLine("For the second task,to find sum, difference, multiple and division results of two numbers " +
    " please enter your first  number: ");
var input1 = Console.ReadLine();

Console.WriteLine("enter your second number: ");
var input2 = Console.ReadLine();

int num1 = int.TryParse(input1, out num1) ? num1 : 0;
int num2 = int.TryParse(input2, out num2) ? num2 : 0;

int sum = num1 + num2;
Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
int difference;
if (num1 > num2)   difference = num1 - num2; 
else               difference = num2 - num1;

Console.WriteLine($"The difference between {num1} and {num2} is: {difference}");
int multiple = num1 * num2;

Console.WriteLine($"The multiple of {num1} and {num2} is: {multiple}");

int division = 0;
if (num1 > num2)
{
    if (num2 == 0) Console.WriteLine("Division by zero is not allowed.");
    else division = num1 / num2;
}
else if (num1 == 0) Console.WriteLine("Division by zero is not allowed.");
else division = num2 / num1;

Console.WriteLine($"The division of {num1} and {num2} is: {division}");


Console.WriteLine("Let's carry on, for our third task, we exchange places for two inputs. ");
Console.WriteLine("Please enter your first input: ");

var in1 = Console.ReadLine();

Console.WriteLine("Please enter your second input: ");
var in2 = Console.ReadLine();

int number1 = int.TryParse(in1, out number1) ? number1 : 0;
int number2 = int.TryParse(in2, out number2) ? number2 : 0;

int temp = number1;
number1 = number2;
number2 = temp;

Console.WriteLine($"After exchanging, the first input is: {number1}, and the second input is: {number2}.");


Console.WriteLine("Our fourth task is displaying the multiplication table of a given number. Please enter your number: ");
var input3 = Console.ReadLine();

int x = int.TryParse(input3, out x) ? x : 0;
for(int i = 1; i<=10; i++)
{
    int result = x * i; 
    Console.WriteLine($"{x} x {i} = {result}");

}


Console.WriteLine("Finally, for our fifth task, we will find all even numbers between 1 and your input" +
    " and will print their squares. Please enter your number ");

var input4 = Console.ReadLine();

int y = int.TryParse(input4, out y) ? y : 0;

for(int i = 1; i <= y; i++)
{if (i % 2 == 0)
        {
        int square = i * i;
        Console.WriteLine($"The square of number {i} is: {square}");
    }
}

