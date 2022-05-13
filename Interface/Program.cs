using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용자 정의 자료형인데,
interface QuestUnit
{
    // 멤버변수 X
    // int a = 10;

    // 함수의 형태만 물려 줄 수 있는 문법이다.
    // 함수 선언만 할 수 있고 정의는 할 수 없다.
    // 따라서, Private 사용 불가 -> 물려주는 의도가 있기 때문
    // 하지만, 상속의 개념보다는 포함의 개념이다.
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);
}

class FightUnit
{
    int AT;
    int DMG;

    public void Damage()
    {

    }
}

class Player : FightUnit, QuestUnit
{

    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }
}

class Monster : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }
    public void Event(QuestUnit _OtherUnit)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Monster monster = new Monster();
        //QuestUnit questUnit = new QuestUnit();
        // 추상클래스나 인터페이스는 객체화가 되지 않음.

        QuestUnit NewQuest = monster;

        //업캐스팅 가능
        player.Talk(monster);
    }
}