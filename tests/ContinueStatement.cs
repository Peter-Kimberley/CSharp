// See https://aka.ms/new-console-template for more information
for(var i = 0; i < 20; ++i)
{
    if(i % 3 == 0)
    {
        continue;   
    }
    Console.WriteLine("i is " + i);

}



Console.WriteLine("This continue loop is now finished ");
Console.ReadKey();
// This is the continue condition being used to restart the loop if the current number 
// is devisable by three.