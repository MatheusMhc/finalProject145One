using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.Business
{
    abstract class SortingAlgorithm
    {
        //protected void swap<T>(T[] array, int i, int j)
        //{
        //    T temp = array[i];
        //    array[i] = array[j];
        //    array[j] = temp;
        //}

        protected void printArray<T>(T[] array)
        {
            foreach (T i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        //public abstract void sort<T>(TableLayoutPanel arrayToBeSorted);
    }
}
