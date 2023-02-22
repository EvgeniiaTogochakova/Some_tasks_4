// Задача 29: Напишите метод, который задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

void ReadAndPrintMassive()
{
    Console.Write("N = ");
    int n = int.Parse(Console.ReadLine());
    int[] array = new int[n];
    Console.WriteLine("Теперь последовательно вводите числа, которые будут в массиве");
    for (int i = 0; i < n; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("А теперь - внимание - на выходе ваш массив");
    Console.Write($"[");
    for (int position = 0; position < n - 1; position++)
    {
        Console.Write((array[position] + ", "));

    }
    Console.Write(array[n - 1]);
    Console.Write($"]");
}

Console.WriteLine("Введите, пожалуйста, количество тех чисел, которые вы хотите увидеть в виде массива");
ReadAndPrintMassive();

