//Exercise 1

int swap = 0;

Console.WriteLine("First number:");
string number1 = Console.ReadLine();

Console.WriteLine("Secon number:");
string number2 = Console.ReadLine();

int number1Parse = int.Parse(number1);
int number2Parse = int.Parse(number2);

swap = number1Parse;
number1Parse = number2Parse;
number2Parse = swap;


Console.WriteLine(string.Format("{0} {1} {2} {3}", "First number: ", number1Parse, " Second number: ", number2Parse));

//Exercise 2

double sum = 0;
double count = 0;

while (true)
{
    Console.WriteLine("Add a number or press enter to exit:");
    string numbers = Console.ReadLine();

    if (string.IsNullOrEmpty(numbers))
        break;

    sum += double.Parse(numbers);
    count++;
}

double average = sum / count;

if (count > 0)
{
    Console.WriteLine($"The average number is:{Math.Round(average, 2)}");

}
else
{
    Console.WriteLine("Can not devide by zero");
}

//Exercise 3

Console.Write("First number:");
string fisrtNumber = Console.ReadLine();

Console.Write("Operator:");
string Operator = Console.ReadLine();

Console.Write("Second number:");
string secondNumber = Console.ReadLine();

double firstNumberParse = double.Parse(fisrtNumber);
double secondNumberParse = double.Parse(secondNumber);

double result = 0;

switch (Operator)
{
    case "+":
        result = firstNumberParse + secondNumberParse;
        Console.WriteLine($"{firstNumberParse} + {secondNumberParse} = {result}");
        break;
    case "-":
        result = firstNumberParse - secondNumberParse;
        Console.WriteLine($"{firstNumberParse} - {secondNumberParse} = {result}");
        break;
    case "*":
        result = firstNumberParse * secondNumberParse;
        Console.WriteLine($"{firstNumberParse} * {secondNumberParse} = {result}");
        break;
    case "/":
        result = firstNumberParse / secondNumberParse;
        if (secondNumberParse != 0)
            Console.WriteLine($"{firstNumberParse} / {secondNumberParse} = {result}");
        else
            Console.WriteLine($"{firstNumberParse} / {secondNumberParse} =  ERROR!");
        break;
    default:
        Console.WriteLine($"{firstNumberParse} {Operator} {secondNumberParse} = ERROR!");
        break;
}