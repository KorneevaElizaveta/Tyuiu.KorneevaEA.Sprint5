using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KorneevaEA.Sprint5.Task5.V6.Lib;

namespace Tyuiu.KorneevaEA.Sprint5.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V6.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
            Assert.AreEqual(4.798, ds.LoadFromDataFile(path));
        }
    }
}
