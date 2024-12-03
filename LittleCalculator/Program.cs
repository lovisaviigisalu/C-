// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hi! Let's calculate the sum of two numbers!");

//datatype variable name = value
int myNumber = 0;
int myNumber2 = 0;

//taking the first user input and converting it to an integer
Console.WriteLine("Enter the first (whole) number!");
string userInput = Console.ReadLine();
myNumber = int.Parse(userInput);

//taking the second user input and converting it to an integer
Console.WriteLine("Enter the second (whole) number!");
string userInput2 = Console.ReadLine();
myNumber2 = int.Parse(userInput2);

//calculating the sum and storing it in a variable
int sum = myNumber + myNumber2;

//printing the sum to the console
Console.WriteLine("You entered: " + userInput + " and " + userInput2 + ". The sum is: " + sum);
Console.ReadKey();