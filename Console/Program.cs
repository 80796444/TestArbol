using ArbolBinario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();

            tree.addArrayIndex(new int[3] { 70, 84, 85 });
            tree.addArrayIndex(new int[4] { 70, 84, 78, 80 });
            tree.addArrayIndex(new int[4] { 70, 84, 78, 76 });
            tree.addArrayIndex(new int[4] { 70, 49, 54, 51 });
            tree.addArrayIndex(new int[4] { 70, 84, 37, 40 });
            tree.addArrayIndex(new int[4] { 70, 49, 37, 22 });

            tree.ShowTreeNode(tree.root);
            System.Console.ReadKey();

            Tree.Node n = tree.Ancestor(40, 78);

            System.Console.WriteLine("Ancestro: " + n.index);

            n = tree.Ancestor(51, 37);

            System.Console.WriteLine("Ancestro: " + n.index);

            n = tree.Ancestor(76, 85);

            System.Console.WriteLine("Ancestro: " + n.index);

            System.Console.ReadKey();


        }
    }
}
