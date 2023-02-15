// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции (Не индекс)
Console.Clear();

void addNumbers(int[] array, int firstNumber, int lastNumber)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(firstNumber, lastNumber);
        index++;
    }
}

void addFirstAndLast(int[] array, int firstNumber, int lastNumber)
{
    array[0] = firstNumber;
    array[array.Length - 1] = lastNumber;
}

void showArray(int[] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

int sumArray(int[] array)
{
    int index = 0;
    int size = array.Length;
    int sum = 0;
    while (index < size)
    {
        if (index % 2 == 0)
        {
            sum = sum + array[index];
        }
        index++;
    }
    return sum;
}

Console.Write("Введите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
if (arrayLength <= 0)
{
    Console.WriteLine("Размер массива не может быть равен 0 и меньше.");
    return;
}
int[] array = new int[arrayLength];

Console.Write("Введите желаемое начало массива: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите желамый конец массива: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());

Console.Clear();

addNumbers(array, firstNumber, lastNumber);
addFirstAndLast(array, firstNumber, lastNumber);

Console.WriteLine("Вышедший массив: ");
showArray(array);

Console.WriteLine();
int result = sumArray(array);
Console.WriteLine();
Console.WriteLine("Сумма чисел на нечётной позиции равна: " + result);
Console.WriteLine();