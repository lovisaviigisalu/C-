// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//declare a string variable and assign a value
string myFriendName;
myFriendName = "Oskar";
Console.WriteLine(myFriendName);

//defining s variable
string petsName;

//initialize the variable with a value
petsName = "Buddy";
Console.WriteLine($"My pets name is: {petsName}");
//overwrite the value of the variable
petsName = "Max";
Console.WriteLine($"My pets name is: {petsName}");

//overwrite the value of the variable
myFriendName = "Jane";
Console.WriteLine(myFriendName);


//String manipulation with string formatting

int number = 10;
double price = 25.99;
string name = "Bob";
//String interpolation
Console.WriteLine($"The number is {number}");
//String concatenation
Console.WriteLine("The number is " + number);
//String formatting
Console.WriteLine("The number is {0}, the price is {1} and my name is {2}", number, price, name);
Console.ReadLine();