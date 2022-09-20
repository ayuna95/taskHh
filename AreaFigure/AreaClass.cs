using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigure
{
    public class AreaClass
    {
        /// <summary>
        /// Получаем площадь треугольника по трем сторонам
        /// </summary>
        /// <param name="a">Сторона a</param>
        /// <param name="b">Сторона b</param>
        /// <param name="c">Сторона c</param>
        /// <returns>Результат</returns>
        public double TriangleSThreeSides(double a, double b, double c)
        {
            double s = 0;
            double[] sides = {a,b,c};
            sortArray(sides);
            if (Math.Pow(sides[0],2) == Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2))
            {
                Console.WriteLine("Прямоугольноый треугольник");
                s = (sides[1] * sides[2]) / 2;
            } else
            {
                double p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            
            return s;
        }
        private T[] sortArray<T>(T[] arr)
        {
            T temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    double a = 0;
                    double b = 0;
                    double.TryParse(arr[i].ToString(), out a);
                    double.TryParse(arr[j].ToString(), out b);
                    if (a > b)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        /// <summary>
        /// Получаем площадь круга по радиусу
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public double CircleS(double r)
        {
            const double pi = 3.14;
            return pi*(r*r);
        }
    }
}
