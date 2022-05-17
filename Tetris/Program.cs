using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum TBLOCK
{
    WALL,
    VOID,
    BLOCK,
}

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            TScreen NewSC = new TScreen(10, 15);
            Block NewBlock = new Block();


            NewSC.Render();

            Console.ReadKey();
        }
    }
}
