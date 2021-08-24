using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructure
{
    class Heap<T> where T:IComparable
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;

        public T Peak()
        {
            if(Count>0)
            {
                return items[0];
            }
            else
            {
                throw new ArgumentNullException(nameof(items), "Куча пустая");
            }
        }
        public Heap() { }

        public Heap(IEnumerable<T> items)
        {
            this.items.AddRange(items);//добавляем элементы
            for(int i=Count;i>=0;i--)
            {
                Sort(i);
            }
        }

        public void Add(T item)
        {
            items.Add(item);
            var curentIndex = Count - 1;
            var parentIndex = GetPareIndex(curentIndex);

            while(curentIndex>0&&items[parentIndex].CompareTo(items[curentIndex])==-1)
            {
                Swap(curentIndex, parentIndex);
                curentIndex = parentIndex;
                parentIndex = GetPareIndex(curentIndex);
            }
        }

        public T GetMax()
        {
            var result = items[0];//получаем элемент из начала
            items[0] = items[Count - 1];//удаляем элемент из начала и ставим элемент с самого конца
            items.RemoveAt(Count - 1);
            Sort(0);// балансируем наш массив
            return result;
        }

        private void Sort(int curentIndex)
        {

        }
    }
}
