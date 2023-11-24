using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint5.Task3.V1.Lib;

using System.IO;


namespace Tyuiu.KorneevaEA.Sprint5.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.KorneevaEA.Sprint5\Tyuiu.KorneevaEA.Sprint5.Task3.V1\bin\Debug\\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
