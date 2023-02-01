/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int InputQuantityOfNumbers(string text)
{
    System.Console.WriteLine(text);
    int M = Convert.ToInt32(Console.ReadLine());
    return M;
}

int InputNumbers(int M)
{
    int count = 0;
    int[] array = new int[M];
    for (int i = 1; i <= M; i++)
    {
        System.Console.WriteLine($"Введите {i} число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i-1] = num;
        if (num > 0)
        {
            count++;
        }
    }
    System.Console.WriteLine("[" + string.Join("; ", array) + "]");
    return count;
}


int M = InputQuantityOfNumbers("Введите число М: ");
System.Console.WriteLine($"Количество чисел больше 0 из {M} введенных пользователем, равно {InputNumbers(M)}");