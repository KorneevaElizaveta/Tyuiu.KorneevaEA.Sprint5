using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KorneevaEA.Sprint5.Task5.V6.Lib;

namespace Tyuiu.KorneevaEA.Sprint5.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Корнеева Е. А. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Корнеева Елизавета Андреевна | АСОиУб-23-3                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V7.txt (файл взять из       *");
            Console.WriteLine("* архива согласно вашему варианту. Создать папку в ручную                 *");
            Console.WriteLine("* С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор целых  *");
            Console.WriteLine("* значений. Найти cреднее значение всех вещественных чисел в файле.       *");
            Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений        *");
            Console.WriteLine("* округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V6.txt";
            Console.WriteLine("Файл: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var result = ds.LoadFromDataFile(path);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
