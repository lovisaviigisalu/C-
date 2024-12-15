// modifier returnType MethodName(Parameters){
//     Code block
// }
void MyFirstMethod(){
    Console.WriteLine("MyFirstMethod was called!");
}
//Calling the method
MyFirstMethod();

void writeSomething(string message){
    Console.WriteLine(message);
}
string user = "Frank";
//Calling the method
writeSomething("Something to write");
writeSomething(user);


int AddTwoNumbers(int value1, int value2){
    int sum = value1 + value2;
    return sum;
}
Console.WriteLine("Write a number and i will add 10 to it.");
int num1 = int.Parse(Console.ReadLine());
int mySum = AddTwoNumbers(num1, 10);
Console.WriteLine($"The sum is: {mySum}");