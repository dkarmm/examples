//  36. Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел
Console.Clear();

void addNumbers(int[] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(100, 999);
        index++;
    }
}

void showRandomNumbers(int[] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

void showEvenNumbers(int[] array)
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
            if (count == 0);
            {
                Console.Write("Отсутствуют.");
            }
        }
        index++;
    }
    
}

void showUnevenNumbers(int[] array)
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
    
}

Console.Write("Введите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arrayLength];


addNumbers(array);
Console.WriteLine("Числа в массиве: ");
showRandomNumbers(array);
Console.WriteLine();
Console.WriteLine("Чётные числа данного массива: ");
showEvenNumbers(array);
Console.WriteLine();
Console.WriteLine("Нечётные числа данного массива: ");
showUnevenNumbers(array);
Console.WriteLine();




