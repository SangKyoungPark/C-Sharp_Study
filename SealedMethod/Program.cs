using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Base
{
    public virtual void SealMe()
    {

    }
}

class Derived : Base
{
    // sealed override -> 오버라이딩 제한 1번만 가능
    public sealed override void SealMe()
    {

    }
}

class WantToOverride : Derived
{

    // 봉인 메소드는 파생 클래스의 작성자를 위한 기반 클래스 작성자의 배려.
    // 잘 못 오버라이딩 될 때 문제가 발생할 때 대비하여 사용.
    // 오바리이딩을 원치 않으면 virtual을 붙여지 않음녀 된다.
    // 문제는! 오버라이딩한 메소드
    // 오버라이딩한 메소드는 파생 클래스의 파생 클래스에서도 자동으로 오버라이딩이 가능
    // 그래서 이곳에 오버라이딩을 막을 수 있는 브레이크인 sealed 한정자가 필요한 것임
    //public override void SealMe(){ }
}

class Program
{
    static void Main(string[] args)
    {

    }
}

