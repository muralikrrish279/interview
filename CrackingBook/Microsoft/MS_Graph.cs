using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrackingBook.Utils;

namespace CrackingBook.Microsoft
{
    public class MS_Graph
    {
        public bool RouteBetweenNode(Graph<int> grph, GraphNode<int> start, GraphNode<int> end) {
            if (grph == null || start == null || end == null) {
                return false;
            }
            var que = new Utils.Queue<GraphNode<int>>();
            que.EnQueue(start);
            start.Visited = true;

            while (!que.IsEmpty())
            {
                var temp = que.DeQueue();
                foreach (var item in temp.adjacent)
                {
                    if (item.Visited == false) {
                        if (item.data == end.data) {
                            return true;
                        }
                        item.Visited = true;
                        que.EnQueue(item);
                    }
                }
            }

            return false;
        }
    }
}
