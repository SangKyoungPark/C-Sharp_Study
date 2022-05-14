using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적 변수와 정적 함수만을 내부
public static class GTest
{
    // 정적은 this 가 없다.
    // 생성자를 만들 수 없다.
    //public GTest()
    //{
    //}

    //public static void ConsolePrint(int _Value)
    //{
    //    Console.WriteLine(_Value);
    //}
    // 제네릭함수 멤버에도 통용된다.
    // 자료형을 변수처럼 사용하고 싶을 때.
    // 함수의 식별자에 <다양한 자료형 대표할 이름> 
    // 이걸 제네릭이라고함
    public static T ConsolePrint<T>(T _Value)
    {
        Console.WriteLine(_Value);
        return _Value;
    }

}

class Program
{
    static void Main(string[] args)
    {
        GTest.ConsolePrint(1000);
        GTest.ConsolePrint("이게 된다고??");
        GTest.ConsolePrint(3.14f);
    }
}