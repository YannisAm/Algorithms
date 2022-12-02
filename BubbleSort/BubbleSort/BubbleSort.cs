using System;

namespace BubbleSort
{
    public class BubbleSort
    {
        private int _length;
        private int _tmp;
        private bool _flag;
        private int[] _data;

        public BubbleSort(int[] data)                       //The constructor was initialized with an array of integers supplied by the user.
        {
            if(data.Length > 0)
            {
                _length = data.Length;                      //In _length and _data a value is being assigned.
                _data = data;
                
            }
        }

        public void Sort()
        {
            for (int i = 0; i < _length - 1; i++)           //We are starting to sort the array.
            {
                _flag = false;
                for (int j = 0; j < _length - 1 - i; j++)
                    if (_data[j] > _data[j + 1])            //Here, the array is being sorted. We are using the _flag, for an earlier exit when the array is being sorted before
                    {                                       //all the iterations are finished.
                        _flag = true;
                        _tmp = _data[j];
                        _data[j] = _data[j + 1];
                        _data[j + 1] = _tmp;
                    }
                if (_flag == false)                         //If an early exit occurs, we print the number of iterations. 
                {
                    Console.WriteLine("Early exit: " + (i + 1) + " iterations");
                    break;
                }
            }
        }

        public void Print()                                 //Here, the array is being printed.
        {
            Console.WriteLine("---------- size = " + _length + " ---------");
            for (int i = 0; i < _length; i++)
                Console.Write(_data[i] + " ");
            Console.WriteLine("\n---------------------------------------------------\n");
        }
    }
}