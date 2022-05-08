using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// C#에서는 오직 단하나의 클래스만 상속할 수 있다.
// C++ / JAVA는 여러개 가능
class FightUnit
{
    protected int AT = 10;
    protected int HP = 100;

    // 프로퍼티 사용
    public String Name { get; set; }
    public int Age { get; set; }
    public void Damage(/*FightUnit this ,*/FightUnit _OtherUnit)
    {
        HP -= _OtherUnit.AT;
    }
}

// 방법은 공통되는 멤버 변수 / 함수
class Player : FightUnit
{
    private int Lv;
}

class Monster : FightUnit
{
}

namespace Inheritance
{
    // 상속이란
    // 코드 재활용성을 향상시키기 위해서 -> 똑같은 코드 2번 치기 싫다.
    // 함수도 사실 똑같은 기능 
    // 어떤 계열이 있냐를 파악하는 감.
    // 플레이어 - 몬스터 -> 싸우기 위한 기능(함수)
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Monster monster = new Monster();

            FightUnit FU = new FightUnit();
            // 플레이어의 부분을 모두 다 포기하겠다.
            // 업캐스팅
            // 자식이 부모형이 되는 것.
            // 그러므로서 자식의 능력은 버린다.

            // 다운캐스팅은 최대한 지양(피해라)
            // 플레이어를 실수로 몬스터로 변경할수도 있게 된다.
            // Player OtherPlayer = _OtherUnit; 

            player.Damage(FU);
        }
    }
}
