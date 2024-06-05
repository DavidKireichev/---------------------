//Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

int[] array = { 13, 29, 9, 45, 100 };

Console.WriteLine("Элементы массива, начиная с конца:");
PrintArrayReverse(array, array.Length - 1);

void PrintArrayReverse(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write(arr[index] + " ");
        PrintArrayReverse(arr, index - 1);
    }
}

