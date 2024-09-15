// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello");
Console.WriteLine("What would you like to do?");
Console.WriteLine("[S]ee all TO DO's");
Console.WriteLine("[A]dd a TO DO");
Console.WriteLine("[R]emove a TO DO");
Console.WriteLine("[E]xit TO DO's");

// This next piece of code is string interpolation

int a = 10, b = 20, c = 30;

Console.WriteLine(
    $"this number is {a}, this number is {b}, and this number is {c}");
Console.ReadKey();
// This is for testing, please delete