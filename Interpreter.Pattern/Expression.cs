using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Pattern
{
    public abstract class Expression
    {
        //key 为公式参数   value为具体的数字
        public abstract int interpreter(Dictionary<string, int> dic);
    }
}
