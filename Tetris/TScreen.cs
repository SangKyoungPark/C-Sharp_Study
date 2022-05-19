using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TETRISSCREEN
{
    List<List<string>> BlockList = new List<List<string>>();

    public void SetBlock(int _y, int _x, string _type)
    {
        BlockList[_y][_x] = _type;
    }

    public void Clear()
    {
        for (int y = 0; y < BlockList.Count; y++)
        {
            for (int x = 0; x < BlockList[y].Count; x++)
            {
                if (y == 0 || y == BlockList.Count - 1)
                {
                    BlockList[y][x] = "▣";
                    continue;
                }
                BlockList[y][x] = "□";
            }
        }
    }

    public void Render()
    {
        for (int y = 0; y < BlockList.Count; y++)
        {
            for (int x = 0; x < BlockList[y].Count; x++)
            {
                Console.Write(BlockList[y][x]);
            }
            Console.WriteLine("");
        }
    }

    public TETRISSCREEN(int _y, int _x)
    {

        for (int y = 0; y < _y; y++)
        {
            BlockList.Add(new List<string>());
            for (int x = 0; x < _x; x++)
            {
                BlockList[y].Add("□");
            }
        }
        for (int i = 0; i < BlockList[0].Count; i++)
        {
            BlockList[0][i] = "▣";
        }
        for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
        {
            BlockList[BlockList.Count - 1][i] = "▣";
        }
    }
}

