using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataXAssignment.Commands
{
    public sealed class DoubleCommand : ICommand
    {
        public void Execute(ResultCalculator resultCalculator)
        {
            resultCalculator.Result*=2;
        }

        public void Undo(ResultCalculator resultCalculator)
        {
            resultCalculator.Result/=2;
        }
    }
}
