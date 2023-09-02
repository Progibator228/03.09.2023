void Array_Random(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1, 10);
    }
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        System.Console.Write($"{item} ");
    System.Console.WriteLine();
}

void SelectionSort (int [] array )
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1 ; j <  array.Length   ; j++)      
        {
            if (array [j] > array [minPosition ]) minPosition = j;

        }

        int temporary = array[i];
        array[i] = array [minPosition];
        array [minPosition] = temporary;

    }
}

System.Console.WriteLine("Введите размер масива");
int Number = Convert.ToInt32(Console.ReadLine());
int [] array = new int [Number];
Array_Random(array);
PrintArray(array);
SelectionSort(array);
System.Console.WriteLine("----------------------------------");
PrintArray(array);
