using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithm.SortingAlgorithms
{
    internal class SelectionSort : Business.SortingAlgorithm
    {
        public void sort(TableLayoutPanel arrayToBeSorted)
        {
            int smallestIndex;

            for (int i = 0; i < arrayToBeSorted.ColumnCount; i++)
            {
                smallestIndex = i;
                for (int j = i + 1; j < arrayToBeSorted.ColumnCount; j++)
                {
                    Label a = (Label) arrayToBeSorted.GetControlFromPosition(j, 0);
                    Label b = (Label) arrayToBeSorted.GetControlFromPosition(smallestIndex, 0);

                    if (int.Parse(a.Text) < int.Parse(b.Text)) smallestIndex = j;
                }

                if (smallestIndex != i) swap(arrayToBeSorted, smallestIndex, i);
            }

        }

        protected void swap(TableLayoutPanel array, int i, int j)
        {
            Control temp =  array.GetControlFromPosition(i, 0);
            Control temp2 = array.GetControlFromPosition(j, 0);
            array.SetColumn(temp, j);
            array.SetColumn(temp2, i);
            //array.Controls.Add(array.GetControlFromPosition(j, 0), i, 0);
            //array.Controls.Add(temp, j, 0);
            //System.Threading.Thread.Sleep(1000);
        }
    }
}
