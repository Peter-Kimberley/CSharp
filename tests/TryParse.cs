// See https://aka.ms/new-console-template for more information
// we are parsing a string to an int

bool isParsingSuccessful;
do
{


    Console.WriteLine("Please enter a number");
    var userInput = Console.ReadLine();

         isParsingSuccessful = int.TryParse(
        userInput, out int number);
    if (isParsingSuccessful)
    {
        Console.WriteLine(
            "Parsing was suceesful number is " + number);

    }
    else
    {
        Console.WriteLine("Parsing was not sucessful ");
    }

} while (!isParsingSuccessful);




Console.ReadKey();
