using System;
using System.Collections.Generic;
using System.Text;

namespace State.Pattern.Lift
{
    public class RunState : LiftState
    {
        public override void Close()
        {
            Console.WriteLine("门已经关闭....");
        }

        public override void Open()
        {
            throw new NotImplementedException("运行过程，不能开门");
        }

        public override void Run()
        {
            Console.WriteLine("running.....");
        }

        public override void Stop()
        {
            base.context.SetLiftState(Context.stopState);
            base.context.GetLiftState().Stop();
        }
    }
}
