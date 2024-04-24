using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataXAssignment.Commands
{
    public sealed class RandomAddCommand : ICommand
    {
        //kepping track of the generated value in case of undo operation
        private double randomValue;

        public void Execute(ResultCalculator resultCalculator)
        {
            randomValue = new Random().Next();
            resultCalculator.Result += randomValue;
        }

        public void Undo(ResultCalculator resultCalculator)
        {
            resultCalculator.Result -= randomValue;
        }
    }
}
