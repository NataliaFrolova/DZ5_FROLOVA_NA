// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[4];

int evenNumber = 0;

int[] EnterRandomArray()
{
    for (int i = 0; i < 4; i++)
    {
        array[i] = new Random().Next(100, 999);
        if(array[i]%2==0) evenNumber++;
    }
    Console.WriteLine($"Array: [{String.Join(", ", array)}]");
    return array;
}
EnterRandomArray();
Console.WriteLine($"Number of even numbers in array: -> {evenNumber}");
