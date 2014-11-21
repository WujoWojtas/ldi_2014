using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LDI2014_demo.Logic
{
    public class QuickSortAlgorithm : ISortingAlgorithm
    {
        public void Sort(List<int> items)
        {
            Quicksort(items, 0, items.Count - 1);
        }

        private void Quicksort(List<int> items, int left, int right)
        {
            if (left < right)
            {
                int x = items[left];
                int tmpLeft = left;
                int tmpRight = right;

                while (true)
                {
                    while (items[tmpRight] > x)
                    {
                        tmpRight--;
                    }
                    while (items[tmpLeft] < x)
                    {
                        tmpLeft++;
                    }

                    if (tmpLeft < tmpRight)
                    {
                        int tmp = items[tmpLeft];
                        items[tmpLeft] = items[tmpRight];
                        items[tmpRight] = tmp;
                        tmpRight--;
                        tmpLeft++;
                    }
                    else
                    {
                        break;
                    }
                }

                Quicksort(items, left, tmpRight);
                Quicksort(items, tmpRight + 1, right);
            }
        }
























        //private void Quicksort(List<int> numbers, int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int x = numbers[left];
        //        int tmpLeft = left;
        //        int tmpRight = right;

        //        while (true)
        //        {
        //            while (numbers[tmpRight] > x)
        //            {
        //                tmpRight--;
        //            }

        //            while (numbers[tmpLeft] < x)
        //            {
        //                tmpLeft++;
        //            }

        //            if (tmpLeft < tmpRight)
        //            {
        //                int tmp = numbers[tmpLeft];
        //                numbers[tmpLeft] = numbers[tmpRight];
        //                numbers[tmpRight] = tmp;
        //                tmpLeft++;
        //                tmpRight--;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }

        //        Quicksort(numbers, left, tmpRight);
        //        Quicksort(numbers, tmpRight + 1, right);
        //    }
        //}
    }
}
