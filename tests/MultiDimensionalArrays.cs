// See https://aka.ms/new-console-template for more information
// This is a two dimensional array

char[,] letters = new char[2, 3];


letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';


//intialising arrays

var letters2 = new char[,]
{
    {'A','B', 'C' },
    {'D','E', 'F' },
};

// a for loop printing each element of a 2 dimensional array to the Console

var height = letters.GetLength(0);
var width = letters.GetLength(1);
Console.WriteLine("Height is: " + height);
Console.WriteLine("Width is: " + width);
for (var i = 0; i < height; i++)
{
    Console.WriteLine("i is " + i);
    for (var j = 0; j < width; j++)
    {
        Console.WriteLine("j is " + i);
        Console.WriteLine("Element is " + letters[i, j]);
    }
    
}

Console.ReadKey();
