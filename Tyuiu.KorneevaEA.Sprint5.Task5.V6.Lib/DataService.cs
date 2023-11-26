using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;        

namespace Tyuiu.KorneevaEA.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            double res;
            using (StreamReader reader = new StreamReader(path))
            {
                res = 0;
                int k = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    k += 1;
                    res += Convert.ToDouble(line);
                }
                res = res / k;
            }
            return Math.Round(res, 3);
        }
    }
}
