using ArbolBinario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TreeApiRest.Models;
using static ArbolBinario.Tree;

namespace TreeApiRest.Controllers
{
    public class TreeController : ApiController
    {

        private static ICollection<Tree> trees;

        public TreeController()
        {
            if(trees == null)
                trees = new List<Tree>();
        }

        /// <summary>
        /// Método para adicionar un arbol
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [Route("tree/{value}")]
        [HttpPost]
        public bool Post(int value)
        {
            try
            {
                if (trees.Any(p => p.root.index == value)) return true;
                Tree tree = new Tree();
                tree.addNode(value);
                trees.Add(tree);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Método para agregar un nodo a un arbol
        /// </summary>
        /// <param name="root">Identificador del root del arbol</param>
        /// <param name="node">Nodo a adicionar</param>
        /// <returns></returns>
        [Route("tree/{root}/{node}")]
        [HttpPut]
        public bool Put(int root, int node)
        {
            try
            {
                Tree tree = trees.First(p => p.root.index == root);
                tree.addNode(node);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Retorna el ancestro común de dos numero en el arbol
        /// </summary>
        /// <param name="root"></param>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        [Route("tree/{root}")]
        [HttpGet]
        public int? Ancestor(int root, [FromUri]int node1, [FromUri]int node2)
        {
            try
            {
                Tree tree = trees.First(p => p.root.index == root);
                Node ancestor = tree.Ancestor(node1, node2);
                return ancestor.index;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
