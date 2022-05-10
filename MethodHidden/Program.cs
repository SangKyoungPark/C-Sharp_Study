using System;

namespace MethodHidden
{
    class Base
    {
        public void Method()
        {
            Console.WriteLine("Base.Method()");
        }
    }

    class Derived : Base
    {
        // new 를 붙이면 메소드를 숨길수가 있다.
        // 오버라이딩과 메소드 숨기기는 다른 문제임.
        // 이름 그대로 숨기는 것 뿐임.
        public new void Method()
        {
            Console.WriteLine("Derived.Method()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.Method();

            Derived derivedObj = new Derived();
            derivedObj.Method();

            Base baseOrDerived = new Derived();
            baseOrDerived.Method();
        }
    }
}
