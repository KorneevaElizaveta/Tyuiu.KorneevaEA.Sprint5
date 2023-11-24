using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorneevaEA.Sprint5.Task3.V1.Lib;

namespace Tyuiu.KorneevaEA.Sprint5.Task3.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Корнеева Е. А. | АСОиУб-23-3";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #1                                                                   *");
            Console.WriteLine("* Выполнила: Корнеева Елизавета Андреевна | АСОиУб-23-3                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить в       *");
            Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль.                      *");


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("* y(x)=(x^3-8)/(2x^2)                                                          *");
            Console.WriteLine("********************************************************************************");



            int x = 3;
            Console.WriteLine("x = " + x);


            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            string res = ds.SaveToFileTextData(x);


            Console.WriteLine("Фаил: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
