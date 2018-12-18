using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
  public  class Program
    {
        public class Node
        {
            public int Data;
            public Node Left; public
            Node Right;
            public void DisplayNode()
            {
                Console.Write(Data + " ");
            }
        }
        public  class BinarySearchTree
        {
            public Node root;
            public BinarySearchTree()
            {
                root = null;
            }
            public void Insert(int i)
            {
                Node newNode = new Node();
                newNode.Data = i;
                if (root == null)
                    root = newNode;
                else
                {
                    Node current = root;
                    Node parent;
                    while (true)
                    {
                        parent = current;
                        if (i < current.Data)
                        {
                            current = current.Left;
                            if (current == null)
                            {
                                parent.Left = newNode;
                                break;
                            }
                            else
                            {
                                current = current.Right;
                                if (current == null)
                                {
                                    parent.Right = newNode;
                                    break;
                                }
                            }
                        }
                    }
                }
            }

        }

        static void Main(string[] args)
        {
            BinarySearchTree binarysearch = new BinarySearchTree();

            Random uretec = new Random();
            for(int i=0;i<1001;i++)
            {
                int sayi = uretec.Next(0,9);
                binarysearch.Insert(sayi);

            }
            Console.ReadLine();
        }
    }
}


