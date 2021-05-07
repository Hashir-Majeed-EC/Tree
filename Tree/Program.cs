using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new Tree(5);
            t.Add(10);
            t.Add(3);
            t.Add(14);
            t.Add(2);
            t.InOrderTraversal(t.root);
        }
    }
}
