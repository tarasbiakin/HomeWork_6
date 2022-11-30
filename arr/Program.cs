
float[]digits = new float[4];
string[] titles = {"Введите число b1","Введите число k1","Введите число b2","Введите число k2"};
for (int i = 0; i < titles.Length; i++)
{
    Console.WriteLine($"Введите число {titles[i]}");
    digits[i] = Convert.ToInt64(Console.ReadLine());
}

for (int i = 0; i < digits.Length; i++)
{
    Console.WriteLine($"Числа массива {digits[i]}");
}
