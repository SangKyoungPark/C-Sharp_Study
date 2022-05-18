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
    TBLOCK BlockType = TBLOCK.BLOCK;

    TScreen Screen = null;
    
    public Block(TScreen _SCreen)
    {
        Screen = _SCreen;
    }

    private void input()
    {
        if (!Console.KeyAvailable)
        {
            return;
        }
        // 키를 눌렀다. Console.ReadKey()가 리턴된다.
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
            input();
        }
        Screen.SetBlock(X, Y, BlockType);
    }
}

