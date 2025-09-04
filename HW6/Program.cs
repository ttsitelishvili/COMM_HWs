// TASK 1

Console.Write("Welcome, Enter a number of elements you want to insert: ");
var input = Console.ReadLine();
int size = int.TryParse(input, out int result) ? result : 0;

int[] array = new int[size];
for (int i = 0; i < size; i++) {
    Console.Write($"Enter element {i + 1}: ");
    array[i] = int.TryParse(Console.ReadLine(), out int element) ? element : 0;
    if (i == size -1) Console.WriteLine("Elements are inserted successfully.");
}

int evencount = 0;
int oddcount = 0;

for(int i = 0; i < size; i++) {
   if (array[i] % 2 == 0) evencount++;
        else oddcount++;
}

int[] evens = new int[evencount];
int[] odds = new int[oddcount];

int indexeven = 0;
int indexodd = 0;

for (int i = 0; i < size; i++) {
    if (array[i] % 2 == 0)  {
        evens[indexeven] = array[i];
        indexeven++;
    }
    else  {
        odds[indexodd] = array[i];
        indexodd++;
    }
    ;
}
Console.WriteLine("Even array is: ");
for (int i = 0; i < evens.Length; i++) {
    Console.WriteLine(evens[i]);
}

Console.WriteLine("Odd array is: ");
for (int i = 0; i < odds.Length; i++) {
    Console.WriteLine(odds[i]);
}


Console.WriteLine("Thank youu");


//TASK 2

Dictionary<string, string> Contacts = new Dictionary<string, string>();
Console.WriteLine("Welcome to your Contacts List, if you want to add contatct enter 1 and to remove contact enter 2, if you want to exit tyoe anything");

while (true){
    string choice = Console.ReadLine();
    if (choice == "1")
    {
        Console.Write("Enter contact name:");
        string name = Console.ReadLine();
        Console.Write("Enter contact number:");
        string number = Console.ReadLine();

        Contacts.Add(name, number);
        Console.WriteLine("enter your choice:");
    }
    else if (choice == "2")
    {
        Console.Write("This is our Consacts List: ");
        foreach (var contact in Contacts) Console.WriteLine($"{contact.Key}: {contact.Value}");
        Console.Write("Enter contact name you want to remove:");
        string name = Console.ReadLine();
        Contacts.Remove(name);
        Console.WriteLine("enter your choice:");

    }
    else break;
}

Console.WriteLine("THANKSSS ");

//TASK 3

Console.Write("Enter a number of elements you want to insert: ");
var input1 = Console.ReadLine();
int arrsize = int.TryParse(input1, out int results) ? results : 0;

int[] arr = new int[arrsize];
for (int i = 0; i < arrsize; i++){
    Console.Write($"Enter element {i + 1}: ");
    arr[i] = int.TryParse(Console.ReadLine(), out int element) ? element : 0;
    if (i == arrsize - 1) Console.WriteLine("Elements are inserted successfully.");
}

Dictionary<int, int> frequency = new Dictionary<int, int>();
foreach(int num in arr){
    if (frequency.ContainsKey(num))
        frequency[num]++;

    else
        frequency[num] = 1;
}

foreach(var pair in frequency){

    Console.WriteLine($"Number {pair.Key} occurs {pair.Value} times. The sum os {pair.Key * pair.Value}");
}