//Andrejs Tomsons CIS 237 assignment 4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {
        private int arraySize;
        private IComparable[] array;

        //takes in array and area of the array that is populated
        public MergeSort(IComparable[] array, int length)
        {
            this.arraySize = length;
            this.array = array;
            //mergesort is called from the constructor
            MergeSort_Recursive(this.array, 0, arraySize - 1);
        }

        public void DoMerge(IComparable[] numbers, int left, int mid, int right)
        {
            IComparable[] temp = new IComparable[arraySize];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left].CompareTo(numbers[mid]) <= 0)
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        public void MergeSort_Recursive(IComparable[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        } 
    }
}
