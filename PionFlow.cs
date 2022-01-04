using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutareaPionul
{
   public class PionFlow
    {
        private readonly Pion _pion;


        private readonly List<PionCommand> _commandHistory = new List<PionCommand>();

        public PionFlow(Pion pion)
        {
            _pion = pion;
        }

        public void ExecuteOperation(Operation operation)
        {
            var pionCommand = new PionCommand(_pion, operation);
            pionCommand.Execute();
            _commandHistory.Add(pionCommand);
        }

        public void Undo()
        {
            var lastCommand = _commandHistory.LastOrDefault();
            if (lastCommand == null) return;

            lastCommand.UnExecute();
            _commandHistory.Remove(lastCommand);
        }

        public void Redo()
        {
            var lastCommand = _commandHistory.LastOrDefault();
            lastCommand.Execute();
        }
    }
}
