namespace OldStyle
{
    class Program
    {
        //Field(or instance var) - sometimes even called global variable
        int myResult;
        static void Main(string[] args)
        {
            //Asking the user for input
            Console.WriteLine("Write a number and i will add 10 to it.");
            int num1 = int.Parse(Console.ReadLine());
            //Calling the method to add 10 to the number
            int myResult = AddTwoNumbers(num1, 10);
            //Displaying the result
            Console.WriteLine($"The sum is: {myResult}");
        }
        static int AddTwoNumbers(int value1, int value2){
            int myResult = value1 + value2;
            return myResult;
        }
        static int SubtractTwoNumbers(int value1, int value2){
            int myResult = value1 - value2;
            return myResult;
        }
    }
}
