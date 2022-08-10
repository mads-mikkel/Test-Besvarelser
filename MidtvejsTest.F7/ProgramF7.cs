int[] arr = new int[5] { 7, 15, 22, 38, 46 };
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

int j = 0;
while (j < arr.Length)
{
    Console.WriteLine(arr[j]);
    j++;
}


int negativeSummationResult = 0;
for (int i = arr.Length - 1; i >= 0; i--)
{
    negativeSummationResult -= arr[i];
}
Console.WriteLine(negativeSummationResult);

int oddNumberSum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 != 0)
    {
        oddNumberSum += arr[i];
    }
}
Console.WriteLine(oddNumberSum);