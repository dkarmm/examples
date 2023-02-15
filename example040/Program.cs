// 40. В Указанном массиве вещественных чисел найдите разницу между
//  максимальным и минимальным элементом
Console.Clear();
void addNumbers(int[] array) // Функция добавления в массив рандом чисел.
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(1, 15);
        index++;
    }
}
void showRandomNumbers(int[] array) // Функция показа этих чисел.
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
int findMinNumber (int [] array)
{
    int index = 0;
    int size = array.Length;
    int min = array[0];
    while (index < size)
    {
        if (array[index] < min)
        {
            min = array[index];
        }
        index++;
    }
    return min;
}
int findMaxNumber (int [] array)
{
    int index = 0;
    int size = array.Length;
    int max = array[0];
    while (index < size)
    {
        if (array[index] > max)
        {
            max = array[index];
        }
        index++;
    }
    return max;
}

Console.Write("Введите размер массива: "); // Введение размера массива от пользователя.
int arrayLength = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[] array = new int[arrayLength]; // Определение размера массива от итога ввода.
if (arrayLength == 0)
{
    Console.WriteLine("Массив пуст."); // Отмена операций, если пользователь ввёл 0 и меньше.
    return;
}
addNumbers(array); // Начало работы методов.
Console.WriteLine("Числа в массиве: ");
showRandomNumbers(array);
Console.WriteLine();
Console.WriteLine();
int minNumber = findMinNumber(array);
Console.WriteLine("Минимальный элемент: " + minNumber);
int maxNumber = findMaxNumber(array);
Console.WriteLine("Максимальный элемент: " + maxNumber);
int result = maxNumber - minNumber;
Console.WriteLine("Их разница равна: " + result);