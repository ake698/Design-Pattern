using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Pattern
{
    //变量解析器
    public class VarExpression : Expression
    {
        private string key;
        public VarExpression(string key)
        {
            this.key = key;
        }
        
        //获取公式中的数字
        public override int interpreter(Dictionary<string, int> dic)
        {
            return dic[this.key];
        }
    }
}
