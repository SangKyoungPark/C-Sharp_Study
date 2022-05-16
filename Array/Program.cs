using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    class Item
    {
        string Name;
        int AT;
    }
    static void Main(string[] args)
    {
        // 배열은 기본적으로 자료형이라고 할 수 있으며,
        // 기본 자료형에 속한다.

        // 모든 자료형은 구조체 아니면 클래스에 가까운데
        // 기본자료형도 마찬가지라고 표현했다.
        int[] ArrInt = new int[10];

        //ArrInt[0]은 무슨 자료형인가?


        // C# 에서는 모든 자료형은 클래스 혹은 구조체에 가깝다
        // 멤버변수와 멤버 함수가 있다.
        Console.WriteLine(ArrInt[0]);


        // 여러개가 모여있는 것.
        // 연속되어있다.
        // 접근방법 -> 모여있는 자료들
        // Index를 통해 접근함 -> 맨 처음 주소 가지고 있음
        // 배열(ArrInt.Length() 프로퍼티가 있다. -> {get;}
        for(int i=0; i< ArrInt.Length; i++)
        {
            Console.WriteLine(ArrInt[i]);
        }

        // 아이템이라는 참조형 공간 10개 생성
        Item[] ArrItem = new Item[10];

        for(int i=0; i< ArrItem.Length; i++)
        {
            // 힙에 메모리 할당해서 스택에 있는 참조형 공간과 연결
            ArrItem[i] = new Item();
        }
    }
}

