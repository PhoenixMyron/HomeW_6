void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
        array[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Вывод массива:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"[{string.Join(", ", array)}]");
    }
}
int MoveArray(int[] array)
{
    k = k % n;
    if (k > 0)
    {
    for (int i = 0; i < k; i++)
    arrayHelp[i] = array[array.Length - k + i];
    for (int i = 0; i < array.Length - k; i++)
    arrayHelp[k + i] = array[i];

        Console.WriteLine($"[{string.Join(", ", arrayHelp)}]");
    }
}


Console.Clear();
Console.Write("Введите кол-во элементов массивва: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] arrayHelp = new int[n];
int k = Convert.ToInt32(Console.ReadLine());

