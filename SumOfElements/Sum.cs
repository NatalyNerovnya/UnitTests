using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfElements
{
    public static class Sum
    {
        public static int CountSumOfElements(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException();
            if (array.Length == 0)
                return 0;

            int sum = 0;
            checked
            {
                foreach (int element in array)
                    sum += element;
                return sum;
            }
        }
    }
}
