using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 위에서부터 블럭이 떨어지는 것을 만들고 싶다.

enum BLOCKTYPE
{
    BT_I,
    BT_L,
    BT_J,
    BT_Z,
    BT_S,
    BT_T,
    BT_O,
}

class Block
{
    int X = 0;
    int Y = 0;
    string BlockType = "■";
    List<List<string>> BlockData = new List<List<string>>();

    TETRISSCREEN Screen = null;
    
    public Block(TETRISSCREEN _SCreen)
    {
        Screen = _SCreen;

        for (int y = 0; y < 4; y++)
        {
            BlockData.Add(new List<string>());
            for (int x = 0; x < 4; x++)
            {
                BlockData[y].Add("□");
            }

        }
    }

    private void Input()
    {
        if (false == Console.KeyAvailable)
        {
            return;
        }

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            case ConsoleKey.S:
                Y += 1;
                break;
            default:
                break;
        }
    }

    public void Move()
    {
        // 내가 어떤 키든 눌렀을 때만 실행
        if (Console.KeyAvailable)
        {
            Input();
        }
        Screen.SetBlock(Y, X, "■");
    }
}

