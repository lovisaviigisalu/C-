int[,] array2DDecleration = new int[3, 3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

int[,,] array3DDecleration = new int[3, 3, 3];

string [,,] simple3DArray = 
{
    {
        {"000", "001", "002"},
        {"010", "011", "012"},
    },
    {
        {"100", "101", "102"},
        {"110", "111", "112"},
    }
};
Console.WriteLine(simple3DArray[0,1,1]);
int [,] array2DInizilized = {{1,2}, {3,4}};
// [1][2]
// [3][4]


string[,] ticTacToeField = {
    {"O", "O", "X"},
    { "O", "X", "O"},
    {"X", "O", "X"},
};

Console.WriteLine(ticTacToeField[2,2]);


//declare an array

// int[] myIntArray = [5, 34, 23, 66, 77];

// string[] weekdays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"  };

// Console.WriteLine("Lenght of the weekdays Array is: " + weekdays.Length);

// // for (int i = 0; i < weekdays.Length; i++){
// //     Console.WriteLine(weekdays[i]);
// // }

// foreach (var item in weekdays){
//     Console.WriteLine(item);
// }

// Console.ReadKey();