using State.Pattern.Lift;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Pattern
{
    public class Context
    {
        public readonly static OpenState openState = new OpenState();
        public readonly static CloseState closeState = new CloseState();
        public readonly static RunState runState = new RunState();
        public readonly static StopState stopState = new StopState();

        private LiftState liftState;

        public LiftState GetLiftState()
        {
            return this.liftState;
        }

        public void SetLiftState(LiftState lift)
        {
            this.liftState = lift;
            this.liftState.SetContext(this);
        }

        public void Close()
        {
            this.liftState.Close();
        }

        public void Open()
        {
            this.liftState.Open();
        }

        public void Run()
        {
            this.liftState.Run();
        }

        public void Stop()
        {
            this.liftState.Stop();
        }

    }
}
