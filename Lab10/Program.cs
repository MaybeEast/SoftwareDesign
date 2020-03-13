using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            INodeComponent root = new NodeComposite("*");

            INodeComponent rootL = new NodeLeaf(2);

            INodeComponent rootR = new NodeComposite("+");
            INodeComponent rootRL = new NodeLeaf(10);
            INodeComponent rootRR = new NodeLeaf(-5);
            rootR.addChildren(rootRL, rootRR);

            root.addChildren(rootL, rootR);

            Console.WriteLine("The value of root is " + root.getValue().ToString());
        }
    }
}
