using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_Labovkin
{
    class Program
    {
        //объявим делегат, соответствующий сигнатуре методов
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            //создаем экземпляр делегата и связываем его с первым методом
            MyDelegate myDelegate = CircumFerence;
            //вызываем делегат,вызывающий метод CircumFerence, через переменную res
            double res = myDelegate(4);
            //выводим на консоль результат
            Console.WriteLine(res);

            //связываем делегат со вторым методом
            myDelegate = CircleArea;
            res = myDelegate(4);
            Console.WriteLine(res);

            //связываем делегат со третьим методом
            myDelegate = SphereVolume;
            res = myDelegate(4);
            Console.WriteLine(res);

            Console.ReadKey();
        }
        //напишем статический метод с лямбда выражением, для нахождения длины окружности
        static double CircumFerence(double r) => 2 * Math.PI * r;
        //напишем статический метод с лямбда выражением, для нахождения площади круга
        static double CircleArea(double r) => Math.PI * Math.Pow(r, 2);
        //напишем статический метод с лямбда выражением, для нахождения объема шара
        static double SphereVolume(double r) => 4 / 3 * Math.PI * Math.Pow(r, 3);
    }
}
