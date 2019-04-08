using ArbolBinario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeApiRest.Models
{
    public class Ancestor
    {
        /// <summary>
        /// Arbol
        /// </summary>
        public Tree InputTree { get; set; }

        public int IndexA { get; set; }

        public int IndexB { get; set; }
    }
}