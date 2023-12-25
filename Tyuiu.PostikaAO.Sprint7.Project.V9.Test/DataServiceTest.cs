using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Tyuiu.PostikaAO.Sprint7.Project.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFilmsData()
        {
            string path = $@"C:\Users\sralr\source\repos\Tyuiu.PostikaAO.Sprint7\Tyuiu.PostikaAO.Sprint7.Project.V9\bin\Debug\FilmsData.csv";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);


        }
    }
}
