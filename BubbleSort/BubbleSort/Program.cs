using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] data = { 2, 4, 80, -250, -2, -253, 125, 352 };
            BubbleSort sort = new BubbleSort(data);
            sort.Print();
            sort.Sort();
            sort.Print();
        }
    }
}
