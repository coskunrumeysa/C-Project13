//Beni Yaratan Elbet Yolumu Gösterir .Şuara 78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porject16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kk;
            int uk;
            int area;
            int perimeter;

            Console.WriteLine("Please enter short side of rectangle :");
            kk = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter long side of rectangle :");
            uk = Convert.ToInt16(Console.ReadLine());

            area = kk * uk;
            perimeter = 2*kk+2*uk;

            Console.WriteLine("Area of rectangle:" + " " + area);

            Console.WriteLine("Perimeter of rectangle:" + " " + perimeter);

            Console.Read();




        }
    }
}
