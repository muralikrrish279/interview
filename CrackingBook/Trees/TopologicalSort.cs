using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook
{
    
    public class TopologicalSort
    {
        public static void TOPOSort(GraphWithState<char> graph)
        {
            var stck = new Stack<GraphNodeWithState<char>>();
            foreach (var item in graph.nodes)
            {
                if(!DFS(item,stck)){
                    Console.WriteLine("Cycle Found");
                    return;
                }
            }

            while(!stck.IsEmpty()){
                Console.WriteLine(stck.Pop().data);
            }

            Console.ReadLine();

        }

        public static bool DFS(GraphNodeWithState<char> node, Stack<GraphNodeWithState<char>> stck)
        {
            if(node.State == States.Partial){
                return false;
            }

            if(node.State == States.Blank){
                node.State = States.Partial;
				foreach (var item in node.adjacent)
				{
					if (!DFS(item, stck))
					{
						return false;
					}
				}
				node.State = States.Visitied;
				stck.Push(node);  
            }

            return true;

        }

  //      static void Main(string[] args)
  //      {

  //          var graph = new GraphWithState<char>();
		//	var nodea = new GraphNodeWithState<char>('a');
		//	var nodeb = new GraphNodeWithState<char>('b');
		//	var nodec = new GraphNodeWithState<char>('c');
		//	var noded = new GraphNodeWithState<char>('d');
		//	var nodef = new GraphNodeWithState<char>('f');
		//	nodea.adjacent.Add(noded);
		//	nodeb.adjacent.Add(noded);
  //          nodef.adjacent.Add(nodeb);
  //          nodef.adjacent.Add(nodea);
		//	noded.adjacent.Add(nodec);
  //          noded.adjacent.Add(nodef);
  //          graph.nodes = new System.Collections.Generic.List<GraphNodeWithState<char>>(){nodea,nodeb,nodec,noded,nodef};
  //          TOPOSort(graph);

		//}

		public class GraphWithState<T>
		{
			public GraphWithState()
			{
				nodes = new System.Collections.Generic.List<GraphNodeWithState<T>>();
			}
			public System.Collections.Generic.List<GraphNodeWithState<T>> nodes;
		}

        public class GraphNodeWithState<T> 
        {

			public System.Collections.Generic.List<GraphNodeWithState<T>> adjacent;
			public T data;
			public GraphNodeWithState(T input)
			{
				data = input;
				adjacent = new System.Collections.Generic.List<GraphNodeWithState<T>>();
			}

            public States State
            {
                get;
                set;
            }
        }

		public enum States
		{
			Blank,
			Partial,
			Visitied
		}
    }
}
