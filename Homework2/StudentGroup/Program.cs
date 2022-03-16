
string[] GroupGOne = new string[5];
string[] GroupGTwo = new string[5];


Console.WriteLine("Group One:");
for (int i = 0; i < GroupGOne.Length; i++)
{
    Console.WriteLine($"Enter name for student {i + 1}:");
    string studentName = Console.ReadLine();

    bool isDigitPresent = studentName.Any(c => char.IsDigit(c));

    if (isDigitPresent || studentName.Length < 3)
    {
        Console.WriteLine("Invalid input try again:");
        i--;
    }
    else
    {
        GroupGOne[i] = studentName;
    }
}

Console.Write("\n");
Console.WriteLine("Group Two:");
for (int i = 0; i < GroupGTwo.Length; i++)
{
    Console.WriteLine($"Enter a name for student{i + 1}:");
    string studentName = Console.ReadLine();

    bool isDigitPresent = studentName.Any(c => char.IsDigit(c));

    if (isDigitPresent || studentName.Length < 3)
    {
        Console.WriteLine("Invalid input try again:");
        i--;
    }
    else
    {
        GroupGTwo[i] = studentName;
    }
  
}

while (true)
{
    Console.WriteLine("Which group you want to see 1 or 2:");
    string numberString = Console.ReadLine();

    bool isParse = int.TryParse(numberString, out int numbrParse);

    if (isParse)
    {
        if (numberString == "1")
        {
            Console.WriteLine("Students from group 1");
            foreach (string name in GroupGOne)
            {
                Console.WriteLine(name);
            }
            break;
        }
        else if (numberString == "2")
        {
            Console.WriteLine("Students from group 2");
            foreach (string name in GroupGTwo)
            {
                Console.WriteLine(name);
            }
            break;
        }
        else
        {
            Console.WriteLine("That group doesn't exist. Try again:");
        }
    }
    else
    {
        Console.WriteLine("Can't convert a word to an integer");
    }
}

