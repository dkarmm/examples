// 35. Определить, присутствует ли в заданном массиве, некоторое число
Console.Clear();
void addNumbers(int[] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
}
void showNumbers(int[] array)
{
    int index = 0;
    int size = array.Length;
    while (index < size)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
bool findNumb(int []array, int number)
{
    int index = 0;
    int size = array.Length;
    while (index < size )
    {
        if (array[index] == number)
        {
            return true;
        }
        index++;
    }
    return false;
}
Console.Write("Введите размер массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];
Console.Write("Введите искомое число: ");
int findNumber = Convert.ToInt32(Console.ReadLine());
if (findNumber > arrayLength || findNumber < 1)
{
    Console.WriteLine("Искомое число не может находиться в массиве.");
    return;
}
addNumbers(array);
showNumbers(array);
Console.WriteLine();
bool result = findNumb(array, findNumber);
if(result == true)
{
    Console.WriteLine("Число присутствует.");
}
else
{
    Console.WriteLine("Число отсутствует.");
}