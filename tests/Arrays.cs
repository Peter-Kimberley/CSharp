// See https://aka.ms/new-console-template for more information
// This is an Array of intigers meaning that we can't store another type in it.

int[] numbers = new int[] { 1, 2, 3, 4, 5 };

var sum = 0;

for(var i = 0; i < numbers.Length; ++i)
{
    sum += numbers[i];
}
Console.WriteLine("The total value of the Array is: " + sum);


//numbers[0] = 6;
//numbers[1] = 12;
//numbers[2] = 18;
//numbers[3] = 36;
//numbers[4] = 64;
//var firstFromEnd = numbers[^1];
//var secondFromEnd = numbers[^2];
//Console.WriteLine("First number from the end: " + firstFromEnd);
//Console.WriteLine("Second number from the end: " + secondFromEnd);


//Console.WriteLine("Elememts at posotion 1 are now: " + numbers[0]);
//Console.WriteLine("Elememts at posotion 2 are now: " + numbers[1]);
//Console.WriteLine("Elememts at posotion 3 are now: " + numbers[2]);


Console.ReadKey();