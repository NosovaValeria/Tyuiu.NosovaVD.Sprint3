using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NosovaVD.Sprint3.Task1.V16.Lib
{
    public class DataService : ISprint3Task1V16
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double x = 0.7;
            double res = 0;
            while (startValue <= stopValue)
            {
                res += (Math.Pow(x, 2) * Math.Sin(startValue)) + 1;
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
