//  36. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел
Console.Clear();

void addNumbers(int[] array) // Функция добавления в массив рандом чисел.
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(100, 999);
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

int showEvenNumbers(int[] array) // Функция показа чёт чисел + вывод их количества.
{
    int index = 0;
    int size = array.Length;
    int count = 0;
    while (index < size)
    {
        if (array[index] % 2 == 0)
        {
            Console.Write(array[index] + " ");
            count++;
        }
        index++;
    }
    return count;
}

int showUnevenNumbers(int[] array) // Функция показа нечёт чисел + вывод их количества.
{
    int index = 0;
    int size = array.Length;
    int count = 0;
    while (index < size)
    {
        if (array[index] % 2 != 0)
        {
            Console.Write(array[index] + " ");
            count++;
        }
        index++;
    }
    return count;
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
Console.WriteLine("Чётные числа данного массива: ");
int countsForEven = showEvenNumbers(array);
if (countsForEven == 0) // Если количество цифр (count) в методе равен 0, значит чёт отсутствуют.
{
    Console.Write("Отсутствуют.");
}
Console.WriteLine();
Console.WriteLine("Количество чётных чисел: " + countsForEven);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Нечётные числа данного массива: ");
int countsForUnEven = showUnevenNumbers(array);
if (countsForUnEven == 0) // Если количество цифр (count) в методе равен 0, значит нечёт отсутствуют.
{
    Console.Write("Отсутствуют.");
}
Console.WriteLine();
Console.WriteLine("Количество нечётных чисел: " + countsForUnEven);
Console.WriteLine();