using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
   public  class ShallSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public override void MakeSort()
        {
            var step = items.Count / 2;

            while(step>0)
            {
                for(int i=step;i<items.Count;i++)//идем  по всем элементам начиная с шага 
                    //при помощи шага мы разбиваем наш массив на группы 
                    //а потом их сравниваем 
                {
                    int j = i;
                    while((j>=step) && Compare(items[j-step],items[j])==1)// и во внутренним цикле запускаем проверку 
                    {//при поощи метода Compare сравниваем два элемента 
                        Swap(j - step, j);//а тут мы меняем элементы местами 
                        j -= step;
                    }
                }
                step /= 2;
            }
        }
    }
}
