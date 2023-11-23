using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint5.Task2.V1.Lib;
using System.IO;    

namespace Tyuiu.KorneevaEA.Sprint5.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.KorneevaEA.Sprint5\Tyuiu.KorneevaEA.Sprint5.Task2.V1\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
