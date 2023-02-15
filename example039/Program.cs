// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void addNumbers (int [] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}
void showNumbers (int [] array)
{
    int index = 0;
    int size = array.Length;
    while (index<size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
void result(int[] array)
{
    int indexForFirst = 0;
    int size = array.Length;
    int indexForLast = size - 1;
    int result = 1;
    while (indexForFirst < indexForLast)
    {
        result = array[indexForFirst] * array[indexForLast];
        Console.Write(result + " ");
        indexForFirst++;
        indexForLast--;
    }
}

Console.Write("Введите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
if (arrayLength <= 0)
{
    Console.WriteLine("Размер массива не может быть равен 0 и меньше.");
    return;
}
int[] array = new int [arrayLength];

addNumbers(array);
showNumbers(array);
Console.WriteLine();
result(array);
Console.WriteLine();