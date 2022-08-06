// Задача 45: Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.
int[] array = new int[6];
void GetArray()
{
    for (int i = 0; i < 6; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.WriteLine("Массив: {0}{1}{2}", "[", String.Join(", ", array), "]");
}
int[] CopyArray(int[] arr)
{
    int[] clone_array = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        clone_array[i] = arr[i];
    }
    return clone_array;
}

GetArray();
Console.WriteLine("Скопированный массив : " + "[" + String.Join(',', CopyArray(array)) + "]");