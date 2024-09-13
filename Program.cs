// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

Console.WriteLine("Hello");
Console.WriteLine("Please chose your first number: ");
var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);
Console.WriteLine("Please chose your second number: ");

var secondAsText = Console.ReadLine();
var number2= int.Parse(secondAsText);

Console.WriteLine("What would you like to do? ");
Console.WriteLine("[A]dd a number");
Console.WriteLine("[S]ubtract a number");
Console.WriteLine("[M]ultiply a number");

var choice = Console.ReadLine();

if (IsCaseSensitive(choice, "A"))   
{
    var sum = number1 + number2;
    PrintFinalEquation(number1, number2, sum,  "+");
}
else if (IsCaseSensitive(choice, "S"))
{
    var deduction = number1 - number2;
    PrintFinalEquation(number1, number2, deduction,  "-");
}
else if (IsCaseSensitive(choice, "M"))
{
    var multiple = number1 * number2;
    PrintFinalEquation(number1, number2, multiple,  "*");
}
else Console.WriteLine("Thats not a valid number, please press a key to close");


void PrintFinalEquation(
    int number1, int number2, int result, string @operator)
{
       Console.WriteLine(
           number1 + " " + @operator + " " + number2 + " = " + result);
}

bool IsCaseSensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}
Console.ReadKey();
