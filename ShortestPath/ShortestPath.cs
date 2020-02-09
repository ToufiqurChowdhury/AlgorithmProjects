using ShortestPath;
using System;

namespace TestProj
{
    public class ShortestPath
    {
        private static int[,] GRID = new int[,]
        {
            {1, 1, 0 },
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
            // Console.WriteLine("Hello World!");
            //ShortestPathFinder spf = new ShortestPathFinder(GRID);
            SPF spf = new SPF(GRID);

            var isFound = spf.findPath();
            
            Console.WriteLine("Path Found : " + isFound);
            
            Console.WriteLine(spf.ToString());

        }
    }

    public class ShortestPathFinder {

        static int TRIED = 2;
        static int PATH = 3;

        private int[,] grid;
        private int[,] map;

        private int height;
        private int width;

        public ShortestPathFinder(int [,] grid)
        {
            this.grid = grid;

            this.height = grid.GetUpperBound(0) + 1;
            this.width = grid.GetUpperBound(1) + 1;

            this.map = new int[height, width];
            
        }

        public bool findPath()
        {
            return traverse(0, 0);
        }

        private bool traverse(int i, int j)
        {
            // Base condition
            if (!isValid(i, j))
            {
                return false;
            }

            // Base condition
            if (isEnd(i, j))
            {
                map[i, j] = PATH;
                return true;
            }
            else
            {
                map[i, j] = TRIED;
            }

            // UP / NORTH
            if(traverse(i-1, j))
            {
                map[i - 1, j] = PATH;
                return true;
            }

            // EAST / RIGHT
            if(traverse(i, j + 1))
            {
                map[i, j + 1] = PATH;
                return true;
            }

            //DOWN / SOUTH
            if(traverse(i+1, j))
            {
                map[i + 1, j] = PATH;
                return true;
            }

            // LEFT / WEST
            if(traverse(i, j - 1))
            {
                map[i, j - 1] = PATH;
                return true;
            }

            return false;
        }

        private bool isEnd(int i, int j)
        {
            //return i == height - 1 && j == width - 1 ;

            //If terget = 9
            return grid[i, j] == 9;
        }

        private bool isValid(int i, int j)
        {
           
            if(inRange(i,j) && isOpen(i, j) && !isTried(i, j))
            {
                return true;
            }

            return false;
        }

        private bool inRange(int i, int j)
        {
            return inHeight(i) && inWidth(j);
        }

        private bool inHeight(int i)
        {
            return i >= 0 && i < height;
        }

        private bool inWidth(int j)
        {
            return j >= 0 && j < width;
        }

        private bool isOpen(int i, int j)
        {
            // Open if equals 1 or target or not zero;
            //return grid[i, j] == 1 || grid[i, j] == 9;
            return grid[i, j] != 0;
        }

        private bool isTried(int i, int j)
        {
            return map[i, j] == TRIED;
        }


        public string ToString()
        {
            String Str = "";

            //Str = "Height: " + height.ToString() + " and Width: " + width.ToString();

            for(var m = 0; m < height; m++)
            {
                for (var n = 0; n < width; n++)
                {
                    if (map[m, n] == PATH)
                    {
                        //Str += "Map["+ m + ", " + n + "]: " +  map[m,n].ToString() + "\n";
                        Str += "Map[ " + m + ", " + n + " ] \n";
                    }
                }
            }

            return Str;
        }
    }
}
