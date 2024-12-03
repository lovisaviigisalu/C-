// See https://aka.ms/new-console-template for more information

string question1 = "What is the capital city of France?";
string answer1 = "Paris";

string question2 = "What is 3+3?";
string answer2 = "6";

string question3 = "What color is the sky?";
string answer3 = "Blue";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1.ToLower()){
    Console.WriteLine("Correct!");
    score++;
} else {
    Console.WriteLine($"Incorrect, the correct answer is {answer1}");
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2.Trim().ToLower() == answer2.ToLower()){
    Console.WriteLine("Correct!");
    score++;
} else {
    Console.WriteLine($"Incorrect, the correct answer is {answer2}");
}

Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3.Trim().ToLower() == answer3.ToLower()){
    Console.WriteLine("Correct!");
    score++;
} else {
    Console.WriteLine($"Incorrect, the correct answer is {answer3}");
}

Console.WriteLine($"Your final score is {score}/3");
if (score == 3){
    Console.WriteLine("Congratulations! You passed the quiz.");
} else if (score > 0){
    Console.WriteLine("You passed the quiz, but you could be better.");
}
else {
    Console.WriteLine("Try again next time!");
}
Console.ReadKey();