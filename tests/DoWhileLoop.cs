// See https://aka.ms/new-console-template for more information

int userNumber;
do
{
    Console.WriteLine("Please choose a number that is greater than 10 ");
    var userInput = Console.ReadLine();
    if(userInput == "stop" || userInput == "Stop")
    {
        break;
    }
    userNumber = int.Parse(userInput);

}while (userNumber <= 10);