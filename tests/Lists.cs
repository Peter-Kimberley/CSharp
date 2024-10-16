// See https://aka.ms/new-console-template for more information
//This is how to generate a list in C#
using System.Diagnostics.Tracing;

var words = new List<string>
{
    "one",
    "two",
    "three",
    "four"
};

// we can add elements to the list as follows;

//words.Add("item no.1 ");

// we can also remove elements from lists


//words.Remove("two");




Console.WriteLine("Count of elements is " + words.Count);

// we can also print the contents of the list using a foreach loop as follows
//foreach(var word in words)
//{
//    Console.WriteLine(word);
//}

// we can also a given index;
//Console.WriteLine(words[2]);

// we can also remove elements at certain indexs
//words.RemoveAt(0);
//Console.WriteLine(words[0]);


// we can also add an array to a list
var moreWords = new[] { "five", "six" };
words.AddRange(moreWords);

foreach (var word in words)
{
    Console.WriteLine(word);
}

//we can also use the IndexOf method to return an index of an element in the list

Console.WriteLine("Index of element four is " +
    words.IndexOf("four"));

// we can also tell if an item is in a list

Console.WriteLine("Is seven in the list? " + words.Contains("Seven"));
Console.WriteLine("Is five in the list? " + words.Contains("five"));

// we can also clear all elements from a list

words.Clear();
Console.WriteLine("The final count of the list after we clear = "
    + words.Count);
Console.ReadKey();
