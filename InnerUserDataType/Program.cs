using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 이너 클래스 : 자기를 포함한 클래스
class Player
{
    // 자기 클래스 내부에 있을 뿐 다른 클래스이다.
    public class InvenSlot
    {
        void Select(Inven _inven)
        {
            //자신을 가지고 있는 클래스의 멤버변수를 
            // 마치 public 처럼 쓴다.
        }
    }

    // 그 클래스만 자기만 사용할 때 가장 많이 사용한다.
    // 플레이어의 내부에 넣어줄 수 도 있다.
    // 다른 곳에 정의될수도 있다.
    enum PLAYERJOB
    {
        NOVICE, // 초보자
        KNIGHT,
        FIGHTER,
        BERSERKER,
        FIGEMAGE,
    }

    // 직업과 관련된 멤버변수도 있어야 할 것.
    void ClassChange()
    {
        
    }
}

class Inven
{
    // 다른 곳에 정의될수도 있다.
    public enum INVENDIR
    {
        ID_LIFT, // 초보자
        ID_RIGHT,
        ID_UP,
        ID_DOwN,
    }
    // 어느 방향으로 움직이겠느냐?
    void SelectMove(/*방향을 의미할만한 인자값*/ )
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        // Player. -> private이라 안됨.

        Inven NewInven = new Inven();
        Inven.INVENDIR IDIR = Inven.INVENDIR.ID_LIFT;
        // 이럴거면 밖에 빼놔도 상관없음
        // 첫번째 장점
        // 1. 이름 겹침에서 자유롭다.
    }
}

