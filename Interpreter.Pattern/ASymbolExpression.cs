using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Pattern
{
    public abstract class ASymbolExpression : Expression
    {
        protected Expression left;
        protected Expression right;

        //所有解析公式 只关心左右俩个表达式的结果
        public ASymbolExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }
    }
}
