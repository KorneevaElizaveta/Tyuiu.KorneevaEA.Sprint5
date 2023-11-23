﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KorneevaEA.Sprint5.Task1.V16.Lib
{
    public class DataService : ISprint5Task1V16
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    File.AppendAllText(path, "0");
                    continue;
                }
                y = Math.Sin(x) + (2 * x) / 3 - Math.Cos(x) * 4 * x;
                y = Math.Round(y, 2);

                strY = Convert.ToString(y);

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }

            }
            return path;
        }
    }
}
