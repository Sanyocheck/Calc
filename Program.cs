using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqrt_uravn
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!File.Exists("Source.txt"))
            {
                Console.WriteLine("Файл не найден");
                Console.ReadKey();
                return;
            }
            string s = File.ReadAllText("Source.txt");
            s = s.Replace(" ", "");
            
            int count = 0;
            string kv = string.Empty;
            string kv1 = string.Empty;
            string kv2 = string.Empty;
            while(s[count] != 'A')
            {

                kv += s[count];
                count++;
            }
            count++;
            while(s[count] != 'B')
            {
                kv1 += s[count];
                count++;
            }
            count++;
                      while (s[count] != 'C')
            {
                kv2 += s[count];
                count++;
            }
            Console.WriteLine("Уравнение: {0}{1}{2}",kv,kv1,kv2);
            if (kv.Contains("+"))
            {
                kv = kv.Replace("+", "");
            }
            if(kv1.Contains("+"))
            {
                kv1 = kv1.Replace("+", "");
            }
            if(kv2.Contains("+"))
            {
                kv2.Replace("+", "");
            }
            
            
            double a = double.Parse(kv);
            double b = double.Parse(kv1);
            double c = double.Parse(kv2);
           double disc = Math.Pow(b,2) - 4*(a*c);
            double res;
            if(disc < 0)
            {
                Console.WriteLine("D = {0}\n Нет корней",disc);
                Console.ReadKey();
                return;
            }
            else if(disc == 0)
            {
                res = -b / 2 * a;
                Console.WriteLine("D = 0\n X = {0}", res);
                Console.ReadKey();
                return;
            }
            else
            {
                double x1= (-b + Math.Sqrt(disc))/2*a;
                double x2 = (-b - Math.Sqrt(disc)) / 2 * a;
                Console.WriteLine("D = {0}\n X1 = {1}\n X2 = {2}", disc,x1,x2);
                Console.ReadKey();
                return;

            }

        }
    }
}
