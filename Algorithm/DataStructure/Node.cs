using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructure
{
    class Node<T> : IComparable where T : IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set;  }
        public Node(T data)
        {
            Data = data;
        }
        //public Node(T data,Node<T> left,Node<T> right)
        //{
        //    Data = data;
        //    Left = left;
        //    Right = right;
        //}

        public void Add(T data)
        {
            var node = new Node<T>(data);
            if(node.Data.CompareTo(data)==-1)
            {
                if(Left==null)
                {
                    Left = node;
                }
                else
                {
                    Left.Add(data);
                }
            }
            else
            {
                if(Right==null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
            {
                throw new ArgumentException("Нет совпадения");
            }
        }
    }
}
