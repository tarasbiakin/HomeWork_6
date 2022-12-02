using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// bool Test(float k11,float k22)
// {
//  return k11==k22;
// }

// bool Test1(float b11,float k11,float b22,float k22)
// {
//  return ((k11==k22)&&(b11==b22));
 
// }

(float, float)StraightfloatX(float b11,float k11,float b22,float k22){
    float x =0; 
    float y =0;     
    x= (b22 -b11)/(k11-k22);
    y = (k11*x)+b11;
    return  (x,y);
}

try{
Console.WriteLine("Введите  чисело B1: ");
float b1 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите  чисело К1: ");
float k1 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите  чисело B2: ");
float b2 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите  чисело К2: ");
float k2 = Convert.ToInt64(Console.ReadLine());
if ((k1==k2)&&(b1==b2))
{
    throw new Exception($"совпадают");
}
if (k1==k2)
{
    throw new Exception ($"параллельны ");
}

// if ((k1==k2)&&(b1==b2))
// {
//      throw new IndexOutOfRangeException ($"совпадают ");
// }
// Console.WriteLine(Test(k1,k2) ? "Прямые параллельны " : "");
// Console.WriteLine(Test1(k1,k2,b1,b2) ? "Прямые совпадают " : "");

(float, float) typle2 = StraightfloatX(b1,k1,b2,k2);
Console.WriteLine($"Координаты точки пересечени: ({Math.Round(typle2.Item1,2)};{Math.Round(typle2.Item2,2)})");

}
catch(FormatException){Console.WriteLine($"Это не число");}

catch(Exception ex)
{Console.WriteLine($"Прямые {ex.Message}");
}



