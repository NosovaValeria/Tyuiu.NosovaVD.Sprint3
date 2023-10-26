using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NosovaVD.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            double y;
            int count = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                if((2-x) == 0)
                {
                    vallueArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round((Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x), 2);
                    vallueArray[count] = y;
                    count++;
                }             
            }
            return vallueArray;
        }
    }
}
