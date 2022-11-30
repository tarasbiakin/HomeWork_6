using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.WriteLine("Введите  чисело B1: ");
float b1 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите  чисело К1: ");
float k1 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите  чисело B2: ");
float b2 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите  чисело К2: ");
float k2 = Convert.ToInt64(Console.ReadLine());


(float, float) typle2 = StraightfloatX(b1,k1,b2,k2);
Console.WriteLine($"Координаты точки пересечени: ({typle2.Item1};{typle2.Item2})");

(float, float)StraightfloatX(float b11,float k11,float b22,float k22){
    float x =0; 
    float y =0;     
    x= (b22 -b11)/(k11-k22);
    y = (k11*(b22 -b11)/(k11-k22))+b11;
    return  (x,y);
}




// (float, float) typle =(5,10);
// Console.WriteLine(typle.Item1);
// Console.WriteLine(typle.Item2);

// (typle.Item1)=2+4+1+5+6;
// Console.WriteLine(typle.Item1);
