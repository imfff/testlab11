using static System.Console;

Console.WriteLine("Hello!Fu Hong!");
Console.WriteLine("Version: {0}", Environment.Version.ToString());

// First string array
string[] names;
names = new string[4];
names[0] = "MMichael"; 
names[1] = "Sarah";
names[2] = "William";
names[3] = "Emma";

// Second string array
string[] names2 = new[] { "Michael", "Sarah", "William", "Emma" };

// Looping through names
for (int i = 0; i < names2.Length; i++)
{
   Console.WriteLine(names2[i]);
}

// 2D array
string[,] grid1 = new[,] 
{
   { "North", "South", "East", "West" },
   { "Spring", "Summer", "Fall", "Winter" },
   { "Apple", "Banana", "Cherry", "Date" }
};

Console.WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
Console.WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
Console.WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
Console.WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
   for (int col = 0; col <= grid1.GetUpperBound(1); col++)
   {
       Console.WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
   }
}

// Alternative syntax
string[,] grid2 = new string[3,4];
grid2[0, 0] = "North";
grid2[2, 3] = "Date";

// Jagged array
string[][] jagged = new[]
{
   new[] { "Red", "Green", "Blue" },
   new[] { "Monday", "Tuesday", "Wednesday", "Thursday" },
   new[] { "Coffee", "Tea" }
};

Console.WriteLine("Upper bound of array of arrays is: {0}", jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
   Console.WriteLine("Upper bound of array {0} is: {1}",
       arg0: array,
       arg1: jagged[array].GetUpperBound(0));
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
   for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
   {
       Console.WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
   }
}

// Pattern matching with arrays
int[] sequentialNumbers = new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
int[] oneTwoNumbers = new int[] { 1, 2 };
int[] oneTwoTenNumbers = new int[] { 1, 2, 20 };
int[] oneTwoThreeTenNumbers = new int[] { 1, 2, 3, 20 };
int[] primeNumbers = new int[] { 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };
int[] fibonacciNumbers = new int[] { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
int[] emptyNumbers = new int[] { };
int[] threeNumbers = new int[] { 6, 8, 10 };
int[] sixNumbers = new int[] { 5, 10, 15, 20, 25, 30 };

Console.WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
Console.WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
Console.WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
Console.WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
Console.WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
Console.WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
Console.WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
Console.WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
Console.WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
   [] => "Empty array",
   [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
   [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
   [1, 2] => "Contains 1 then 2.",
   [int item1, int item2, int item3] => 
       $"Contains {item1} then {item2} then {item3}.",
   [0, _] => "Starts with 0, then one other number.",
   [0, ..] => "Starts with 0, then any range of numbers.",
   [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
   [..] => "Any items in any order.",
};