// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a whole number!");

//datatype variable name = value
int myNumber = 0;

string userInput = Console.ReadLine();
myNumber = int.Parse(userInput);

Console.WriteLine("You entered: " + userInput);