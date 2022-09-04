// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = new int[5];

int[] EnterRandomArray()
{
    for (int i = 0; i < 5; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    Console.WriteLine($"Array: [{String.Join(", ", array)}] -> {array[0] * array[4]} {array[1] * array[3]} {array[2]}");
    return array;
}
EnterRandomArray();
