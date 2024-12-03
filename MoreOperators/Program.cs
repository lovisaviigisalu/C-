Console.WriteLine("Give me a number:");
string input = Console.ReadLine();
int number;

bool isNumber = int.TryParse(input, out number);

if (isNumber)
{
    Console.WriteLine($"The number is {number}");
}
else
{
    Console.WriteLine("That's not a valid number!");
}


Console.WriteLine("Enter your age:");
string ageInput = Console.ReadLine();

Console.WriteLine("Enter your weight (kg):");
string weightInput = Console.ReadLine();

Console.WriteLine("Enter the room temperature (°C):");
string tempInput = Console.ReadLine();

// Try parsing the age
if (int.TryParse(ageInput, out int age) && age > 0)
{
    Console.WriteLine($"Your age is {age} years.");
}
else
{
    Console.WriteLine("Invalid age! Please enter a positive whole number.");
}
// Try parsing the weight
if (double.TryParse(weightInput, out double weight) && weight > 0)
{
    Console.WriteLine($"Your weight is {weight} kg.");
}
else
{
    Console.WriteLine("Invalid weight! Please enter a positive number.");
}

// Try parsing the temperature
if (float.TryParse(tempInput, out float temperature))
{
    Console.WriteLine($"The room temperature is {temperature}°C.");
}
else
{
    Console.WriteLine("Invalid temperature! Please enter a valid number.");
}
