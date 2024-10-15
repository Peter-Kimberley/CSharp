// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Tracing;

Console.WriteLine("Hello, World!");
var words = new[] { "one", "two", "three", "four", "five" };
//for (var i = 0; i < words.Length; i++) 
//{
//    Console.WriteLine(words[i]);

//}
// the foreach loop is much more simplar to use, than the forloop from earlier.
foreach(var word in words)
{
    Console.WriteLine(word);
}

Console.ReadKey();
