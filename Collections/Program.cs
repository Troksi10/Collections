// Arrays
using Collections;
using System.Collections;

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

// Jagged Array

int[][] jaggedArray = new int[3][];
jaggedArray[0] =new int[5] {2,3,5,7,9};
jaggedArray[1] = new int[3] { 2, 3, 5, };
jaggedArray[2] = new int[2] { 15, 16 };

// alternative way

int[][] jaggedArray2 = new int[][]
{
    new int[] {2,3,5,7,9},
    new int[] {1,2,3}
};

Console.WriteLine($"The value in the middle of the first entry is {jaggedArray2[0][2]}");

// Try to get all the values within the array onto the console

for(int i = 0; i < jaggedArray.Length; i++)
{
    Console.WriteLine("Element {0}",i);
    for (int j = 0;j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine("{0}", jaggedArray[i][j]);
    }
}

int[] studentsGrades = new int[] {15,22,8,12,7};
double averageResult = GetAverage(studentsGrades);

foreach (int grade in studentsGrades)
{
    Console.WriteLine($"{grade}");
}

Console.WriteLine($"The Average is {averageResult}");

// ArrayLists

// Declaring an ArrayList with undefined amount of object
ArrayList myArrayList = new ArrayList();

//Declaring an ArrayList with defined amount of object
ArrayList myArrayList2 = new ArrayList(100);

myArrayList.Add(25);
myArrayList.Add("Hello");
myArrayList.Add(13.37);
myArrayList.Add(13);
myArrayList.Add(132);
myArrayList.Add(25.14);
myArrayList.Add(13);

// Delete element with specific value from the arrayList
myArrayList.Remove(13);

// Delete element at Specific posititon

myArrayList.RemoveAt(0);

Console.WriteLine(myArrayList.Count);

double sum = 0;

foreach (object obj in myArrayList)
{
    if (obj is int)
    {
        sum += Convert.ToDouble(obj);
    }
    else if (obj is double)
    {
        sum += (double)obj;
    }
    else if (obj is string)
    {
        Console.WriteLine(obj);
    }

    Console.WriteLine(sum);

}

// Hashtables

Hashtable studentstable = new Hashtable();

Student stud1 = new Student(1, "Marija", 98);
Student stud2 = new Student(2, "Jovana", 77);
Student stud3 = new Student(3, "Darko", 43);
Student stud4 = new Student(4, "Marko", 55);

studentstable.Add(stud1.Id, stud1);
studentstable.Add(stud2.Id, stud2);
studentstable.Add(stud3.Id, stud3);
studentstable.Add(stud4.Id, stud4);

Student storedStudent1 = (Student) studentstable[stud1.Id];

foreach(DictionaryEntry entry in studentstable)
{
    Student temp = (Student)entry.Value;
    Console.WriteLine("Student ID:{0}",temp.Id);
    Console.WriteLine("Student NAME:{0}", temp.Name);
    Console.WriteLine("Student GPA:{0}", temp.GPA);
}

foreach (Student value in studentstable.Values)
{
    Console.WriteLine("Student ID:{0}", value.Id);
    Console.WriteLine("Student NAME:{0}", value.Name);
    Console.WriteLine("Student GPA:{0}", value.GPA);
}

Console.WriteLine("Student ID:{0}, NAME:{1}, GPA{2}",storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

// Challenge

Hashtable newStudentstable = new Hashtable();


Student[] students = new Student[5];
students[0] = new Student(1,"Denis",88);
students[1] = new Student(2, "Zarko", 97);
students[2] = new Student(6, "Elena", 65);
students[3] = new Student(1, "Stefan", 73);
students[4] = new Student(4, "Aleksandar", 58);

foreach (Student stud in students)
{
    if (!newStudentstable.ContainsKey(stud.Id))
        {
            newStudentstable.Add(stud.Id, stud);
        Console.WriteLine("Student with ID{0} was added",stud.Id);
    }
    else
    {
        Console.WriteLine($"Sorry,A Student with the same ID already exists ID: {stud.Id}");
    }
}

// Dictionaries

Employee[] employees =
{
    new Employee("CEO","Angela",95,200),
    new Employee("Manager","Ilija",33,25),
    new Employee("HR","Verica",30,22),
    new Employee("Secretary","Milena",28,18),
    new Employee("Lead Developer","Bojan",55,35),
    new Employee("Intern","Zlatko",22,8)
};

Dictionary<int, string> myDictionary = new Dictionary<int, string>()
{
    {1,"one" },
    {2,"two"},
    {3,"three"}

};

Dictionary<string, Employee> employeeDictionary = new Dictionary<string, Employee>();

foreach (Employee emp in employees)
{
    employeeDictionary.Add(emp.Role, emp);
}

string key = "CEO";
if (employeeDictionary.ContainsKey(key))
{
    Employee empl = employeeDictionary[key];
    Console.WriteLine($"Employee name : {empl.Name}, Role : {empl.Role}, Salary : {empl.Salary}");
}
else
{
    Console.WriteLine($"No Employee found this {key}");
}

Employee result = null;
// using TryGetValue() it returns true if operation was succesfull and false otherwise 

if(employeeDictionary.TryGetValue("Intern", out result))
{
    Console.WriteLine("Value Retrieved");

    Console.WriteLine($"Employee Name : {result.Name}");
    Console.WriteLine($"Employee Role : {result.Role}");
    Console.WriteLine($"Employee Age : {result.Age}");
    Console.WriteLine($"Employee Salary : {result.Salary}");
}else
{
    Console.WriteLine("The key does not exist");
}

Console.ReadLine();

static double GetAverage(int[] gradesArray)
{
    int size = gradesArray.Length;
    double average;
    int sum = 0;

    for (int i = 0; i < size; i++)
    {
        sum += gradesArray[i];
    }
    average = (double)sum / size;
    return average;
}

