using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
   public class InsertSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public override void MakeSort()
        {
            for (int i = 1; i < items.Count; i++)
            {
                var temp = items[i];
                var j = i;
                while(j>1 && temp.CompareTo(items[j-1])==-1)
                {
                    items[j] = items[j - 1];
                    j--;
                    SwapCount++;
                    CompareCount++;
                }
                items[j] = temp;
            }
        }
    }
}
