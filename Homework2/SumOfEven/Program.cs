
int[] numbers = new int[6];
int count = 0;
int sum = 0;

while (numbers.Length > count)
{
    Console.WriteLine("Enter a number:");
    string numberString = Console.ReadLine();

    bool isParse = int.TryParse(numberString, out int numberParse);
    if (isParse)
    {
        numbers[count] = numberParse;
        count++;
    }
    else
    {
        Console.WriteLine("Can't convert a word to a integer try again:");
    }

}


foreach (int num in numbers)
{
    if (num % 2 == 0)
        sum += num;
}

Console.WriteLine($" Sum of even numbers: {sum}");