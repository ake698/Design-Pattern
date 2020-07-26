using System;
using System.Collections;
using System.Linq;

namespace Cmposite.Pattern
{
    class Program
    {
        //此为安全模式  
        //透明模式  将所有方法写至Component  子节点没有添加功能，所以需要在子类添加抛出异常
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            root.DoSth();
            //创建树枝
            Composite composite1 = new Composite("分支1");
            Composite composite2 = new Composite("分支2");
            //创建叶子
            Leaf leaf1 = new Leaf("叶子1");
            Leaf leaf2 = new Leaf("叶子2");
            Leaf leaf3 = new Leaf("叶子3");
            Leaf leaf4 = new Leaf("叶子4");
            //整体组合
            root.Add(composite1);
            root.Add(composite2);

            composite1.Add(leaf1);

            composite2.Add(leaf2);
            composite2.Add(leaf3);
            composite2.Add(leaf4);

            Display(root);


        }

        public static void Display(Composite root)
        {
            foreach(Component c in root.GetChildren())
            {
                if(c is Leaf)
                {
                    c.DoSth();
                }
                else
                {
                    c.DoSth();
                    Display((Composite)c);
                }
            }

        }
    }

    //简单迭代
    class Person : IEnumerable
    {
        string[] persons = { "jack", "tom", "miss" };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < persons.Length; i++)
            {
                yield return persons[i];
            }
        }

    }
}
