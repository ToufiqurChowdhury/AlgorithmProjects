using System;
using System.Collections.Generic;

namespace TopologicalSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Topological Sort!");

            //Vertex vertex0 = new Vertex("A");
            //Vertex vertex1 = new Vertex("B");
            //Vertex vertex2 = new Vertex("C");
            //Vertex vertex3 = new Vertex("D");

            //vertex0.addNeighbour(vertex1);
            //vertex0.addNeighbour(vertex2);

            //vertex1.addNeighbour(vertex3);
            ////vertex1.addNeighbour(vertex4);

            //TopologicalOrdering topOrder = new TopologicalOrdering();

            //topOrder.DFS(vertex0);

            //foreach(Vertex v in topOrder.getList())
            //{
            //    v.ToString();
            //}


            
            // Complexity O(v+e)

            var packDependencies = new Dictionary<int, List<int>>();

            packDependencies.Add(0, new List<int>() { });  // Add 1 in List to cause Cycle for Error case
            packDependencies.Add(1, new List<int>() { });
            //packDependencies.Add(2, new List<int>() { 0 });
            //packDependencies.Add(3, new List<int>() { 1, 2});
            //packDependencies.Add(4, new List<int>() { 3 });


            PackageDependencies packaging = new PackageDependencies(packDependencies);

            var order = packaging.PackageOrder();

            PrintArray(order.ToArray());

        }

        public class PackageDependencies
        {
            public List<int> result;
            public List<int> visiting;
            public List<int> visited;
            public Dictionary<int, List<int>> dependencies;

            public PackageDependencies(Dictionary<int, List<int>> dependencies)
            {
                this.result = new List<int>();
                this.visiting = new List<int>();
                this.visited = new List<int>();
                this.dependencies = dependencies;
            }

            public List<int> PackageOrder()
            {
                try
                {
                    foreach (var n in this.dependencies.Keys)
                    {
                        DFS(n);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }

                return result;
            }
            
            public void DFS(int node)
            {
                if (this.visited.Contains(node))
                {
                    return;
                }

                this.visiting.Add(node);

                foreach( var n in dependencies[node])
                {
                    if (this.visiting.Contains(n))
                    {

                        throw new Exception("Cycle found in dependencies!!!");
                    }

                    if (!this.visited.Contains(n))
                    {
                        DFS(n);
                    }
                }

                this.visiting.Remove(node);
                this.visited.Add(node);
                this.result.Add(node);
            }

        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine("\n---------------------\n");
        }

    }
}
