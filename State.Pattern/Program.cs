using State.Pattern.Lift;
using System;

namespace State.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            CloseState close = new CloseState();
            context.SetLiftState(close);
            context.Open();
            context.Close();
            context.Run();
            context.Run();
            context.Open();
            context.Run();
        }
    }
}
