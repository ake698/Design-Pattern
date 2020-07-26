using System;
using System.Collections.Generic;
using System.Text;

namespace State.Pattern.Lift
{
    public class OpenState : LiftState
    {
        public override void Close()
        {
            //更改状态
            base.context.SetLiftState(Context.closeState);
            //运行关闭函数
            base.context.Close();
        }

        public override void Open()
        {
            Console.WriteLine("openning.......");
        }

        public override void Run()
        {
            throw new NotImplementedException("电梯门都开了，跑个啥呀！");
        }

        public override void Stop()
        {
            Console.WriteLine("do nothing...");
        }
    }
}
