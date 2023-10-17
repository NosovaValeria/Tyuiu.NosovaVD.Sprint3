using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint3.Task3.V30.Lib;
namespace Tyuiu.NosovaVD.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();
            char item = 'y';
            string value = "fyyklbtyn ygrc vfyyyyh";
            int res = ds.GetMaxCharCount(value, item);
            Assert.AreEqual(4, res);
        }
    }
}
