using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * IDE ( Integrated Development Environment )
 -> 통합 개발환경 -> 프로그램을 만드는 것을 도와주는 프로그램
 -> 종류가 많다. / IDE { VScode, Eclips , ,,, 등등) 
 -> 
*/


class Player
{
    private int AT = 10;

    // 자료형을 선언했다면 이는 int와 관련된 함수라고 명시하는 것.
    // 변수처럼 보이고 쓰이지만 함수형이 속해있음
    // static 을 붙여서 정적프로퍼티가능.
    // -> m_ 을 붙여서 다르게 명시함 
    public int ProAT
    {
        // 프로퍼티의 GET 함수는 무조건 int 리턴한다고 보고
        get
        {
            return AT;
        }
        // 무조건 int하나가 들어온다고 생각한다.
        // 그런 외부 값들을 프로퍼티에서는 value라고 기호로 정의.
        set
        {
            AT = value;
        }
    }
    
    public int GetAT()
    {
        return AT;
    }

    public void SetAT(int _Value)
    {
        if (999 <= _Value)
        {
            Console.WriteLine("최대치 넘김");
            Console.ReadKey();
        }
            AT = _Value;
    }
}

namespace C_Sharp_Study 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Player NewPlayer = new Player();

            NewPlayer.SetAT(10000);

            // 프로퍼티 사용법
            NewPlayer.ProAT = 100;
            int PlayerAT = NewPlayer.ProAT;
        }
    }
}
