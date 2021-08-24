using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class CoctailSort_вставками_<T>:AlgorithmBase<T> where T:IComparable 
    {
        public override void MakeSort()
        {
            int left = 0;
            int right = items.Count - 1;

            while(left<right)
            {
                var sc = SwapCount;
                for (int i = left; i < right; i++)
                {
                    if(items[i].CompareTo(items[i+1])==1)
                    {
                        Swap(i, i + 1);
                        CompareCount++;
                    }
                    
                }
                right--;

                if (sc == SwapCount)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if(items[i].CompareTo(items[i-1])==-1)
                    {
                        Swap(i, i - 1);
                        CompareCount++;
                    }
                }
                left++;

                if(sc==SwapCount)
                {
                    break;
                }
            }

        }
    }
}
