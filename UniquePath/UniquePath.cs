using System;
using System.Collections.Generic;

namespace UniquePath
{
    class UniquePath
    {
        private static int[,] GRID = new int[,]
                {
                    {2, 1, 0 },
                    {1, 0, 0 },
                    {1, 9, 0 }
                };

        /*
        {
                { 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 1, 1 },
                { 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1 },
                { 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0 },
                { 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 1, 1, 1 },
                { 1, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 1 },
                { 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }

        }; 
        */


        static void Main(string[] args)
        {


            var pathDistance = minDistence(GRID);

            var isFound = pathDistance < 0 ? false: true ;

            Console.WriteLine("Unique Path Found : " + isFound);
            Console.WriteLine("Path Distance : " + pathDistance);

            //Console.WriteLine(spf.ToString());


        }

        public class QItem{
            
            public int row;
            public int col;
            public int dist;

            public QItem(int row, int col, int dist)
            {
                this.row = row;
                this.col = col;
                this.dist = dist;
            }

        }

        public static int minDistence(int[,] grid)
        {
            // M and N
            int height = grid.GetUpperBound(0) + 1;
            int width = grid.GetUpperBound(1) + 1;

            // Source
            QItem source = new QItem(0, 0, 0);

            // Visited array
            bool[,] visited = new bool[height, width];


            // Init visited array and source
            for(int i=0; i<height; i++)
            {
                for(int j=0; j<width; j++)
                {
                    // Set to true for not possible to visit cells
                    if(grid[i, j] == 0)
                    {
                        visited[i, j] = true;
                    }

                    // Finding source
                    if(grid[i, j] == 2)
                    {
                        source.row = i;
                        source.col = j;
                    }
                }
            }

            // ---------------BFS------------
            
            Queue<QItem> queue = new Queue<QItem>();

            queue.Enqueue(source);
            visited[source.row, source.col] = true;

            while(queue.Count > 0)
            {
                var item = queue.Dequeue();

                if(grid[item.row, item.col] == 9)
                {
                    return item.dist;
                }

                // Up
                if (item.row - 1 >= 0 && visited[item.row-1, item.col] == false)
                {
                    var nextUp = new QItem(item.row - 1, item.col, item.dist + 1);
                    queue.Enqueue(nextUp);
                    visited[item.row - 1, item.col] = true;
                }

                // Down
                if (item.row + 1 < height && visited[item.row + 1, item.col] == false)
                {
                    var nextDown = new QItem(item.row + 1, item.col, item.dist + 1);
                    queue.Enqueue(nextDown);
                    visited[item.row + 1, item.col] = true;
                }

                // Left
                if (item.col - 1 >= 0 && visited[item.row, item.col - 1] == false)
                {
                    var nextLeft = new QItem(item.row, item.col - 1, item.dist + 1);
                    queue.Enqueue(nextLeft);
                    visited[item.row, item.col - 1] = true;
                }


                // Right
                if (item.col + 1 <width && visited[item.row, item.col+1] == false)
                {
                    var nextRight = new QItem(item.row, item.col + 1, item.dist + 1);
                    queue.Enqueue(nextRight);
                    visited[item.row, item.col + 1] = true;
                }



            }

            return -1;
        }


    }
}
