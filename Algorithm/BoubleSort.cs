using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
   public  class BoubleSort<T>: AlgorithmBase<T> where T:IComparable
    {
        public override void MakeSort()
        {
            var count = items.Count;
            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count-j - 1; i++)
                {
                    var a = items[i];
                    var b = items[i + 1];
                    if (a.CompareTo(b) == 1)
                    {
                       
                        Swap(i, i + 1);
                        CompareCount++;
                    }
                }
                
            }
        }
    }
}
