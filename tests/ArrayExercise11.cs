// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Security.Cryptography;

char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
var result = "";
for(int i = 0; i < letters.Length; ++i)
{
    
    result += letters[i];
    

}
Console.WriteLine(result);
Console.ReadKey();

    