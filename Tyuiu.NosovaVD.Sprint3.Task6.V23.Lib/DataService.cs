using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NosovaVD.Sprint3.Task6.V23.Lib
{
    public class DataService : ISprint3Task6V23
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int res = 0;
            for(int x = startValue; x <= stopValue; x++)
            {
                for(int d = 1; d <= x; d++)
                {
                    if (x % d == 0 && d < 11)
                    {
                        res++;
                    }
                }
            }
            return res;
        }
    }
}
