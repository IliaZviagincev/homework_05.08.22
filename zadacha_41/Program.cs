// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

//func
int NumGet(int[] arr)
{
    int count = 0;
    foreach (int i in arr)
    {
        count += (i != 0) ? 1 : 0;
    }
    return count;
}
//code
Console.WriteLine("Введите числа через пробел");
int[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Console.WriteLine($"Чисел больше нуля: {NumGet(array)}");
