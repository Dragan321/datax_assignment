
namespace DataXAssignment.Commands
{
    public sealed class IncrementCommand : ICommand
    {
        public void Execute(ResultCalculator resultCalculator)
        {
            resultCalculator.Result++;
        }

        public void Undo(ResultCalculator resultCalculator)
        {
            resultCalculator.Result--;
        }
    }
}
