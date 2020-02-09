using System;
using System.Collections.Generic;
using System.Text;

namespace TopologicalSort
{
    public class Vertex
    {
        private string name;
        private bool visited;
        private List<Vertex> adjacenciesList;

        public Vertex(string name)
        {
            this.name = name;
            this.adjacenciesList = new List<Vertex>();
        }

        public void addNeighbour(Vertex vertex)
        {
            this.adjacenciesList.Add(vertex);
        }

        public bool isVisited()
        {
            return visited;
        }

        public void setVisited(bool visited)
        {
            this.visited = visited;
        }

        public List<Vertex> getAdjacencyList()
        {
            return adjacenciesList;
        }

        public void ToString()
        {
            Console.WriteLine(this.name);
        }
    }
}
