// See https://aka.ms/new-console-template for more information

Random randomNumber1 = new Random();
int number = randomNumber1.Next(1, 11);

Random randomNumber2 = new Random();
int number2 = randomNumber2.Next(1, 11);

Console.WriteLine(number + " _ " + number2);

var input = Console.ReadLine();
switch (input)
{
    case "<":
        lessThan();
        break;
    case ">":
        greaterThan();
        break;
    case "=":
        sameAs();
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}



string GetNumber(int number)
{

}




