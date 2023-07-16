// Arrays
int[] grades = new int[5];

grades[0] = 20;
grades[1] = 15;
grades[2] = 25;
grades[3] = 30;
grades[4] = 10;

Console.WriteLine($"Grades at index 0 is {grades[0]} ");

Console.WriteLine("Enter the grade of first student ");
string input = Console.ReadLine();
grades[0] = int.Parse( input );

Console.WriteLine($"Grade of first student is {grades[0]} ");

// Another way to initializing an array

int[] gradesOfMathStudents = { 20, 13, 12, 8, 9 };

// third way of initialiing an array

int[] gradesOfStudents = new int[] {15,20,8,12,5,6,17};

Console.WriteLine($"Length of math students is : {gradesOfMathStudents.Length}");

// Foreach loop

int[] nums = new int[10];
int counter = 0;

foreach(int i in nums)
{
    Console.WriteLine("Element{0} = {1}",counter,i);
}

// Create an array with 5 of your best friends
// Create a foreach loop which greets all of them

string[] myFriends = { "Bojan", "Stefan", "Kosta", "Martin", "Sasho" };


foreach (string name in myFriends)
{

    Console.WriteLine($"Hi there {name},my friend.");
}

int[] numbers = {1,2,3,4,5};

foreach (int number in numbers)
{
    Console.WriteLine($"Here are the number : {number}");
}

// Multi-Dimensional Array

// declare 2D Array
string[,] matrixOne;

// 3D Array
int[,,] threeD;

// two dimensional array

int[,] array2D = new int[,]
{
    {1,2,3},// row 0
    {4,5,6},// row 1
    {7,8,9} // row 2
};

Console.WriteLine($"Central value is {array2D[1,1]}");
Console.WriteLine(array2D[2,0]); // 7

int[,] matrix =
{
    {1,2,3},
    {4,5,6},
    {7,8,9}
};

foreach (int item in matrix)
{
    Console.Write(item + "");
}

Console.WriteLine("\n This is our 2D array printed using nested for loop");

// Nested for loop
// outer for loop
for (int i = 0; i < matrix.GetLength(0); i++)
{
    //inner for loop
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.WriteLine(matrix[i,j] + "");
    }
}

Console.ReadLine();

