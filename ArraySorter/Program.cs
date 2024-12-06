int[] numbers = {90, 12, 89, 23, 78, 34, 67, 45, 70};

Console.WriteLine("An array before sorting:");
PrintArray(numbers);

ArraySort(numbers);

Console.WriteLine("An array after sorting:");
PrintArray(numbers);

static void PrintArray(int[] array) 
{ 
    foreach(int num in array) 
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

static void ArraySort(int[] array) 
{ 
    for(int i = 0; i < array.Length - 1; i++) 
    {
        int minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        { 
            if (array[j] < array[minIndex]) 
            { 
                minIndex = j;
            }
        }

        int placeholder = array[minIndex];
        array[minIndex] = array[i];
        array[i] = placeholder;
    }
}