using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11_Static_Variables
{
    class Alien
    {
        public static int Max_Lives = 99;

        public int X;
        public int Y;
        public int Lives;

        public Alien(int x, int y, int lives)
        {
            if (x < 0 || y < 0)
                throw new Exception("Invalid position");
            if (lives > Max_Lives)
                throw new Exception("Invalid lives");

            X = x;
            Y = y;
            Lives = lives;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
