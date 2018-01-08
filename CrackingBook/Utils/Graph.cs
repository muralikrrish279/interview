using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Utils
{
    public class Graph<T>
    {
        public Graph() {
            nodes = new List<GraphNode<T>>();
        }
        public List<GraphNode<T>> nodes;
    }

    public enum GraphTraversals
    {
       BFS,
       DFS
    }

    public class GraphNode<T>
    {
        public List<GraphNode<T>> adjacent;
        public T data;
        public bool Visited;
        public GraphNode(T input)
        {
            data = input;
            adjacent = new List<GraphNode<T>>();
        }

    }



}
