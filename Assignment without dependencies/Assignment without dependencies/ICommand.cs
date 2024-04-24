using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataXAssignment
{
    public interface ICommand
    {
        void Execute(ResultCalculator resultCalculator);
        void Undo(ResultCalculator resultCalculator);
    }
}
