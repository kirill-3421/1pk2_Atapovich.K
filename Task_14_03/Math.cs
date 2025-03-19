using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_03
{
    public class Math
    {
        //метод класса - вычисление факториала
        public static long Factorial(int count)
        {
            if (count < 0)
            {
                return -1;
            }

            long result = 1;

            for(int i = 2; i <= count; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
