using ExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.ViewModels
{
    public class Graph
    {
        public Dictionary<Node, List<Node>> Graph { get; set; }

        public Graph()
        {
            Graph = new Dictionary<Node, List<Node>>();
            Graph.Add(new Node()
            {

            });
        }
    }
}
