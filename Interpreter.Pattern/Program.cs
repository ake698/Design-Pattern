using System;
using System.Collections.Generic;

namespace Interpreter.Pattern
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string expStr = "a+b-c+d+f";
            //赋值
            Dictionary<string, int> dic = GetValue(expStr);
            Caculate cal = new Caculate(expStr);
            int result = cal.Run(dic);
            Console.WriteLine("表达式为:{0}，运算结果为:{1}",expStr, result);
        }

        static Dictionary<string, int> GetValue(string expStr)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach ( char c in expStr.ToCharArray())
            {
                if(c != '+' && c != '-')
                {
                    //解决重复参数问题
                    if (!dic.ContainsKey(c.ToString()))
                    {
                        //重新获取一个字符表示参数
                        //string tmp = string.Format("{0},{1}", c, c);
                        Console.WriteLine("请输入{0}的值:", c);
                        int n = Convert.ToInt32(Console.ReadLine());
                        dic.Add(c.ToString(), n);
                    }
                }
            }
            return dic;
        }

    }
}
