using System;
using ArbolBinario;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTree
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestTreee()
        {
            Tree tree = new Tree();

            tree.addArrayIndex(new int[3] { 70, 84, 85 });
            tree.addArrayIndex(new int[4] { 70, 84, 78, 80 });
            tree.addArrayIndex(new int[4] { 70, 84, 78, 76 });
            tree.addArrayIndex(new int[4] { 70, 49, 54, 51 });
            tree.addArrayIndex(new int[4] { 70, 84, 37, 40 });
            tree.addArrayIndex(new int[4] { 70, 49, 37, 22 });


            Tree.Node n = tree.Ancestor(40, 78);

            Assert.AreEqual(70, n.index);

            n = tree.Ancestor(51, 37);

            Assert.AreEqual(49, n.index);

            n = tree.Ancestor(76, 85);

            Assert.AreEqual(84, n.index);

        }
    }
}
