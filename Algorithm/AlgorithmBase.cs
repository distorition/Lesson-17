using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmBase<T>  where T: IComparable
    {
        public int SwapCount { get; protected set; } = 0;
        public int CompareCount { get; protected set; } = 0;
        public List<T> items { get; set; } = new List<T>();
        public event EventHandler<Tuple<T, T>> CompareEvent;
        public event EventHandler<Tuple<T, T>> SwopEvent;

        public AlgorithmBase(IEnumerable<T> Itemss)
        {
            items.AddRange(Itemss);
        }
        public AlgorithmBase() { }

        protected void Swap(int positionA, int positionB)
        {
            if(positionA<items.Count&&positionB<items.Count)
            {
                var temmp = items[positionA];
                items[positionA] = items[positionB];
                items[positionB] = temmp;

                SwapCount++;
            }
        }
        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwapCount = 0;
           
            timer.Start();
            MakeSort();
            timer.Stop();
            return timer.Elapsed;

        }
      

        public virtual void MakeSort()
        {
            items.Sort();
        }

        public int Compare(T a, T b)
        {
            CompareEvent?.Invoke(this, new Tuple<T, T>(a, b));
            CompareCount++;
            return a.CompareTo(b);
        }
    }
}
