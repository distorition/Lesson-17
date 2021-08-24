using Algorithm.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class TreeSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public override void MakeSort()
        {
            var tree = new Tree<T>(items);//создаем новую коллекцию
            var sorted = tree.Inorder();//которая будет отсортированна после обхода
            items = sorted;// перезаписываем нашу коллекцию уже в отсортированном состоянии
        }
    }
}
