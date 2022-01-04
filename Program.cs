using System;

namespace MutareaPionul
{
    class Program
    {
        static void Main(string[] args)
        {
            var pion = new Pion();
            var pionFlow = new PionFlow(pion);
            pionFlow.ExecuteOperation(Operation.Down);
            pionFlow.ExecuteOperation(Operation.Up);
            pionFlow.ExecuteOperation(Operation.Up);
            pionFlow.ExecuteOperation(Operation.Right);
            pionFlow.ExecuteOperation(Operation.Right);




        }

    }
}
