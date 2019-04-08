using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    public class Tree
    {
        public Node root;
        #region Constructures
        public Tree()
        {
            root = null;
        }

        #endregion

        public void addArrayIndex(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                addNode(array[i]);
            }
        }

        /// <summary>
        /// Método que adiciona un nodo al arbol
        /// </summary>
        /// <param name="index"></param>
        public void addNode(int index)
        {
            Node nodo = new Node(index);
            if (root == null) root = nodo;
            else
            {
                Node aux = root;
                while (aux != null)
                {
                    nodo.father = aux;
                    if (nodo.index > aux.index)
                    {
                        aux = aux.right;
                    }
                    else if (nodo.index < aux.index)
                    {
                        aux = aux.left;
                    }
                    else {
                        return;
                    }
                }
                if (nodo.index < nodo.father.index)
                {
                    nodo.father.left = nodo;
                }
                else
                {
                    nodo.father.right = nodo;
                }

            }
        }

        /// <summary>
        /// Muestra los elementos del arbol en orden (menor a mayor)
        /// </summary>
        /// <param name="node">Nodo raíz desde donde empieza a mostrar la lista</param>
        public void ShowTreeNode(Node node)
        {
            if (node != null)
            {
                ShowTreeNode(node.left);
                System.Console.WriteLine(String.Format($"indice { node.index } "));
                ShowTreeNode(node.right);
            }

        }

        /// <summary>
        /// Retorna el ancestro común entre los dos indices dados
        /// </summary>
        /// <param name="indexA">Primer indice para mostrar sus ancestro</param>
        /// <param name="indexB">Segundo indice para mostrar su ancestro</param>
        /// <returns></returns>
        public Node Ancestor(int indexA, int indexB)
        {
            if (root == null) return null;

            if (root.index == indexA || root.index == indexB) return root;

            int biggerValue = indexA > indexB ? indexA : indexB;
            int lowerValue = indexA < indexB ? indexA : indexB;

            Node aux = PosibleRoot(lowerValue, biggerValue);

            if (aux == null) return null;

            while (aux != null)
            {

                if (aux == null) return null;

                bool resultFindLeft = FindIfExistIndex(aux.left, lowerValue);
                bool resultFindRight = FindIfExistIndex(aux.right, biggerValue);

                if (resultFindLeft && resultFindRight) return aux;
                if (!resultFindLeft && !resultFindRight) return null;

                if (resultFindLeft) aux = aux.left;

                if (resultFindRight) aux = aux.right;

            }

            return null;

        }

        /// <summary>
        /// Retorna el nodo raiz posible para iniciar la busqueda del ancestro
        /// </summary>
        /// <param name="lowerValue"></param>
        /// <param name="biggerValue"></param>
        /// <returns></returns>
        private Node PosibleRoot(int lowerValue, int biggerValue)
        {
            Node aux = root;
            while (aux != null)
            {
                if (lowerValue < aux.index && biggerValue < aux.index)
                    aux = aux.left;
                else if (lowerValue > aux.index && biggerValue > aux.index)
                    aux = aux.right;
                else
                    return aux;
            }

            return null;
        }

        /// <summary>
        /// Busca si existe un indice a partir de un nodo
        /// </summary>
        /// <param name="node"> Nodo raiz a partir de la cuál hace la búsqueda</param>
        /// <param name="indexToSearch">Indice a buscar</param>
        /// <returns></returns>
        public bool FindIfExistIndex(Node node, int indexToSearch)
        {
            if (node == null) return false;

            if (node.index == indexToSearch)
                return true;

            if (indexToSearch > node.index && node.right != null)
            {
                return FindIfExistIndex(node.right, indexToSearch);
            }
            else if(node.left != null)
            {
                return FindIfExistIndex(node.left, indexToSearch);
            } 
            return false;

        }

        /// <summary>
        /// Clase Nodo
        /// </summary>
        public class Node
        {
            public Node father;
            public Node right;
            public Node left;
            public int index;
            public Node(int i)
            {
                index = i;
                right = null;
                left = null;
                father = null;
            }
        }
    }
}
