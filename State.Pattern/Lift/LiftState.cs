using System;
using System.Collections.Generic;
using System.Text;

namespace State.Pattern.Lift
{
    public abstract class LiftState
    {
        protected Context context;
        public void SetContext(Context _context)
        {
            this.context = _context;
        }
        #region 电梯动作
        public abstract void Open();
        public abstract void Close();
        public abstract void Run();
        public abstract void Stop();

        #endregion
    }
}
