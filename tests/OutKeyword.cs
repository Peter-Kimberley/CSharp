// See https://aka.ms/new-console-template for more information
int nonPositiveCount;
// we inintialise the variable numbers to contain an array
var numbers = new[] { 10, -9, 2, 12, -17 };
// we initialise onlyPositive variable to contain a list of positive numbers after using our method 
var onlyPositive = GetonlyPositive(numbers, out nonPositiveCount);
foreach(var positiveNumber in onlyPositive)
{
    Console.WriteLine(positiveNumber);
}

Console.WriteLine("The count of the non positive numbers" +
    "are: " + nonPositiveCount);
Console.ReadKey();



// this is a method for returning positive numbers
List<int> GetonlyPositive(
    int[] numbers, out int countOfNonePositive)
{
    countOfNonePositive = 0;
    var result = new List<int>();
    foreach(int number in numbers)
    {
        if(number > 0)
        {
            result.Add(number);
        }
        else
        {
            countOfNonePositive++;
        }
    }
    return result;
}

