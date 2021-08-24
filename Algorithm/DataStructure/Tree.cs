using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.DataStructure
{
    class Tree<T> where T :IComparable
    {
        public Node<T> Root { get; private set; }
        public int count { get; private set; }
        public Tree() { }

        public Tree(IEnumerable<T> items)
        {
            foreach(var item in items)
            {
                Add(item);
            }
        }
        public void Add(T data)
        {
            if(Root== null)
            {
                Root = new Node<T>(data);
                count = 1;
                return;
            }
            Root.Add(data);
            count++;
        }
        //это обхооды
        public List<T> Preorder()
        {
            if(Root==null)
            {
                return new List<T>();
            }
            return Preorder(Root);
        }
        public List<T> Postorder()
        {
            if(Root==null)
            {
                return new List<T>();
            }
            return Postorder(Root);
        }
        public List<T> Inorder()
        {
            if(Root==null)
            {
                return new List<T>();
            }
            return Inorder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            var list = new List<T>();
            if(node!=null)
            {
                list.Add(node.Data);
                if(node.Left!=null)
                {
                    list.AddRange(Preorder(node.Left));
                }
                if(node.Right!=null)
                {
                    list.AddRange(Preorder(node.Right));
                }

            }
            return list;
        }
        private List<T> Postorder(Node<T> node)
        {
            var list = new List<T>();
            if (node != null)
            {
                
                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }
                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
                list.Add(node.Data);

            }
            return list;

        }

        private List<T> Inorder(Node<T> node)
        {

            var list = new List<T>();//берем нашу коллекцию
            if (node != null)//начинаем обходить наше дерево и берем от туда элементы
            {
     
                if (node.Left != null)//идем до тех пор пока не дойдем до конца 
                {
                    list.AddRange(Preorder(node.Left));// выбираем последнйи элемент 
                }
                list.Add(node.Data);//берем сам элемент

                if (node.Right != null)//а потом идем в право 
                {
                    list.AddRange(Preorder(node.Right));
                } 
            }
            return list;// потом возвращаем итоговую коллекцию после того как ее обошли 
        }

    }
}
