// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4];

int[] EnterRandomArray()
{
    for (int i = 0; i < 4; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    Console.WriteLine($"Array: [{String.Join(", ", array)}] -> {array[1] + array[3]}");
    return array;
}
EnterRandomArray();
