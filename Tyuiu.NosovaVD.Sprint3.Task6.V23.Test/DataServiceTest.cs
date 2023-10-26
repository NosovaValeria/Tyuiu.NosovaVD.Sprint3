using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint3.Task6.V23.Lib;
namespace Tyuiu.NosovaVD.Sprint3.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(34, res);
        }
    }
}
