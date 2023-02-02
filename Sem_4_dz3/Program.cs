// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



int[] array = GetBinaryArray(8);
Console.WriteLine($"[{String.Join("; ", array)}]");
int [] GetBinaryArray(int size)
{
    int[] resultArray = new int[size];
    for (int i = 0;  i< size; i++)
    {
resultArray[i] = new Random().Next(100);
    }
    return resultArray;
}

