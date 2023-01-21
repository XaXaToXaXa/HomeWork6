// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());
int num = 0;
int[] array = new int[size];
int count = 0;

int[] InPutArray(int[] array, int size, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (num < size)
        {
            Console.WriteLine($"Введите {num+1} элемент массива");
            array[num] = int.Parse(Console.ReadLine());
            num++;
        }
    }
    return array;
}
int CompareArrayNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.WriteLine();
InPutArray(array, size, num);
CompareArrayNumbers(array);
Console.WriteLine();
Console.WriteLine("Получился следующий массив: ");
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine($"Элементов больше 0 в нём {count}");