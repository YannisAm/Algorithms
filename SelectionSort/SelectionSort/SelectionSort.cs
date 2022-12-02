using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SelectionSort
{
    public class SelectionSort
    {
        private int[]? _data;                               //The variables and the array are being initialized here.
        private int _length;
        private int _tmp;
        private int _minPos;
        public SelectionSort(int[] data)
        {
            if(data.Length > 0)                             //If, there are elements inside the array, then we can assign values to _data and _length.
            {
                _data = data;
                _length = _data.Length;
            }
        }

        public void Sort()                                 //The sorting algorithm finds the position of the element that has the minimum value and puts it in the first position.
        {
            for (int i = 0; i < _length - 1; i++)
            {
                _minPos = i;
                for (int j = i + 1; j < _length; j++)
                {
                    if (_data[j] < _data[_minPos])
                    {
                        _minPos = j;
                    }
                }
                if (_minPos != i)
                {
                    _tmp = _data[_minPos];
                    _data[_minPos] = _data[i];
                    _data[i] = _tmp;
                }
            }
        }

        public void Print()                             //The array is being printed.
        {
            Console.WriteLine("---------- size = " + _length + " ---------");
            for (int i = 0; i < _length; i++)
            {
                Console.Write(_data[i] + " ");
            }
            Console.WriteLine("\n---------------------------------------------------\n");
        }
    }
}
