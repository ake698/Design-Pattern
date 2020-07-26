using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Pattern
{
    class SymbolExpression
    {
    }
    public class AddExpression : ASymbolExpression
    {
        public AddExpression(Expression left, Expression right) : base(left, right)
        {
        }

        public override int interpreter(Dictionary<string, int> dic)
        {
            return base.left.interpreter(dic) + base.right.interpreter(dic);
        }
    }

    public class SubExpression : ASymbolExpression
    {
        public SubExpression(Expression left, Expression right) : base(left, right)
        {
        }

        public override int interpreter(Dictionary<string, int> dic)
        {
            return base.left.interpreter(dic) - base.right.interpreter(dic);
        }
    }
}
