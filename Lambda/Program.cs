using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    delegate void Mydelegate(string _Name, int _Age);

    delegate string Message(string _Msg);

    static void Main(string[] args)
    {
    // 람다식은 객체지향보다는 함수지향에 가깝다.
    // 람다식 > 매개 변수를 가진 코드 블록 > 익명 구현 객체
    // 효율적인 람다 함수의 사용으로 불필요한 루프문의 삭제가 가능하며, 함수의 재활용이 용이



        // 람다식 문법 : 입력 매개변수 => 실행문장 로직;
        Mydelegate student = (name, age) =>
        {
            Console.WriteLine("이름 : {0}, 나이 : {1}", name, age);
        };
        student("박상경", 27);

        Message message = (str) =>
        {
            return str;
        };

        Console.WriteLine("이름 : {0}", message("박상경"));
    }
}

