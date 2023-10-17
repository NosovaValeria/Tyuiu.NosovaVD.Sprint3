using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.NosovaVD.Sprint3.Task3.V30.Lib
{
    public class DataService : ISprint3Task3V30
    {
        public int GetMaxCharCount(string value, char item)
        {
            int k = 0;
            int max = 0;
            foreach(char i in value)
            {
                if(i == item)
                {
                    k++;
                }
                else
                {
                    max = k;
                    k = 0;
                }
            }
            return max;
        }
    }
}
