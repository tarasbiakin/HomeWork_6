// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


// bool Test(int num)
// {
//  return num >0;
// }

int[] CreateArrayInt(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите  чисело: ");
        int number = Convert.ToInt32(Console.ReadLine());
        arr[i] = number;
    }
    return arr;
}

int ArrayIntZero(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) res++;
    }
    return res;
}


void PrintArray(int[] arr, string beginStr, string separatorElems, string endstr)
{
    Console.Write(beginStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}{separatorElems} ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(endstr);
}
try
{
    Console.WriteLine("Введите кличество чисел: ");
    int number = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine(Test(number) ? "" : "Количество чисел не может быть отрицательным");

    int[] array = CreateArrayInt(number);

    PrintArray(array, "", " ", "");
    int result = ArrayIntZero(array);
    Console.WriteLine();
    Console.WriteLine($"Чисел меньше нуля: {result}");
}
catch (FormatException) { Console.WriteLine($"Это не число"); }
catch (OverflowException)
{
    Console.WriteLine($"Число не может быть меньше нуля");
}