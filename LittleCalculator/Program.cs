// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hi! Let's calculate the sum of two numbers!");

//datatype variable name = value
double myNumber = 0.0;
double myNumber2 = 0;

//taking the first user input and converting it to an double
Console.WriteLine("Enter the first number!");
string userInput = Console.ReadLine();
myNumber = double.Parse(userInput);

//taking the second user input and converting it to an double
Console.WriteLine("Enter the second number!");
string userInput2 = Console.ReadLine();
myNumber2 = double.Parse(userInput2);

//calculating the sum and storing it in a variable
double sum = myNumber + myNumber2;

// rounding the sum to two decimal places
sum = Math.Round(sum, 2); 

//printing the sum to the console
Console.WriteLine($"You entered: {userInput} and {userInput2}. The sum is: {sum} ");
Console.ReadKey();