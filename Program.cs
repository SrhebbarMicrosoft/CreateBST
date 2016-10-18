using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateBST
{
    class Program
    {
        class BST
        {
            Node root = null;

            internal void Insert(string c)
            {
                Node newNode = new Node(c);
                if (root == null)
                {
                    root = newNode;
                    return;
                }

                Node temp = root;
                while (true)
                {
                    if (newNode.v < temp.v)
                    {
                        if (temp.left == null)
                        {
                            temp.left = newNode;
                            return;
                        }
                        temp = temp.left;
                    }
                    else
                    {
                        if (temp.right == null)
                        {
                            temp.right = newNode;
                            return;
                        }
                        temp = temp.right;
                    }
                }
            }

            internal void PrintSubtree(int k)
            {
                Node temp = root;

                while(true)
                {
                    if (temp.v == k)
                    {
                        PrintPreOrder(temp);
                        return;
                    }
                    else if (temp.v < k)
                    {
                        temp = temp.right;
                    }
                    else
                    {
                        temp = temp.left;
                    }
                }
            }

            private void PrintPreOrder(Node temp)
            {
                if (temp == null)
                    return;
                Console.WriteLine(temp.v);
                PrintPreOrder(temp.left);
                PrintPreOrder(temp.right);
            }
        }
        class Node
        {
            public Node left, right;
            public int v;
 
            public Node(string c)
            {
                this.v = int.Parse(c);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            BST bst = new BST();

            string[] tokens = Console.ReadLine().Split();
            foreach (string c in tokens)
            {
                bst.Insert(c);
            }

            int k = int.Parse(Console.ReadLine().Trim());
            bst.PrintSubtree(k);
        }
    }
}
