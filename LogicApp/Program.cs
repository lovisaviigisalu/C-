int month = 5;
string monthName = "";

switch (month) {
    case 1:
        monthName = "January";
        break;
    case 2:
        monthName = "February";
        break;
    case 3:
        monthName = "March";
        break;
    default:
        monthName = "Invalid month number!";
        break;

}


int num1 = 5;
int num2 = 7;
int age = 0;
string address = "";
//relational operators: < <= > >=
bool isGreater = num1 > num2;

//displays the result of the comparison
Console.WriteLine(isGreater);

bool isEqual = num1 == num2;
bool isNotEqual = num1!= num2;

Console.WriteLine("Please enter a whole number:");

if (num1 == int.Parse(Console.ReadLine())) {
    Console.WriteLine("Numbers are equal!");


    Console.WriteLine("Enter your age:");
    age = int.Parse(Console.ReadLine());
    if (age >= 18) {
        Console.WriteLine("Please enter your address, so we can send you a gift!");
        address = Console.ReadLine();
       Console.WriteLine($"Sending gift to {address}");
    } else {
        Console.WriteLine("You did not meet the age requirement! We won't send you a gift.");
    }
} else {
    Console.WriteLine("Numbers aren't equal!");
}


Console.WriteLine("Enter your age:");
int personage = int.Parse(Console.ReadLine());
bool isWithParents = false;

if (personage >= 18) {
    Console.WriteLine("Yay! Go party in the club");
} 
else if (personage >= 14 ){
    Console.WriteLine("Are you with your parents? y/n");
    string isWithParentsString = Console.ReadLine();

    if (isWithParentsString == "y" || isWithParentsString == "Y"){
        Console.WriteLine("Yay! Go party in the club with your parents!");
    } else {
        Console.WriteLine("No party for you today!");
    }
} 
else if (personage >=7 ){
    Console.WriteLine("Yay! Go party in the school!");
} 
else {
    Console.WriteLine("Yay! Go party in the kindergarden!");
}


//not raining
bool isRaining = false;
bool hasUmbrella = true;

//Logical opetators:
//AND &&
//OR ||
//NOT !

//or statements
//true OR true = true
//true OR false = true
//false OR false = false

// Checks if 'isRaining' is true (it is not true), and if so, prints "It's raining!"
if (isRaining){
    Console.WriteLine("It's raining!");
}

// Checks if 'hasUmbrella' is true (it is true), and if so, prints "I have my umbrella!"
if (hasUmbrella){
     Console.WriteLine("I have my umbrella!");
}

//checks if both conditions are true
if (isRaining && hasUmbrella){
    Console.WriteLine("No rain, but I have my umbrella!");
}

//checks if either condition is true
if (isRaining || hasUmbrella){
    Console.WriteLine("It's either raining or I have an umbrella!");
}

//checks if both conditions are true.
// the ! makes the condition true if it is false, and vice versa. So isRaining is now true
if (!isRaining && hasUmbrella){
    Console.WriteLine("It's raining and I have my umbrella!");
}

// Since isRaining is false and hasUmbrella is now false, the condition will not be met, so nothing will be printed.
if (isRaining || !hasUmbrella){
    Console.WriteLine("It's not raining so i do not need my umbrella!");
}

Console.ReadKey();