using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Array
{
    class SortArray: ISorting
    {
        public int[] TheArray { get; set; }
        public int TheArrayLength { get; set; }

        //the class has only default constractor that invisible and created at runtime


        public int[] arrayCreator()
        {
            int[] arr = new int[TheArrayLength];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = RandomNumberGenerator.NumberBetween(-1000, 1000);
            }
            TheArray = arr;
            return arr;
        }


        public void sortArray()
        {
            int tmp = TheArray[0];
            for (int i = 0; i < TheArray.Length - 1; i++)
            {
                for (int j = i + 1; j < TheArray.Length; j++)
                {
                    if (TheArray[i] > TheArray[j])
                    {
                        tmp = TheArray[i];
                        TheArray[i] = TheArray[j];
                        TheArray[j] = tmp;
                    }
                }
            }
        }



    }
}
