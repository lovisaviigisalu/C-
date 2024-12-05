// See https://aka.ms/new-console-template for more information


string message = "Hello, World!";
for (int count = 10; count >= 0; count--){
    
    Console.WriteLine($"counter is {count}");
    Console.WriteLine(message);
    Thread.Sleep(100);
}

string rocket = "  ^\r\n / \\\r\n/   \\\r\n|   |\r\n|___|\r\n / \\\r\n/___\\\r\n";

for (int i = 10; i >= 0; i--){
    Console.Clear();
    Console.WriteLine($"Counter is: {i}" );
    Console.WriteLine(rocket);
    rocket = "\n" + rocket;
    Thread.Sleep(800);
}
Console.WriteLine("Yay! Rocket has landed!");


int counter = 0;

while (counter < 10){
    Console.WriteLine($"Counter is: {counter}");
    counter++;
}

//The while loops

bool isGood = true;
while (isGood){
    Console.WriteLine("Life is good");
    isGood = false;
}



Console.WriteLine("Enter go or stay:");

string userChoice = Console.ReadLine();

while (userChoice == "go"){
    Console.WriteLine("Go for a mile!");
    Console.WriteLine("Wanna keep going? Enter go.");
    userChoice = Console.ReadLine();
}
Console.WriteLine("Stay home!");


Random random = new Random();

int secretNumber = random.Next(1, 101);
int userGuess = 0;
int guessCounter = 0;
Console.WriteLine("Guess a number between 1 and 100");
while (userGuess != secretNumber ){
    guessCounter++;
    userGuess = int.Parse(Console.ReadLine());
    if (userGuess < secretNumber){
        Console.WriteLine("Too low! Try higher.");;
    } else if (userGuess > secretNumber){
        Console.WriteLine("Too high! Try lower.  ");
    } else {
        Console.WriteLine($"You guessed the correct number! It took you {guessCounter} tries.  ");
    }
} 


Console.WriteLine("Welcome to the Adventure Game!");
Console.WriteLine("Enter your name:");
string playerName = Console.ReadLine();
Console.WriteLine("Choose your character type: Warrior, Wizard, or Archer");
string characterType = Console.ReadLine();

Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of a dark forest. ");
Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");
string choice1 = Console.ReadLine();

if (choice1.ToLower() == "enter"){
    Console.WriteLine("You bravery enter the forest.");

bool gameContinues = true;

while (gameContinues){
    Console.WriteLine("You come to the fork in the road. Go left or right:");
    string direction = Console.ReadLine();
    if (direction.ToLower() == "left"){
        Console.WriteLine("You find the hidden treasure chest!");
        gameContinues = false;
    } else {
        Console.WriteLine("Congratulations! You found a wild beast!");
        Console.WriteLine("Do you want to fight it? (yes/no)");
        string fightChoice = Console.ReadLine();
        if (fightChoice.ToLower() == "yes"){
            Random randomNumber = new Random();
            int luck = randomNumber.Next(1, 11);
            if (luck >= 5){
                Console.WriteLine("You beat the wild beast!");
                if (luck >= 8){
                    Console.WriteLine("The wild beast dropped a treasure chest!");
                    gameContinues = false;
                }
            } else{
                Console.WriteLine("You lost the battle! ");
                gameContinues = false;
            }
        } else {
            Console.WriteLine("WRONG CHOICE! ");
        }
    }
}
} else {
    Console.WriteLine("You decide to camp out and wait for the daylight. You will not find the treasure chest.");
}
Console.WriteLine("Game over!");
Console.WriteLine("Thank you for playing the game!");

//Do While Loops - post-test loop
//Do while loops dont need a condition to start. They run at least once and then check the condition.


int currentScore = 0;
int sum = 0;
int count1 = 0;
do {
    Console.WriteLine("Enter your students score. Enter -1 to finish:");
    currentScore = int.Parse(Console.ReadLine());
    if (currentScore != -1) {
        sum = sum + currentScore;
        count1++;
    }
} while (currentScore != -1);

int averageScore = sum / count1;
Console.WriteLine($"The average score is: {averageScore}");

