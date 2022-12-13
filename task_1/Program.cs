// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



void PositiveCount(int count,int[] array)
{
    
    for ( int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i] > 0 ) 
        {
            count++;
        }
    }
     Console.WriteLine($"{count} \t");
}

Console.Clear();
Console.Write("Введите числа: ");
string[] numbers = Console.ReadLine().Split(" "); 
int[] array = numbers.Select(int.Parse).ToArray();
Console.WriteLine(String.Join(", ", array));
int count = 0;
PositiveCount(count,array);