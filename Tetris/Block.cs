using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 위에서부터 블럭이 떨어지는 것을 만들고 싶다.

enum BLOCKDIR
{
    BD_T,
    BD_R,
    BD_B,
    BD_L,
    BD_MAX,
}

enum BLOCKTYPE
{
    BT_I,
    BT_L,
    BT_J,
    BT_Z,
    BT_S,
    BT_T,
    BT_O,
    BT_MAX,
}

partial class Block
{
    int X = 0;
    int Y = 0;
    string[][] Arr = null;
    //List<List<string>> BlockData = new List<List<string>>();

    TETRISSCREEN Screen = null;
    
    public Block(TETRISSCREEN _SCreen)
    {
        Screen = _SCreen;
        DataInit();
        SettingBlock(BLOCKTYPE.BT_T, BLOCKDIR.BD_L);
    }

    private void SettingBlock(BLOCKTYPE _Type, BLOCKDIR _Dir)
    {
        Arr = AllBlock[(int)_Type][(int)_Dir];
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
        Input();

        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if (Arr[y][x] == "□")
                {
                    continue;
                }
                Screen.SetBlock(Y+y, X+x, Arr[y][x]);
            }
        }
    }
}

