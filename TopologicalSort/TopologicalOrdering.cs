using System;
using System.Collections.Generic;
using System.Text;

namespace TopologicalSort
{
    public class TopologicalOrdering
    {
        //Stack<Vertex> stack;
        List<Vertex> vlist;
        public TopologicalOrdering()
        {
            //stack = new Stack<Vertex>();
            this.vlist = new List<Vertex>();

        }

        // GetTopologicalOrder_DFS
        public void DFS(Vertex vertex)
        {
            
            vertex.setVisited(true);

            foreach(Vertex v in vertex.getAdjacencyList())
            {
                if (!v.isVisited())
                {
                    v.setVisited(true);
                    DFS(v);
                }
            }

            //stack.Push(vertex);
            vlist.Add(vertex);

        }

        public List<Vertex> getList()
        {
            return this.vlist;
        }


        //public Stack<Vertex> getStack()
        //{
        //    return this.stack;
        //}

    }
}
