using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// C# delegate는 내부적으로 .NET Delegate / MulticastDelegate 클래스 사용
// 델리게이트(Delegate)란
// 메서드에 대한 참조를 의미
// 델리게이트에 메서드의 주소를 할당한 후에 델리게이트를 호출하면 이 델리게이트가 메서드를 호출
// 델리게이트는 콜백메서드(CallBack Method)를 구현할 때 많이 사용됨.
// 델리게이트가 호출할 때마다 원하는 메서드를 불러와 지정된 메서드를 실행할 수 있음.
class MySort
{
    // 델리게이트 CompareDelegate 선언
    public delegate int CompareDelegate(int i1, int i2);

    public static void Sort(int[] arr, CompareDelegate comp)
    {
        if (arr.Length < 2) return;
        Console.WriteLine("함수 Prototype: " + comp.Method);

        int ret;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                ret = comp(arr[i], arr[j]);
                if (ret == -1)
                {
                    // 교환
                    int tmp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = tmp;
                }
            }
        }
        Display(arr);
    }
    static void Display(int[] arr)
    {
        foreach (var i in arr) Console.Write(i + " ");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        new Program().Run();
    }

    void Run()
    {
        int[] a = { 5, 53, 3, 7, 1 };

        // 올림차순으로 소트
        MySort.CompareDelegate compDelegate = AscendingCompare;
        MySort.Sort(a, compDelegate);

        // 내림차순으로 소트
        compDelegate = DescendingCompare;
        MySort.Sort(a, compDelegate);
    }

    // CompareDelegate 델리게이트와 동일한 Prototype
    int AscendingCompare(int i1, int i2)
    {
        if (i1 == i2) return 0;
        return (i2 - i1) > 0 ? 1 : -1;
    }

    // CompareDelegate 델리게이트와 동일한 Prototype
    int DescendingCompare(int i1, int i2)
    {
        if (i1 == i2) return 0;
        return (i1 - i2) > 0 ? 1 : -1;
    }
}