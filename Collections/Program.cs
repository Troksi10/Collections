
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

Console.ReadLine();
