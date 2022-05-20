using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Block
{
    // 모든 블럭의 모양을 관리
    List<List<string[][]>> AllBlock = new List<List<string[][]>>();

    void DataInit()
    {
        for (int BT = 0; BT < (int)BLOCKTYPE.BT_MAX; BT++)
        {
            AllBlock.Add(new List<string[][]>());
            for (int BD = 0; BD < (int)BLOCKDIR.BD_MAX; BD++)
            {
                AllBlock[BT].Add(null);
            }
        }

        #region I
        {
            //작대기의 I
            AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_T] = new string[][]
            {
                new string[] { "■", "□", "□", "□" },
                new string[] { "■", "□", "□", "□" },
                new string[] { "■", "□", "□", "□" },
                new string[] { "■", "□", "□", "□" },
            };

            // 작대기의 R
            AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_R] = new string[][]
            {
                new string[] { "■", "■", "■", "■" },
                new string[] { "□", "□", "□", "□" },
                new string[] { "□", "□", "□", "□" },
                new string[] { "□", "□", "□", "□" },
            };
            // 작대기의 B
            AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_B] = new string[][]
            {
                new string[] { "■", "□", "□", "□" },
                new string[] { "■", "□", "□", "□" },
                new string[] { "■", "□", "□", "□" },
                new string[] { "■", "□", "□", "□" },
            };
            // 작대기의 L
            AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_L] = new string[][]
            {
                new string[] { "■", "■", "■", "■" },
                new string[] { "□", "□", "□", "□" },
                new string[] { "□", "□", "□", "□" },
                new string[] { "□", "□", "□", "□" },
            };
        }
        #endregion
        #region T
        //작대기의 T
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "□", "□", "□", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region L
        //작대기의 L
        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[] { "□", "□", "■", "□" },
            new string[] { "■", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "■", "■", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region Z
        //작대기의 Z
        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "■", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "□", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region S
        //작대기의 S
        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[] { "□", "■", "■", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "□", "■", "■", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "■", "□", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region O
        //작대기의 O
        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_T] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_R] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_B] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.BD_L] = new string[][]
        {
            new string[] { "■", "■", "□", "□" },
            new string[] { "■", "■", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
        };
        #endregion
    }
}

