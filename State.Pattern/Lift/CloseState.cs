using System;
using System.Collections.Generic;
using System.Text;

namespace State.Pattern.Lift
{
    public class CloseState : LiftState
    {
        public override void Close()
        {
            Console.WriteLine("closing......");
        }

        public override void Open()
        {
            base.context.SetLiftState(Context.openState);
            base.context.Open();
        }

        public override void Run()
        {
            base.context.SetLiftState(Context.runState);
            base.context.Run();
        }

        public override void Stop()
        {
            Console.WriteLine("do nothing...");
        }
    }
}
