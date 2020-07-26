using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Pattern
{
    public class Caculate
    {
        private Expression expression;
        public Caculate(string expStr)
        {
            Stack<Expression> stack = new Stack<Expression>();
            //表达式拆分数组
            char[] charArray = expStr.ToCharArray();
            //运算
            Expression left = null;
            Expression right = null;

            for (int i = 0; i < charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case '+':
                        left = stack.Pop();
                        right = new VarExpression(charArray[++i].ToString());
                        stack.Push(new AddExpression(left, right));
                        break;
                    case '-':
                        left = stack.Pop();
                        right = new VarExpression(charArray[++i].ToString());
                        stack.Push(new SubExpression(left, right));
                        break;
                    default:
                        stack.Push(new VarExpression(charArray[i].ToString()));
                        break;
                }
            }
            this.expression = stack.Pop();
        }
        public int Run(Dictionary<string, int> dic)
        {
            return this.expression.interpreter(dic);
        }
    }
}
