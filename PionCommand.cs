using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutareaPionul
{
    public class PionCommand : Command
    {
        private Operation _operation;
        private Pion _pion;

        public PionCommand(Pion pion, Operation operation)
        {
            _operation = operation;
            _pion = pion;
        }


        public override void Execute()
        {
            _pion.Move(_operation);
        }

        public override void UnExecute()
        {
            _pion.Move(UndoOperation(_operation));
        }
        private Operation UndoOperation(Operation operation)
        {
            switch (operation)
            {
                case Operation.Right:
                    return Operation.Left;
                case Operation.Left:
                    return Operation.Right;
                case Operation.Down:
                    return Operation.Up;
                case Operation.Up:
                    return Operation.Down;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }
    }
}
