using System;
using System.Collections.Generic;
using System.Text;

namespace ShortestPath
{
    public class SPF
    {
        static int TRIED = 2;
        static int PATH = 3;

        private int[,] grid;
        private int[,] map;

        private int height;
        private int width;

        public SPF(int[,] grid)
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

        public bool traverse(int i, int j)
        {
            //Base case
            if (!isValid(i, j))
            {
                return false;
            }

            //Base case
            if(isEnd(i, j))
            {
                map[i, j] = PATH;
                return true;
            }
            else
            {
                map[i, j] = TRIED;
            }

            // Up
            if(traverse(i-1, j))
            {
                map[i - 1, j] = PATH;
                return true;
            }

            // Right
            if(traverse(i, j + 1))
            {
                map[i, j + 1] = PATH;
                return true;
            }

            // Down
            if(traverse(i+1, j)) {
                map[i + 1, j] = PATH;
                return true;
            }

            // Left
            if(traverse(i, j - 1))
            {
                map[i, j - 1] = PATH;
                return true;
            }

            return false;

        }

        public bool isEnd(int i, int j)
        {
            //return i == height && j == width;
            return grid[i, j] == 9;
        }

        public bool inRange(int i, int j)
        {
            return inHeight(i) && inWidth(j);
        }

        public bool inHeight(int i)
        {
            return i >= 0 && i < height;
        }

        public bool inWidth(int j)
        {
            return j >= 0 && j < width;
        }

        public bool isOpen(int i, int j)
        {
            return grid[i, j] != 0;
        }

        public bool isTried(int i, int j)
        {
            return map[i, j] == TRIED;
        }

        public bool isValid(int i, int j)
        {
            if(inRange(i, j) && isOpen(i, j) && !isTried(i, j))
            {
                return true;
            }

            return false;
        }

        public string ToString()
        {
            string str = "";
            for(int i=0; i<height; i++)
            {
                for(int j=0; j<width; j++)
                {
                    if (map[i, j] == PATH) {
                        str += "[" + i + ", " + j + "]\n";
                    }
                }
            }

            return str;
        }

    }
}
