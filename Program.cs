// 2D arrays
int[,] arr2D = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(arr2D[i,j] + " ");
    }

}

Console.WriteLine();

// Jagged arrays
int[][] jaggedArr = new int[2][];
jaggedArr[0] = new int[] { 1, 3, 5, 7, 9 };
jaggedArr[1] = new int[] { 2, 4, 6 };

for (int i = 0; i < jaggedArr.Length; i++)
{
    for (int j = 0; j < jaggedArr[i].Length; j++)
    {
        Console.Write(jaggedArr[i][j] + " ");
    }
}

Console.WriteLine();

// reversing array
int[] list = { 29, 15, 30, 98 };
int[] temp = list;
Console.Write("Original Array: ");
foreach (int i in list)
{
    Console.Write(i + " ");
}
Console.WriteLine();

Array.Reverse(temp);
Console.Write("Reversed Array: ");
foreach (int i in temp)
{
    Console.Write(i + " ");
}

Console.WriteLine();

//Find Highest Value in Array
int n, highest;
int[] arr = new int[25];

Console.WriteLine("Enter the number: ");
n = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the array elements: ");
for (int i = 0; i < n; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

highest = arr[0];
foreach (var number in arr)
{
if (number >highest)
    {
        highest = number;
    }
}

Console.WriteLine("The highest number in the array: " + highest);

