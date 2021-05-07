using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    class Tree
    {
        public Node root;
        public Tree(int val)
        {
            root = new Node(val);
        }

        public void InOrderTraversal(Node current)
        {
            if (current != null)
            {
                InOrderTraversal(current.left);
                Console.WriteLine(current.val);
                InOrderTraversal(current.right);
            }
        }

        public void PostOrderTraversal(Node current)
        {
            if (current != null)
            {
                InOrderTraversal(current.left);
                InOrderTraversal(current.right);
                Console.WriteLine(current.val);
            }
        }

        public void PreOrderTraversal(Node current)
        {
            if (current != null)
            {
                Console.WriteLine(current.val);
                InOrderTraversal(current.left);
                InOrderTraversal(current.right);             
            }
        }
        public bool Add(int num)
        {
            bool added = false;
            Node newNode = new Node(num);
            Node currentNode = root;


            while (!added)
            {
                if (num < currentNode.val)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else if (num > currentNode.val)
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
                else
                {
                    return false;
                }
            }
            return added;
        }
    }
}
